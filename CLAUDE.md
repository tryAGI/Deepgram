# CLAUDE.md — Deepgram SDK

## Overview

Auto-generated C# SDK for [Deepgram](https://deepgram.com/) — speech-to-text, text-to-speech, text analysis, models, projects, and billing.

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

**Important:** Deepgram uses `Authorization: Token <key>`, not `Authorization: Bearer <key>`. The `DeepgramClient.Auth.cs` extension overrides the generated Bearer scheme to Token via the `Authorized` partial method hook.

## Key Files

- `src/libs/Deepgram/generate.sh` — Regeneration script (downloads spec from deepgram-api-specs, runs autosdk)
- `src/libs/Deepgram/Generated/` — **Never edit** — auto-generated code
- `src/libs/Deepgram/Extensions/DeepgramClient.Auth.cs` — Fixes auth scheme: Bearer → Token
- `src/libs/Deepgram/Extensions/DeepgramClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## MEAI Integration

- **Interface:** `ISpeechToTextClient`
- **Namespace conflict:** No — uses `using Microsoft.Extensions.AI;` directly
- **Sub-client delegation:** `DeepgramClient.Listen.TranscribeAsync()`
- **URL-only:** Audio URL provided via `RawRepresentationFactory` with `ListenV1RequestUrl`; throws `NotSupportedException` if no URL given
- **Features:** Pre-recorded transcription, timestamps, language/model selection

## Known Issues

- **Bool query params:** Generated code serializes `bool` as `True`/`False` (C# default) in query strings, but Deepgram expects `true`/`false`. Avoid passing bool params like `punctuate`/`smartFormat` until AutoSDK fixes this.

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/deepgram/deepgram-api-specs/main/openapi.yml` (3.1.0)
- Note: Official .NET SDK exists (`Deepgram` on NuGet) but lacks MEAI integration

## NuGet

- **PackageId:** `tryAGI.Deepgram` (bare name taken by official SDK)
