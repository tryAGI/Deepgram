#nullable enable

using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;

namespace Deepgram;

public partial class DeepgramClient : ISpeechToTextClient
{
    private SpeechToTextClientMetadata? _speechMetadata;

    /// <summary>
    /// Deepgram Nova-3 model ID for high-accuracy general speech-to-text.
    /// </summary>
    public const string Nova3ModelId = "nova-3";

    /// <summary>
    /// Deepgram Flux English model ID for low-latency conversational speech-to-text.
    /// </summary>
    public const string FluxGeneralEnglishModelId = "flux-general-en";

    /// <summary>
    /// Deepgram Flux multilingual model ID for low-latency conversational speech-to-text.
    /// </summary>
    public const string FluxGeneralMultilingualModelId = "flux-general-multi";

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

        if (TryGetListenV2StreamingModel(options?.ModelId, out var listenV2Model))
        {
            await foreach (var update in GetStreamingTextV2Async(
                audioSpeechStream,
                options,
                apiKey,
                listenV2Model,
                cancellationToken).ConfigureAwait(false))
            {
                yield return update;
            }

            yield break;
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

    private static bool TryGetListenV2StreamingModel(
        string? modelId,
        out Realtime.ListenV2Model model)
    {
        if (modelId is { Length: > 0 } &&
            Realtime.ListenV2ModelExtensions.ToEnum(modelId) is { } parsedModel)
        {
            model = parsedModel;
            return true;
        }

        model = default;
        return false;
    }

    private static Realtime.ListenV2LanguageHint? CreateListenV2LanguageHint(
        string? speechLanguage,
        Realtime.ListenV2Model model)
    {
        if (model != Realtime.ListenV2Model.FluxGeneralMulti ||
            speechLanguage is not { Length: > 0 })
        {
            return null;
        }

        return new Realtime.ListenV2LanguageHint(speechLanguage);
    }

    private static async IAsyncEnumerable<SpeechToTextResponseUpdate> GetStreamingTextV2Async(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        string apiKey,
        Realtime.ListenV2Model model,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var realtimeClient = new Realtime.DeepgramListenV2RealtimeClient();
        await using (realtimeClient.ConfigureAwait(false))
        {
            realtimeClient.AuthorizeUsingToken(apiKey);
            await realtimeClient.ConnectAsync(
                model: model,
                languageHint: CreateListenV2LanguageHint(options?.SpeechLanguage, model),
                cancellationToken: cancellationToken).ConfigureAwait(false);

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

                await realtimeClient.SendListenV2CloseStreamAsync(
                    new Realtime.ListenV2ListenV2CloseStream
                    {
                        Type = Realtime.ChannelsListenV2MessagesListenV2CloseStreamType.CloseStream,
                    },
                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken);

            string? responseId = null;
            await foreach (var serverEvent in realtimeClient.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
            {
                if (serverEvent.ListenV2Connected is { } connected)
                {
                    responseId = connected.RequestId.ToString();
                    yield return new SpeechToTextResponseUpdate
                    {
                        Kind = SpeechToTextResponseUpdateKind.SessionOpen,
                        ResponseId = responseId,
                        RawRepresentation = connected,
                    };
                }
                else if (serverEvent.ListenV2TurnInfo is { } turnInfo)
                {
                    responseId ??= turnInfo.RequestId.ToString();

                    var kind = turnInfo.Event == Realtime.ChannelsListenV2MessagesListenV2TurnInfoEvent.EndOfTurn
                        ? SpeechToTextResponseUpdateKind.TextUpdated
                        : SpeechToTextResponseUpdateKind.TextUpdating;

                    yield return new SpeechToTextResponseUpdate(turnInfo.Transcript)
                    {
                        Kind = kind,
                        ResponseId = responseId,
                        StartTime = TimeSpan.FromSeconds(turnInfo.AudioWindowStart),
                        EndTime = TimeSpan.FromSeconds(turnInfo.AudioWindowEnd),
                        RawRepresentation = turnInfo,
                    };
                }
                else if (serverEvent.ListenV2ConfigureFailure is { } configureFailure)
                {
                    throw new InvalidOperationException(
                        $"Deepgram Listen v2 configure failed for request {configureFailure.RequestId}.");
                }
                else if (serverEvent.ListenV2FatalError is { } fatalError)
                {
                    throw new InvalidOperationException(
                        $"Deepgram Listen v2 fatal error: {fatalError.Code}: {fatalError.Description}");
                }
            }

            yield return new SpeechToTextResponseUpdate
            {
                Kind = SpeechToTextResponseUpdateKind.SessionClose,
                ResponseId = responseId,
            };

            await sendTask.ConfigureAwait(false);
        }
    }
}
