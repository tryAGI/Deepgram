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

**Important:** Deepgram uses `Authorization: Token <key>`, not `Authorization: Bearer <key>`. Both the REST client (`DeepgramClient.Auth.cs`) and the WebSocket client (`DeepgramRealtimeClient.Auth.cs`) override the generated Bearer scheme to Token.

## Key Files

- `src/libs/Deepgram/generate.sh` — Regeneration script (OpenAPI + AsyncAPI)
- `src/libs/Deepgram/asyncapi.json` — Curated AsyncAPI 3.0.0 spec for ListenV1 WebSocket STT
- `src/libs/Deepgram/Generated/` — **Never edit** — auto-generated code
- `src/libs/Deepgram/Extensions/DeepgramClient.Auth.cs` — REST auth fix: Bearer → Token
- `src/libs/Deepgram/Extensions/DeepgramRealtimeClient.Auth.cs` — WebSocket auth fix: Token scheme
- `src/libs/Deepgram/Extensions/DeepgramClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Dual-Spec Architecture

This SDK uses both OpenAPI and AsyncAPI specs:

| Spec | Namespace | Client | Purpose |
|------|-----------|--------|---------|
| OpenAPI (`openapi.yaml`) | `Deepgram` | `DeepgramClient` | REST API: pre-recorded transcription, TTS, models, billing |
| AsyncAPI (`asyncapi.json`) | `Deepgram.Realtime` | `DeepgramRealtimeClient` | WebSocket: real-time streaming STT (ListenV1) |

The AsyncAPI spec is a **curated single-channel extract** from Deepgram's upstream multi-channel spec (`asyncapi.yml`). AutoSDK requires single-channel AsyncAPI specs, so we maintain `asyncapi.json` with just the ListenV1 channel. The upstream spec has 4 channels (SpeakV1, ListenV1, ListenV2, AgentV1); additional channels can be added to separate specs if needed.

### WebSocket Client (`DeepgramRealtimeClient`)

Generated in `Deepgram.Realtime` namespace with:
- `ConnectAsync(Uri?)` — connect to WebSocket endpoint
- `SendAsync(bytes)` — send binary audio frames
- `SendFinalizeAsync()` — flush transcription buffer
- `SendCloseStreamAsync()` — close stream gracefully
- `SendKeepAliveAsync()` — keep connection alive
- `ReceiveUpdatesAsync()` → `IAsyncEnumerable<ServerEvent>` — discriminated union with:
  - `IsResults` → `ResultsPayload` (transcript, is_final, speech_final, words, confidence)
  - `IsMetadata` → `MetadataPayload` (request_id, duration, channels)
  - `IsUtteranceEnd` → `UtteranceEndPayload` (last_word_end)
  - `IsSpeechStarted` → `SpeechStartedPayload` (timestamp)

## MEAI Integration

- **Interface:** `ISpeechToTextClient`
- **Namespace conflict:** No — uses `using Microsoft.Extensions.AI;` directly
- **`GetTextAsync`:** REST pre-recorded transcription via `DeepgramClient.Listen.TranscribeAsync()`. Requires audio URL via `RawRepresentationFactory` with `ListenV1RequestUrl`
- **`GetStreamingTextAsync`:** True WebSocket streaming via `DeepgramRealtimeClient`. Sends audio as binary frames, yields `SpeechToTextResponseUpdate` with interim (`TextUpdating`) and final (`TextUpdated`) results
- **Features:** Pre-recorded transcription, real-time streaming STT, timestamps, language/model selection, interim results

## Known Issues

- **Bool query params:** Generated code serializes `bool` as `True`/`False` (C# default) in query strings, but Deepgram expects `true`/`false`. Avoid passing bool params like `punctuate`/`smartFormat` until AutoSDK fixes this.
- **AsyncAPI multi-channel:** AutoSDK doesn't support multi-channel AsyncAPI specs. The curated `asyncapi.json` only covers ListenV1. SpeakV1, ListenV2 (Flux), and AgentV1 channels would need separate specs.

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml` (3.1.0)
- AsyncAPI upstream: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/asyncapi.yml` (3.0.0)
- Note: Official .NET SDK exists (`Deepgram` on NuGet) but lacks MEAI integration

## NuGet

- **PackageId:** `tryAGI.Deepgram` (bare name taken by official SDK)
