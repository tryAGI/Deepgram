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
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        // Get the API key from the REST client's authorization list.
        string? apiKey = null;
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Value: { Length: > 0 } })
            {
                apiKey = auth.Value;
                break;
            }
        }

        if (apiKey is null)
        {
            throw new InvalidOperationException(
                "No API key found in DeepgramClient.Authorizations. " +
                "Ensure the client was created with an API key.");
        }

        // Build the WebSocket URI with query parameters.
        var uriBuilder = new UriBuilder(Realtime.DeepgramRealtimeClient.DefaultBaseUrl);
        var queryParams = new List<string> { "interim_results=true" };

        if (options?.ModelId is { Length: > 0 } modelId)
        {
            queryParams.Add($"model={Uri.EscapeDataString(modelId)}");
        }

        if (options?.SpeechLanguage is { Length: > 0 } language)
        {
            queryParams.Add($"language={Uri.EscapeDataString(language)}");
        }

        if (queryParams.Count > 0)
        {
            uriBuilder.Query = string.Join("&", queryParams);
        }

        // Create and configure the WebSocket client.
        await using var realtimeClient = new Realtime.DeepgramRealtimeClient();
        realtimeClient.AuthorizeUsingToken(apiKey);
        await realtimeClient.ConnectAsync(uriBuilder.Uri, cancellationToken).ConfigureAwait(false);

        // Start sending audio in a background task.
        var sendTask = Task.Run(async () =>
        {
            var buffer = new byte[8192];
            int bytesRead;
            while ((bytesRead = await audioSpeechStream.ReadAsync(
                buffer.AsMemory(0, buffer.Length), cancellationToken).ConfigureAwait(false)) > 0)
            {
                await realtimeClient.SendAsync(
                    new ArraySegment<byte>(buffer, 0, bytesRead),
                    System.Net.WebSockets.WebSocketMessageType.Binary,
                    endOfMessage: true,
                    cancellationToken).ConfigureAwait(false);
            }

            // Signal end of audio.
            await realtimeClient.SendCloseStreamAsync(
                new Realtime.CloseStreamPayload(),
                cancellationToken).ConfigureAwait(false);
        }, cancellationToken);

        // Receive transcription events and yield MEAI updates.
        string? responseId = null;
        await foreach (var serverEvent in realtimeClient.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
        {
            if (serverEvent.IsMetadata && serverEvent.Metadata is { } metadata)
            {
                responseId = metadata.RequestId.ToString();
                yield return new SpeechToTextResponseUpdate
                {
                    Kind = SpeechToTextResponseUpdateKind.SessionOpen,
                    ResponseId = responseId,
                    RawRepresentation = metadata,
                };
            }
            else if (serverEvent.IsResults && serverEvent.Results is { } results)
            {
                responseId ??= results.Metadata.RequestId;

                string transcript = results.Channel.Alternatives is { Count: > 0 } alts
                    ? alts[0].Transcript ?? string.Empty
                    : string.Empty;

                var kind = results.IsFinal == true
                    ? SpeechToTextResponseUpdateKind.TextUpdated
                    : SpeechToTextResponseUpdateKind.TextUpdating;

                yield return new SpeechToTextResponseUpdate(transcript)
                {
                    Kind = kind,
                    ResponseId = responseId,
                    StartTime = TimeSpan.FromSeconds(results.Start),
                    EndTime = TimeSpan.FromSeconds(results.Start + results.Duration),
                    RawRepresentation = results,
                };
            }
        }

        yield return new SpeechToTextResponseUpdate
        {
            Kind = SpeechToTextResponseUpdateKind.SessionClose,
            ResponseId = responseId,
        };

        // Ensure the send task completed without errors.
        await sendTask.ConfigureAwait(false);
    }
}
