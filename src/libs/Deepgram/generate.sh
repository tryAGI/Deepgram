dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -sL "https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml" -o openapi.yaml

# Fix auth: convert apiKey scheme to http/bearer and add top-level security
# Fix servers: use only the main API base URL
yq -i '
  .components.securitySchemes.ApiKeyAuth = {
    "type": "http",
    "scheme": "bearer"
  } |
  .security = [{"ApiKeyAuth": []}] |
  .servers = [{"url": "https://api.deepgram.com"}]
' openapi.yaml

# Fix ErrorResponseTextError: it's `type: string` which causes AutoSDK to generate
# a property named `string` (C# keyword). Convert to an object with a `value` property.
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

# Generate WebSocket clients from AsyncAPI spec (ListenV1 + ListenV2 channels)
# Uses a curated multi-channel asyncapi.json checked into the repo (derived from
# Deepgram's upstream asyncapi.yml but simplified for AutoSDK compatibility).
# ListenV2 (Flux) uses const discriminators; ListenV1 uses enum discriminators.
autosdk generate asyncapi.json \
  --namespace Deepgram.Realtime \
  --websocket-class-name DeepgramRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated
