dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -sL "https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml" -o openapi.yaml

# Fix 1: Convert apiKey scheme to http/bearer, add top-level security, set server URL.
yq -i '
  .components.securitySchemes.ApiKeyAuth = {
    "type": "http",
    "scheme": "bearer"
  } |
  .security = [{"ApiKeyAuth": []}] |
  .servers = [{"url": "https://api.deepgram.com"}]
' openapi.yaml

# Fix 2: ErrorResponseTextError is `type: string` which generates a property named
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

autosdk generate openapi.yaml \
  --namespace Deepgram \
  --clientClassName DeepgramClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

# Generate WebSocket clients from upstream AsyncAPI spec (4 channels:
# SpeakV1, ListenV1, ListenV2, AgentV1). AutoSDK natively handles:
# - Inline message payloads → extracted to component schemas automatically
# - Per-channel server refs → AgentV1 uses agent.deepgram.com
# - operationTraits → parsed for spec compliance
curl -sL "https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/asyncapi.yml" -o asyncapi.yaml

# Fix 3: Convert AsyncAPI httpApiKey to http/bearer, remove JwtAuth.
yq -i '
  .components.securitySchemes.ApiKeyAuth = {
    "type": "http",
    "scheme": "bearer"
  } |
  del(.components.securitySchemes.JwtAuth)
' asyncapi.yaml

# Convert YAML to JSON for reliable parsing
yq -o json asyncapi.yaml > asyncapi.json

autosdk generate asyncapi.json \
  --namespace Deepgram.Realtime \
  --websocket-class-name DeepgramRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated

# Fix 4: CS1573 pragma suppression — AsyncAPI-generated ConnectAsync methods omit
#         <param> tags for `uri` and `cancellationToken`.
for f in Generated/Deepgram.Realtime.Deepgram*RealtimeClient.g.cs; do
  if grep -q '/// <param name=' "$f"; then
    sed -i '' '1s/^/#pragma warning disable CS1573 \/\/ Missing XML comment for publicly visible type or member\n/' "$f"
  fi
done
