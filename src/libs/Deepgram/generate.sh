#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml (+ AsyncAPI)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L "https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml" -o openapi.yaml

# Fix 1: ErrorResponseTextError is `type: string` which generates a property named
#         `string` (C# keyword). Convert to object with `value` property.
yq -i '
  .components.schemas.ErrorResponseTextError = {
    "type": "object",
    "properties": {
      "value": {
        "type": "string",
        "description": "The error message text"
      }
    }
  }
' openapi.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with HTTP bearer.
# --base-url injects server URL (spec has no servers section).
autosdk generate openapi.yaml \
  --namespace Deepgram \
  --clientClassName DeepgramClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --base-url https://api.deepgram.com

# Generate WebSocket clients from upstream AsyncAPI spec (4 channels:
# SpeakV1, ListenV1, ListenV2, AgentV1). AutoSDK natively handles:
# - Inline message payloads → extracted to component schemas automatically
# - Per-channel server refs → AgentV1 uses agent.deepgram.com
# - operationTraits → parsed for spec compliance
curl --fail --silent --show-error -L "https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/asyncapi.yml" -o asyncapi.yaml

# Convert YAML to JSON for reliable parsing
yq -o json asyncapi.yaml > asyncapi.json

# Fix 2: Upstream currently publishes an AsyncAPI 2.6 document with
#         channel-level publish/subscribe operations. AutoSDK's WebSocket
#         generator consumes AsyncAPI 3-style top-level operations, so normalize
#         the channel blocks before generation.
jq '
  def channel_name($path):
    if $path == "/v1/listen" then "ListenV1"
    elif $path == "/v2/listen" then "ListenV2"
    elif $path == "/v1/speak" then "SpeakV1"
    elif $path == "/v1/agent/converse" then "AgentV1"
    else ($path
      | split("/")
      | map(select(length > 0))
      | map(ascii_downcase | split("_") | map(.[0:1] | ascii_upcase + .[1:]) | join(""))
      | join(""))
    end;
  def message_refs($op):
    (($op.message.oneOf // (if $op.message then [$op.message] else [] end)) | map(."$ref"));
  def component_message_key($ref):
    ($ref | split("#/components/messages/")[1]);
  def message_name($ref):
    ($ref | split("/")[-1] | split("-")[-1]);

  . as $root
  | .asyncapi = "3.0.0"
  | .servers = {
      production: {host: "api.deepgram.com", protocol: "wss"},
      agent: {host: "agent.deepgram.com", protocol: "wss"}
    }
  | .channels = (
      reduce ($root.channels | to_entries[]) as $c ({};
        (channel_name($c.key)) as $name
        | .[$name] = ($c.value
          | .address = $c.key
          | .servers = [{"$ref": (if $name == "AgentV1" then "#/servers/agent" else "#/servers/production" end)}]
          | .messages = (
              reduce ((message_refs($c.value.publish // {}) + message_refs($c.value.subscribe // {}))[]) as $ref ({};
                .[message_name($ref)] = ($root.components.messages[component_message_key($ref)] // {"$ref": $ref}))
            )
          | del(.publish, .subscribe))
      )
    )
  | .operations = (
      reduce ($root.channels | to_entries[]) as $c ({};
        (channel_name($c.key)) as $name
        | reduce (message_refs($c.value.publish // {})[]) as $ref (.;
            (message_name($ref)) as $messageName
            | .[$messageName] = {
                description: ($root.components.messages[component_message_key($ref)].description // ""),
                action: "receive",
                channel: {"$ref": ("#/channels/" + $name)},
                messages: [{"$ref": ("#/channels/" + $name + "/messages/" + $messageName)}]
              })
        | reduce (message_refs($c.value.subscribe // {})[]) as $ref (.;
            (message_name($ref)) as $messageName
            | .[$messageName] = {
                description: ($root.components.messages[component_message_key($ref)].description // ""),
                action: "send",
                channel: {"$ref": ("#/channels/" + $name)},
                messages: [{"$ref": ("#/channels/" + $name + "/messages/" + $messageName)}]
              })
      )
    )
' asyncapi.json > asyncapi.tmp.json && mv asyncapi.tmp.json asyncapi.json

# Fix 3: AsyncAPI spec has two security schemes (ApiKeyAuth + JwtAuth) that both
#         map to HTTP bearer after --security-scheme override, producing duplicate
#         AuthorizeUsingBearer methods. Remove JwtAuth to keep only one.
jq 'del(.components.securitySchemes.JwtAuth)' asyncapi.json > asyncapi.tmp.json && mv asyncapi.tmp.json asyncapi.json

# Auth: --security-scheme overrides AsyncAPI's httpApiKey with HTTP bearer.
autosdk generate asyncapi.json \
  --namespace Deepgram.Realtime \
  --websocket-class-name DeepgramRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer
