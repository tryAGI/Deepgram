# CLAUDE.md — Deepgram SDK

## Overview

Auto-generated C# SDK for [Deepgram](https://deepgram.com/) — speech-to-text, text-to-speech, text analysis, models, projects, and billing.

## Build & Test

```bash
dotnet build Deepgram.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Deepgram API key:

```csharp
var client = new DeepgramClient(apiKey); // DEEPGRAM_API_KEY env var
```

## Key Files

- `src/libs/Deepgram/generate.sh` — Regeneration script (downloads spec from deepgram-api-specs, runs autosdk)
- `src/libs/Deepgram/Generated/` — **Never edit** — auto-generated code
- `src/libs/Deepgram/Extensions/DeepgramClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## MEAI Integration

- **Interface:** `ISpeechToTextClient`
- **Namespace conflict:** No — uses `using Microsoft.Extensions.AI;` directly
- **Sub-client delegation:** `DeepgramClient.Listen.ListenV1MediaTranscribeAsync()`
- **URL-only:** Audio URL provided via `RawRepresentationFactory` with `ListenV1RequestUrl`; throws `NotSupportedException` if no URL given
- **Features:** Pre-recorded transcription, timestamps, language/model selection

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml` (3.1.0)
- Note: Official .NET SDK exists (`Deepgram` on NuGet) but lacks MEAI integration

## NuGet

- **PackageId:** `tryAGI.Deepgram` (bare name taken by official SDK)
