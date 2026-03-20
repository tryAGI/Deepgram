#nullable enable

using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;

namespace Deepgram;

public partial class DeepgramClient : ISpeechToTextClient
{
    private SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_speechMetadata ??= new("deepgram", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        var request = options?.RawRepresentationFactory?.Invoke(this) as ListenV1RequestUrl;

        // Deepgram's pre-recorded API accepts a URL to audio.
        // If no URL is provided via RawRepresentationFactory, we cannot proceed
        // since the generated client uses URL-based transcription.
        if (request is null || string.IsNullOrEmpty(request.Url))
        {
            throw new NotSupportedException(
                "Deepgram ISpeechToTextClient requires an audio URL. " +
                "Use SpeechToTextOptions.RawRepresentationFactory to provide a ListenV1RequestUrl with the audio URL set.");
        }

        string? language = options?.SpeechLanguage;
        string? modelId = options?.ModelId;

        var result = await Listen.TranscribeAsync(
            request: request,
            language: language,
            model: modelId is not null
                ? new OneOf<ListenV1MediaTranscribeModel2?, string>(modelId)
                : default,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var response = result.Value1
            ?? throw new InvalidOperationException("Deepgram returned an accepted (async) response instead of a transcription result.");

        string text = response.Results.Channels is { Count: > 0 } channels
            && channels[0].Alternatives is { Count: > 0 } alternatives
                ? alternatives[0].Transcript ?? string.Empty
                : string.Empty;

        TimeSpan? endTime = response.Metadata.Duration > 0
            ? TimeSpan.FromSeconds(response.Metadata.Duration)
            : null;

        return new SpeechToTextResponse(text)
        {
            RawRepresentation = response,
            ResponseId = response.Metadata.RequestId.ToString(),
            StartTime = TimeSpan.Zero,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((ISpeechToTextClient)this)
            .GetTextAsync(audioSpeechStream, options, cancellationToken)
            .ConfigureAwait(false);

        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }
}
