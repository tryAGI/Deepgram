# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Deepgram SDK implements `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), enabling you to use Deepgram transcription through a standardized .NET AI abstraction.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `ISpeechToTextClient` | Full (URL-based pre-recorded transcription, language/model selection) |

## ISpeechToTextClient

### Installation

```bash
dotnet add package tryAGI.Deepgram
```

### URL-Based Transcription

Deepgram's pre-recorded API works with audio URLs. Use `RawRepresentationFactory` to provide the audio URL:

```csharp
using Deepgram;
using Microsoft.Extensions.AI;

using var client = new DeepgramClient(apiKey);
ISpeechToTextClient sttClient = client;

using var dummyStream = new MemoryStream(); // Stream is not used for URL-based transcription
var response = await sttClient.GetTextAsync(dummyStream, new SpeechToTextOptions
{
    ModelId = "nova-3",
    RawRepresentationFactory = _ => new ListenV1RequestUrl
    {
        Url = "https://dpgr.am/spacewalk.wav",
    },
});

Console.WriteLine(response.Text);
Console.WriteLine($"Duration: {response.EndTime}");
```

### Transcription with Language Hint

Specify a language code for more accurate transcription:

```csharp
ISpeechToTextClient sttClient = client;

using var dummyStream = new MemoryStream();
var response = await sttClient.GetTextAsync(dummyStream, new SpeechToTextOptions
{
    SpeechLanguage = "es",
    ModelId = "nova-3",
    RawRepresentationFactory = _ => new ListenV1RequestUrl
    {
        Url = "https://example.com/spanish-audio.wav",
    },
});

Console.WriteLine(response.Text);
```

### Accessing the Raw Response

The full Deepgram response is available via `RawRepresentation`:

```csharp
var response = await sttClient.GetTextAsync(dummyStream, new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new ListenV1RequestUrl
    {
        Url = "https://dpgr.am/spacewalk.wav",
    },
});

var raw = (ListenV1Response)response.RawRepresentation!;
Console.WriteLine($"Request ID: {raw.Metadata.RequestId}");
Console.WriteLine($"Duration: {raw.Metadata.Duration}s");
Console.WriteLine($"Channels: {raw.Metadata.Channels}");
```

### Streaming Behavior

Unlike most other STT SDKs, Deepgram provides **true real-time streaming** via `GetStreamingTextAsync`. It uses the `DeepgramListenV1RealtimeClient` WebSocket API to send audio frames and receive incremental transcription updates in real-time.

- **`TextUpdating`** updates contain interim (non-final) transcriptions that may change as more audio is processed
- **`TextUpdated`** updates contain final transcriptions for completed speech segments
- **`SessionOpen`** and **`SessionClose`** events bracket the streaming session

This provides genuine incremental results, unlike other providers that delegate streaming to their batch APIs.

### Accessing the Underlying Client

Retrieve the `DeepgramClient` from the MEAI interface:

```csharp
ISpeechToTextClient sttClient = client;

var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "deepgram"

var deepgramClient = sttClient.GetService<DeepgramClient>();
// Use deepgramClient for Deepgram-specific APIs (TTS, text analysis, etc.)
```
