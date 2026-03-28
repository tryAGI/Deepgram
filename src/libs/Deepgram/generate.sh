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

# Auth: --security-scheme overrides AsyncAPI's httpApiKey/JwtAuth with HTTP bearer.
autosdk generate asyncapi.json \
  --namespace Deepgram.Realtime \
  --websocket-class-name DeepgramRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer

# Fix 2: CS1573 pragma suppression — AsyncAPI-generated ConnectAsync methods omit
#         <param> tags for `uri` and `cancellationToken`.
for f in Generated/Deepgram.Realtime.Deepgram*RealtimeClient.g.cs; do
  if grep -q '/// <param name=' "$f"; then
    printf '%s\n' '#pragma warning disable CS1573 // Missing XML comment for publicly visible type or member' "$(cat "$f")" > "$f"
  fi
done
