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

        V1ListenPostParametersModel? model = default;
        if (modelId is { Length: > 0 })
        {
            model = new V1ListenPostParametersModel(modelId);
        }

        var result = await SubpackageListenSubpackageListenV1SubpackageListenV1Media.TranscribeAsync(
            request: request,
            language: language,
            model: model,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var response = result.ListenV1Response
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

        // Create and configure the WebSocket client with typed query parameters.
        var realtimeClient = new Realtime.DeepgramListenV1RealtimeClient();
        await using (realtimeClient.ConfigureAwait(false))
        {
            realtimeClient.AuthorizeUsingToken(apiKey);
            await realtimeClient.ConnectAsync(
                interimResults: Realtime.ListenV1InterimResults.True,
                model: options?.ModelId is { Length: > 0 } modelId
                    ? Realtime.ListenV1ModelExtensions.ToEnum(modelId)
                    : null,
                language: options?.SpeechLanguage is { Length: > 0 } lang
                    ? Realtime.ListenV1Language.FromString(lang)
                    : null,
                cancellationToken: cancellationToken).ConfigureAwait(false);

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

                // Signal end of audio using the control message (Finalize/CloseStream/KeepAlive).
                await realtimeClient.SendListenV1CloseStreamAsync(
                    new Realtime.ListenV1ControlMessage
                    {
                        Type = Realtime.ListenV1ControlMessageType.CloseStream,
                    },
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

                    string transcript = results.Channel?.Alternatives is { Count: > 0 } alts
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
}
