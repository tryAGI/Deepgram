# CLAUDE.md — Deepgram SDK

## Overview

Auto-generated C# SDK for [Deepgram](https://deepgram.com/) — speech-to-text, text-to-speech, text analysis, voice agents, models, projects, and billing. Includes both REST (OpenAPI) and WebSocket (AsyncAPI) clients.

## Build & Test

```bash
dotnet build Deepgram.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Token auth with Deepgram API key (uses `Token` scheme, not `Bearer`):

```csharp
var client = new DeepgramClient(apiKey); // DEEPGRAM_API_KEY env var
```

**Important:** Deepgram uses `Authorization: Token <key>`, not `Authorization: Bearer <key>`. The `Authorized` partial hook in `DeepgramClient.Auth.cs` rewrites the scheme:

```csharp
// In Extensions/DeepgramClient.Auth.cs
partial void Authorized(HttpClient client)
{
    for (int i = 0; i < Authorizations.Count; i++)
    {
        var auth = Authorizations[i];
        if (auth is { Type: "Http", Name: "Bearer" })
            Authorizations[i] = new EndPointAuthorization
            { Type = auth.Type, Location = auth.Location, Name = "Token", Value = auth.Value };
    }
}
```

The WebSocket clients (`DeepgramRealtimeClient.Auth.cs`) apply the same Token scheme conversion.

> **Note:** The `--security-scheme ApiKey:Header:Authorization` CLI arg could potentially replace the jq auth conversion + `Authorized` hook, but Deepgram's `Token` scheme (using the `Authorization` header with a non-standard scheme name) is not directly expressible via `--security-scheme`.

## Key Files

- `src/libs/Deepgram/generate.sh` — Regeneration script (OpenAPI + upstream AsyncAPI)
- `src/libs/Deepgram/Generated/` — **Never edit** — auto-generated code
- `src/libs/Deepgram/Extensions/DeepgramClient.Auth.cs` — REST auth fix: Bearer → Token
- `src/libs/Deepgram/Extensions/DeepgramRealtimeClient.Auth.cs` — WebSocket auth fix: Token scheme (all 4 channels)
- `src/libs/Deepgram/Extensions/DeepgramClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Multi-Spec Architecture (4 Channels)

This SDK uses both OpenAPI and AsyncAPI specs:

| Spec | Namespace | Client(s) | Purpose |
|------|-----------|-----------|---------|
| OpenAPI (`openapi.yaml`) | `Deepgram` | `DeepgramClient` | REST API: pre-recorded transcription, TTS, models, billing |
| AsyncAPI (upstream `asyncapi.yml`) | `Deepgram.Realtime` | `DeepgramSpeakV1RealtimeClient`, `DeepgramListenV1RealtimeClient`, `DeepgramListenV2RealtimeClient`, `DeepgramAgentV1RealtimeClient` | WebSocket: real-time streaming |

The AsyncAPI spec is **fetched directly from Deepgram's upstream repo** (`asyncapi.yml`). AutoSDK natively handles:
- **Inline message payloads** → automatically extracted to component schemas
- **Per-channel server refs** → AgentV1 uses `agent.deepgram.com`, others use `api.deepgram.com`
- **operationTraits** → parsed for spec compliance

### SpeakV1 Client (`DeepgramSpeakV1RealtimeClient`)

Text-to-speech streaming:
- `SendSpeakV1TextAsync()` — send text for TTS
- `SendSpeakV1FlushAsync()` — flush buffer, receive final audio
- `SendSpeakV1ClearAsync()` — clear buffer
- `SendSpeakV1CloseAsync()` — close gracefully
- `ReceiveUpdatesAsync()` → audio chunks, metadata, control events, warnings

### ListenV1 Client (`DeepgramListenV1RealtimeClient`)

Classic speech-to-text streaming:
- `ConnectAsync(Uri?)` — connect to WebSocket endpoint
- `SendAsync(bytes)` — send binary audio frames
- `SendListenV1FinalizeAsync()` — flush transcription buffer
- `SendListenV1CloseStreamAsync()` — close stream gracefully
- `SendListenV1KeepAliveAsync()` — keep connection alive
- `ReceiveUpdatesAsync()` → `IAsyncEnumerable<ListenV1ServerEvent>` — discriminated union with:
  - `IsListenV1ResultsEvent` → transcript, is_final, speech_final, words, confidence
  - `IsListenV1MetadataEvent` → request_id, duration, channels
  - `IsListenV1UtteranceEndEvent` → last_word_end
  - `IsListenV1SpeechStartedEvent` → timestamp

### ListenV2 Client (`DeepgramListenV2RealtimeClient`)

Flux conversational STT with contextual turn detection:
- `ConnectAsync(Uri?)` — connect to WebSocket endpoint
- `SendAsync(bytes)` — send binary audio frames
- `SendListenV2CloseStreamAsync()` — close stream
- `SendListenV2ConfigureAsync()` — update Flux settings
- `ReceiveUpdatesAsync()` → discriminated union with:
  - `IsListenV2ConnectedEvent` → request_id, sequence_id
  - `IsListenV2TurnInfoEvent` → transcript, words, event, turn_index, end_of_turn_confidence
  - `IsListenV2ConfigureSuccessEvent` / `IsListenV2ConfigureFailureEvent`
  - `IsListenV2FatalErrorEvent`

### AgentV1 Client (`DeepgramAgentV1RealtimeClient`)

Voice agent channel (uses `agent.deepgram.com`):
- `SendAgentV1SettingsAsync()` — configure agent
- `SendAgentV1UpdateSpeakAsync()` / `SendAgentV1UpdateThinkAsync()` — update agent behavior
- `SendAgentV1InjectUserMessageAsync()` / `SendAgentV1InjectAgentMessageAsync()`
- `SendAgentV1FunctionCallResponseAsync()` — respond to function calls
- `SendAgentV1KeepAliveAsync()` — keep alive
- `ReceiveUpdatesAsync()` → welcome, settings applied, conversation text, thinking, function calls, audio, errors, warnings

## MEAI Integration

- **Interface:** `ISpeechToTextClient`
- **Namespace conflict:** No — uses `using Microsoft.Extensions.AI;` directly
- **`GetTextAsync`:** REST pre-recorded transcription via `DeepgramClient.Listen.TranscribeAsync()`. Requires audio URL via `RawRepresentationFactory` with `ListenV1RequestUrl`
- **`GetStreamingTextAsync`:** True WebSocket streaming via `DeepgramListenV1RealtimeClient`. Sends audio as binary frames, yields `SpeechToTextResponseUpdate` with interim (`TextUpdating`) and final (`TextUpdated`) results
- **Features:** Pre-recorded transcription, real-time streaming STT, timestamps, language/model selection, interim results

## Known Issues

- **Bool query params:** Generated code serializes `bool` as `True`/`False` (C# default) in query strings, but Deepgram expects `true`/`false`. Avoid passing bool params like `punctuate`/`smartFormat` until AutoSDK fixes this.

## Spec Notes

The `generate.sh` applies fixes via `yq` (pre-generation) and `sed` (post-generation):

**Pre-generation (`yq`):**
1. **REST auth conversion:** Converts `apiKey` security scheme to `http/bearer`; sets server to `https://api.deepgram.com`
2. **ErrorResponseTextError fix:** Converts `type: string` schema to object with `value` property (avoids C# reserved keyword `string` as property name)
3. **AsyncAPI auth conversion:** Converts `httpApiKey` scheme to `http/bearer`; removes `JwtAuth`

**Post-generation (`sed`):**
4. **CS1573 pragma suppression:** Injects `#pragma warning disable CS1573` in AsyncAPI-generated WebSocket client files (missing XML param doc comments from inherited parameters)

**Spec sources:**
- OpenAPI: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml` (3.1.0)
- AsyncAPI: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/asyncapi.yml` (3.0.0) — used directly (upstream)
- Note: Official .NET SDK exists (`Deepgram` on NuGet) but lacks MEAI integration

## NuGet

- **PackageId:** `tryAGI.Deepgram` (bare name taken by official SDK)
