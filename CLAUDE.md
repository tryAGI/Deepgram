# CLAUDE.md — Deepgram SDK

## Overview

Auto-generated C# SDK for [Deepgram](https://deepgram.com/) — speech-to-text, text-to-speech, text analysis, models, projects, and billing. Includes both REST (OpenAPI) and WebSocket (AsyncAPI) clients.

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

**Important:** Deepgram uses `Authorization: Token <key>`, not `Authorization: Bearer <key>`. Both the REST client (`DeepgramClient.Auth.cs`) and the WebSocket clients (`DeepgramRealtimeClient.Auth.cs`) override the generated Bearer scheme to Token.

## Key Files

- `src/libs/Deepgram/generate.sh` — Regeneration script (OpenAPI + AsyncAPI)
- `src/libs/Deepgram/asyncapi.json` — Curated multi-channel AsyncAPI 3.0.0 spec (ListenV1 + ListenV2)
- `src/libs/Deepgram/Generated/` — **Never edit** — auto-generated code
- `src/libs/Deepgram/Extensions/DeepgramClient.Auth.cs` — REST auth fix: Bearer → Token
- `src/libs/Deepgram/Extensions/DeepgramRealtimeClient.Auth.cs` — WebSocket auth fix: Token scheme (ListenV1 + ListenV2)
- `src/libs/Deepgram/Extensions/DeepgramClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Multi-Spec Architecture

This SDK uses both OpenAPI and AsyncAPI specs:

| Spec | Namespace | Client(s) | Purpose |
|------|-----------|-----------|---------|
| OpenAPI (`openapi.yaml`) | `Deepgram` | `DeepgramClient` | REST API: pre-recorded transcription, TTS, models, billing |
| AsyncAPI (`asyncapi.json`) | `Deepgram.Realtime` | `DeepgramListenV1RealtimeClient`, `DeepgramListenV2RealtimeClient` | WebSocket: real-time streaming STT |

The AsyncAPI spec is a **curated multi-channel extract** from Deepgram's upstream spec (`asyncapi.yml`). It covers ListenV1 (classic STT, `enum` discriminators) and ListenV2 (Flux conversational STT, `const` discriminators). The upstream spec has 4 channels (SpeakV1, ListenV1, ListenV2, AgentV1); SpeakV1 and AgentV1 can be added later.

### ListenV1 Client (`DeepgramListenV1RealtimeClient`)

Classic speech-to-text streaming:
- `ConnectAsync(Uri?)` — connect to WebSocket endpoint
- `SendAsync(bytes)` — send binary audio frames
- `SendFinalizeAsync()` — flush transcription buffer
- `SendCloseStreamAsync()` — close stream gracefully
- `SendKeepAliveAsync()` — keep connection alive
- `ReceiveUpdatesAsync()` → `IAsyncEnumerable<ListenV1ServerEvent>` — discriminated union with:
  - `IsResults` → `ResultsPayload` (transcript, is_final, speech_final, words, confidence)
  - `IsMetadata` → `MetadataPayload` (request_id, duration, channels)
  - `IsUtteranceEnd` → `UtteranceEndPayload` (last_word_end)
  - `IsSpeechStarted` → `SpeechStartedPayload` (timestamp)

### ListenV2 Client (`DeepgramListenV2RealtimeClient`)

Flux conversational STT with contextual turn detection:
- `ConnectAsync(Uri?)` — connect to WebSocket endpoint
- `SendAsync(bytes)` — send binary audio frames
- `SendV2CloseStreamAsync()` — close stream
- `ReceiveUpdatesAsync()` → `IAsyncEnumerable<ListenV2ServerEvent>` — discriminated union with:
  - `IsConnectedPayload` → `V2ConnectedPayload` (request_id, sequence_id)
  - `IsTurnInfoPayload` → `V2TurnInfoPayload` (transcript, words, event, turn_index, end_of_turn_confidence)
  - `IsConfigureSuccessPayload` → `V2ConfigureSuccessPayload`
  - `IsConfigureFailurePayload` → `V2ConfigureFailurePayload`

**Note:** ListenV2 uses `const` discriminators (e.g., `const: "TurnInfo"`) instead of `enum`, supported by AutoSDK's const discriminator feature.

## MEAI Integration

- **Interface:** `ISpeechToTextClient`
- **Namespace conflict:** No — uses `using Microsoft.Extensions.AI;` directly
- **`GetTextAsync`:** REST pre-recorded transcription via `DeepgramClient.Listen.TranscribeAsync()`. Requires audio URL via `RawRepresentationFactory` with `ListenV1RequestUrl`
- **`GetStreamingTextAsync`:** True WebSocket streaming via `DeepgramListenV1RealtimeClient`. Sends audio as binary frames, yields `SpeechToTextResponseUpdate` with interim (`TextUpdating`) and final (`TextUpdated`) results
- **Features:** Pre-recorded transcription, real-time streaming STT, timestamps, language/model selection, interim results

## Known Issues

- **Bool query params:** Generated code serializes `bool` as `True`/`False` (C# default) in query strings, but Deepgram expects `true`/`false`. Avoid passing bool params like `punctuate`/`smartFormat` until AutoSDK fixes this.

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml` (3.1.0)
- AsyncAPI upstream: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/asyncapi.yml` (3.0.0)
- Note: Official .NET SDK exists (`Deepgram` on NuGet) but lacks MEAI integration

## NuGet

- **PackageId:** `tryAGI.Deepgram` (bare name taken by official SDK)
