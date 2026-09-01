#nullable enable

using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Deepgram.Realtime;

/// <summary>
/// Selects the Deepgram realtime Listen protocol used by a transcription session.
/// </summary>
public enum DeepgramRealtimeListenVersion
{
    /// <summary>Use Listen V2 for Flux models and Listen V1 for other models.</summary>
    Auto,

    /// <summary>Use the classic Listen V1 protocol.</summary>
    ListenV1,

    /// <summary>Use the conversational Listen V2 protocol.</summary>
    ListenV2,
}

/// <summary>
/// Provider-level options shared by Deepgram Listen V1 and Listen V2 realtime transcription.
/// </summary>
public sealed class DeepgramRealtimeTranscriptionOptions
{
    /// <summary>Protocol selection policy.</summary>
    public DeepgramRealtimeListenVersion ListenVersion { get; set; } = DeepgramRealtimeListenVersion.Auto;
    /// <summary>Deepgram model identifier.</summary>
    public string ModelId { get; set; } = global::Deepgram.DeepgramClient.FluxGeneralMultilingualModelId;
    /// <summary>Wire audio encoding.</summary>
    public string Encoding { get; set; } = "linear16";
    /// <summary>Wire audio sample rate.</summary>
    public int SampleRate { get; set; } = 16_000;
    /// <summary>Wire audio channel count.</summary>
    public int Channels { get; set; } = 1;
    /// <summary>Listen V1 language or open-ended <c>auto</c>/<c>multi</c>.</summary>
    public string? Language { get; set; }
    /// <summary>Listen V2 language hints and Listen V1 fallback preferences.</summary>
    public IReadOnlyList<string> LanguageHints { get; set; } = [];
    /// <summary>Repeated provider keyterms used to bias recognition.</summary>
    public IReadOnlyList<string> Keyterms { get; set; } = [];
    /// <summary>Listen V2 preliminary end-of-turn threshold.</summary>
    public double? EagerEotThreshold { get; set; }
    /// <summary>Listen V2 forced end-of-turn timeout.</summary>
    public int? EotTimeoutMilliseconds { get; set; }
    /// <summary>Listen V1 endpointing silence duration.</summary>
    public int EndpointingMilliseconds { get; set; } = 300;
    /// <summary>Listen V1 utterance-end silence duration.</summary>
    public int UtteranceEndMilliseconds { get; set; } = 1_000;
    /// <summary>Whether Listen V1 emits interim results.</summary>
    public bool InterimResults { get; set; } = true;
    /// <summary>Whether Listen V1 applies punctuation.</summary>
    public bool Punctuate { get; set; } = true;
    /// <summary>Whether Listen V1 applies smart formatting.</summary>
    public bool SmartFormat { get; set; } = true;
    /// <summary>Whether Listen V1 emits voice-activity events.</summary>
    public bool VadEvents { get; set; } = true;
    /// <summary>Client WebSocket keep-alive interval.</summary>
    public TimeSpan KeepAliveInterval { get; set; } = TimeSpan.FromSeconds(15);
    /// <summary>Maximum provider connection establishment time.</summary>
    public TimeSpan ConnectTimeout { get; set; } = TimeSpan.FromSeconds(15);
}

/// <summary>
/// One normalized transcript update emitted by either Deepgram realtime Listen protocol.
/// </summary>
public sealed record DeepgramRealtimeTranscriptUpdate(
    string? Text,
    bool IsFinal,
    string? ProviderSegmentId,
    string? Error,
    string EventType);

/// <summary>
/// One provider frame plus the SDK's mapping or assembly decision.
/// </summary>
public sealed record DeepgramRealtimeRawFrame(
    string FrameKind,
    string? RawJson,
    string MappedOutcome,
    string? MappedEventType,
    bool? MappedIsFinal,
    string? MappedText,
    string? ProviderSegmentId,
    int PendingChunksBefore,
    int PendingChunksAfter,
    DateTimeOffset TimestampUtc);

/// <summary>Event arguments carrying one provider frame and its SDK mapping decision.</summary>
public sealed class DeepgramRealtimeRawFrameEventArgs(DeepgramRealtimeRawFrame frame) : EventArgs
{
    /// <summary>The captured provider frame.</summary>
    public DeepgramRealtimeRawFrame Frame { get; } = frame;
}

/// <summary>
/// A connected, protocol-neutral Deepgram realtime transcription session.
/// </summary>
public interface IDeepgramRealtimeTranscriptionSession : IAsyncDisposable
{
    /// <summary>Whether the provider WebSocket is connected.</summary>
    bool IsConnected { get; }
    /// <summary>Raised for each provider frame before or during normalized mapping.</summary>
    event EventHandler<DeepgramRealtimeRawFrameEventArgs>? RawFrameReceived;
    /// <summary>Sends one binary audio frame.</summary>
    Task SendAudioAsync(ArraySegment<byte> audioBytes, CancellationToken cancellationToken = default);
    /// <summary>Sends the provider protocol's graceful close-stream message.</summary>
    Task CloseStreamAsync(CancellationToken cancellationToken = default);
    /// <summary>Receives normalized transcript updates until the provider stream ends.</summary>
    IAsyncEnumerable<DeepgramRealtimeTranscriptUpdate> ReceiveEventsAsync(
        CancellationToken cancellationToken = default);
}

/// <summary>
/// Creates protocol-neutral Deepgram streaming sessions and builds their provider request URIs.
/// </summary>
public static class DeepgramRealtimeTranscription
{
    /// <summary>Connects a protocol-neutral realtime transcription session.</summary>
    public static async Task<IDeepgramRealtimeTranscriptionSession> ConnectAsync(
        string apiKey,
        DeepgramRealtimeTranscriptionOptions options,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        ArgumentNullException.ThrowIfNull(options);

        return ResolveListenVersion(options) == DeepgramRealtimeListenVersion.ListenV2
            ? await DeepgramListenV2TranscriptionSession.ConnectAsync(apiKey, options, cancellationToken)
                .ConfigureAwait(false)
            : await DeepgramListenV1TranscriptionSession.ConnectAsync(apiKey, options, cancellationToken)
                .ConfigureAwait(false);
    }

    /// <summary>Resolves explicit or model-inferred Listen protocol selection.</summary>
    public static DeepgramRealtimeListenVersion ResolveListenVersion(
        DeepgramRealtimeTranscriptionOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        if (options.ListenVersion != DeepgramRealtimeListenVersion.Auto)
        {
            return options.ListenVersion;
        }

        return options.ModelId.StartsWith("flux", StringComparison.OrdinalIgnoreCase)
            ? DeepgramRealtimeListenVersion.ListenV2
            : DeepgramRealtimeListenVersion.ListenV1;
    }

    /// <summary>Builds the provider WebSocket URI for the resolved protocol.</summary>
    public static Uri BuildUri(DeepgramRealtimeTranscriptionOptions options) =>
        ResolveListenVersion(options) == DeepgramRealtimeListenVersion.ListenV2
            ? BuildListenV2Uri(options)
            : BuildListenV1Uri(options);

    /// <summary>Builds a Listen V2 WebSocket URI.</summary>
    public static Uri BuildListenV2Uri(DeepgramRealtimeTranscriptionOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("model", string.IsNullOrWhiteSpace(options.ModelId)
                ? global::Deepgram.DeepgramClient.FluxGeneralMultilingualModelId
                : options.ModelId.Trim()),
            new("encoding", NormalizeRequired(options.Encoding, "linear16")),
            new("sample_rate", Math.Max(options.SampleRate, 1).ToString(CultureInfo.InvariantCulture)),
        };

        AddRepeated(parameters, "language_hint", options.LanguageHints);
        if (options.EagerEotThreshold is { } eagerEot)
        {
            parameters.Add(new("eager_eot_threshold", eagerEot.ToString("0.##", CultureInfo.InvariantCulture)));
        }
        if (options.EotTimeoutMilliseconds is { } eotTimeout)
        {
            parameters.Add(new(
                "eot_timeout_ms",
                Math.Clamp(eotTimeout, 500, 60_000).ToString(CultureInfo.InvariantCulture)));
        }
        AddRepeated(parameters, "keyterm", options.Keyterms);

        return BuildUri(DeepgramListenV2RealtimeClient.DefaultBaseUrl, parameters);
    }

    /// <summary>Builds a Listen V1 WebSocket URI.</summary>
    public static Uri BuildListenV1Uri(DeepgramRealtimeTranscriptionOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("model", string.IsNullOrWhiteSpace(options.ModelId)
                ? global::Deepgram.DeepgramClient.Nova3ModelId
                : options.ModelId.Trim()),
            new("encoding", NormalizeRequired(options.Encoding, "linear16")),
            new("sample_rate", Math.Max(options.SampleRate, 1).ToString(CultureInfo.InvariantCulture)),
            new("channels", Math.Max(options.Channels, 1).ToString(CultureInfo.InvariantCulture)),
            new("language", ResolveListenV1Language(options)),
            new("interim_results", Bool(options.InterimResults)),
            new("punctuate", Bool(options.Punctuate)),
            new("smart_format", Bool(options.SmartFormat)),
            new("endpointing", Math.Max(options.EndpointingMilliseconds, 0).ToString(CultureInfo.InvariantCulture)),
            new("utterance_end_ms", Math.Max(options.UtteranceEndMilliseconds, 0).ToString(CultureInfo.InvariantCulture)),
            new("vad_events", Bool(options.VadEvents)),
        };
        AddRepeated(parameters, "keyterm", options.Keyterms);
        return BuildUri(DeepgramListenV1RealtimeClient.DefaultBaseUrl, parameters);
    }

    /// <summary>Resolves a single Listen V1 language from explicit and hinted values.</summary>
    public static string ResolveListenV1Language(DeepgramRealtimeTranscriptionOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        var configured = options.Language?.Trim();
        var isOpenEnded = string.IsNullOrWhiteSpace(configured)
            || string.Equals(configured, "auto", StringComparison.OrdinalIgnoreCase)
            || string.Equals(configured, "multi", StringComparison.OrdinalIgnoreCase);
        if (!isOpenEnded)
        {
            return configured!;
        }

        return options.LanguageHints.FirstOrDefault(static hint => !string.IsNullOrWhiteSpace(hint))?.Trim()
            ?? "multi";
    }

    /// <summary>Maps one Listen V2 server event to the protocol-neutral transcript shape.</summary>
    public static DeepgramRealtimeTranscriptUpdate? MapListenV2ServerEvent(ListenV2ServerEvent serverEvent)
    {
        if (serverEvent.TryPickListenV2ListenV2TurnInfo(out var turnInfo) && turnInfo is not null)
        {
            return new(
                turnInfo.Transcript?.Trim(),
                turnInfo.Event == ChannelsListenV2MessagesListenV2TurnInfoEvent.EndOfTurn,
                $"turn:{turnInfo.RequestId}:{turnInfo.TurnIndex}:{turnInfo.SequenceId}",
                null,
                turnInfo.Event.ToString());
        }
        if (serverEvent.TryPickListenV2ListenV2FatalError(out var fatalError) && fatalError is not null)
        {
            return new(null, false, $"fatal:{fatalError.SequenceId}",
                $"{fatalError.Code}: {fatalError.Description}", "FatalError");
        }
        if (serverEvent.TryPickListenV2ListenV2ConfigureFailure(out var failure) && failure is not null)
        {
            return new(null, false, $"configure:{failure.RequestId}:{failure.SequenceId}",
                "Deepgram realtime configuration failed.", "ConfigureFailure");
        }
        return null;
    }

    private static Uri BuildUri(string baseUrl, IEnumerable<KeyValuePair<string, string>> parameters)
    {
        var query = string.Join(
            "&",
            parameters.Select(static pair =>
                $"{Uri.EscapeDataString(pair.Key)}={Uri.EscapeDataString(pair.Value)}"));
        return new Uri($"{baseUrl}?{query}");
    }

    private static void AddRepeated(
        List<KeyValuePair<string, string>> parameters,
        string name,
        IEnumerable<string>? values)
    {
        foreach (var value in values ?? [])
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                parameters.Add(new(name, value.Trim()));
            }
        }
    }

    private static string NormalizeRequired(string? value, string fallback) =>
        string.IsNullOrWhiteSpace(value) ? fallback : value.Trim();

    private static string Bool(bool value) => value ? "true" : "false";
}

/// <summary>
/// Assembles Listen V1 provider-finalized chunks into canonical utterances.
/// </summary>
public sealed class DeepgramListenV1TranscriptAssembler
{
    private readonly List<string> _finalizedChunks = [];
    private string? _providerSegmentId;

    /// <summary>Number of provider-finalized chunks awaiting an utterance boundary.</summary>
    public int PendingChunkCount => _finalizedChunks.Count;

    /// <summary>Maps and assembles one Listen V1 server event.</summary>
    public DeepgramRealtimeTranscriptUpdate? MapServerEvent(ListenV1ServerEvent serverEvent)
    {
        if (serverEvent.TryPickListenV1ListenV1Results(out var result) && result != null)
        {
            return MapResult(result);
        }

        return serverEvent.TryPickListenV1ListenV1UtteranceEnd(out _)
            && _finalizedChunks.Count > 0
                ? CompleteUtterance("UtteranceEnd")
                : null;
    }

    /// <summary>Commits buffered provider-finalized text when a stream ends without a boundary.</summary>
    public DeepgramRealtimeTranscriptUpdate? FlushPending(string eventType = "StreamEndFlush") =>
        _finalizedChunks.Count == 0 ? null : CompleteUtterance(eventType);

    private DeepgramRealtimeTranscriptUpdate? MapResult(ListenV1ListenV1Results result)
    {
        var text = result.Channel?.Alternatives?.FirstOrDefault()?.Transcript?.Trim();
        if (!string.IsNullOrWhiteSpace(text) && _providerSegmentId is null)
        {
            var requestId = result.Metadata?.RequestId ?? "unknown";
            _providerSegmentId = $"utterance:{requestId}:{result.Start.ToString("0.###", CultureInfo.InvariantCulture)}";
        }

        if (result.IsFinal == true)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                _finalizedChunks.Add(text);
            }

            if (result.SpeechFinal == true)
            {
                return CompleteUtterance("ResultsSpeechFinal");
            }

            var finalizedText = JoinChunks(_finalizedChunks);
            return string.IsNullOrWhiteSpace(finalizedText)
                ? null
                : new(finalizedText, false, _providerSegmentId, null, "ResultsFinal");
        }

        var partialText = JoinChunks(_finalizedChunks.Append(text));
        return string.IsNullOrWhiteSpace(partialText)
            ? null
            : new(partialText, false, _providerSegmentId, null, "ResultsInterim");
    }

    private DeepgramRealtimeTranscriptUpdate? CompleteUtterance(string eventType)
    {
        var text = JoinChunks(_finalizedChunks);
        var providerSegmentId = _providerSegmentId;
        _finalizedChunks.Clear();
        _providerSegmentId = null;
        return string.IsNullOrWhiteSpace(text)
            ? null
            : new(text, true, providerSegmentId, null, eventType);
    }

    private static string JoinChunks(IEnumerable<string?> chunks) =>
        string.Join(' ', chunks.Where(static chunk => !string.IsNullOrWhiteSpace(chunk)));
}

internal sealed class DeepgramListenV1TranscriptionSession(
    DeepgramListenV1RealtimeClient client) : IDeepgramRealtimeTranscriptionSession
{
    private readonly DeepgramListenV1TranscriptAssembler _assembler = new();

    public bool IsConnected => client.IsConnected;
    public event EventHandler<DeepgramRealtimeRawFrameEventArgs>? RawFrameReceived;

    internal static async Task<DeepgramListenV1TranscriptionSession> ConnectAsync(
        string apiKey,
        DeepgramRealtimeTranscriptionOptions options,
        CancellationToken cancellationToken)
    {
#pragma warning disable CA2000 // Ownership transfers to the returned session; failures dispose below.
        var client = new DeepgramListenV1RealtimeClient();
#pragma warning restore CA2000
        try
        {
            client.AuthorizeUsingToken(apiKey);
            await client.ConnectAsync(
                uri: DeepgramRealtimeTranscription.BuildListenV1Uri(options),
                keepAliveInterval: options.KeepAliveInterval,
                connectTimeout: options.ConnectTimeout,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            return new(client);
        }
        catch
        {
            await client.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    public Task SendAudioAsync(ArraySegment<byte> audioBytes, CancellationToken cancellationToken = default) =>
        client.SendAsync(audioBytes, WebSocketMessageType.Binary, endOfMessage: true, cancellationToken);

    public Task CloseStreamAsync(CancellationToken cancellationToken = default) =>
        client.SendListenV1CloseStreamAsync(
            new ListenV1ListenV1CloseStream(ChannelsListenV1MessagesListenV1CloseStreamType.CloseStream),
            cancellationToken);

    public async IAsyncEnumerable<DeepgramRealtimeTranscriptUpdate> ReceiveEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
        {
            var pendingBefore = _assembler.PendingChunkCount;
            var mapped = _assembler.MapServerEvent(serverEvent);
            RaiseRawFrame(serverEvent, mapped, pendingBefore);
            if (mapped is not null)
            {
                yield return mapped;
            }
        }

        var flushed = _assembler.FlushPending();
        if (flushed is not null)
        {
            RaiseRawFrame(null, flushed, 0, "StreamEndFlush");
            yield return flushed;
        }
    }

    private void RaiseRawFrame(
        ListenV1ServerEvent? serverEvent,
        DeepgramRealtimeTranscriptUpdate? mapped,
        int pendingBefore,
        string? syntheticKind = null)
    {
        var handler = RawFrameReceived;
        if (handler is null)
        {
            return;
        }

        handler(this, new(new(
            syntheticKind ?? ResolveFrameKind(serverEvent),
            SerializeRawPayload(serverEvent),
            mapped is null ? "suppressed" : mapped.IsFinal ? "emitted-final" : "emitted-partial",
            mapped?.EventType,
            mapped?.IsFinal,
            mapped?.Text,
            mapped?.ProviderSegmentId,
            pendingBefore,
            _assembler.PendingChunkCount,
            DateTimeOffset.UtcNow)));
    }

    private static string ResolveFrameKind(ListenV1ServerEvent? serverEvent)
    {
        if (serverEvent is not { } frame)
        {
            return "Synthetic";
        }
        if (frame.TryPickListenV1ListenV1Results(out _))
        {
            return "Results";
        }
        return frame.TryPickListenV1ListenV1UtteranceEnd(out _) ? "UtteranceEnd" : "Other";
    }

    private static string? SerializeRawPayload(ListenV1ServerEvent? serverEvent)
    {
        try
        {
            if (serverEvent is not { } frame)
            {
                return null;
            }
            if (frame.TryPickListenV1ListenV1Results(out var results) && results is not null)
            {
                return JsonSerializer.Serialize(results);
            }
            if (frame.TryPickListenV1ListenV1UtteranceEnd(out var utteranceEnd) && utteranceEnd is not null)
            {
                return JsonSerializer.Serialize(utteranceEnd);
            }
            return JsonSerializer.Serialize(frame);
        }
        catch (JsonException)
        {
            return null;
        }
        catch (NotSupportedException)
        {
            return null;
        }
    }

    public ValueTask DisposeAsync() => client.DisposeAsync();
}

internal sealed class DeepgramListenV2TranscriptionSession(
    DeepgramListenV2RealtimeClient client) : IDeepgramRealtimeTranscriptionSession
{
    public bool IsConnected => client.IsConnected;
    public event EventHandler<DeepgramRealtimeRawFrameEventArgs>? RawFrameReceived;

    internal static async Task<DeepgramListenV2TranscriptionSession> ConnectAsync(
        string apiKey,
        DeepgramRealtimeTranscriptionOptions options,
        CancellationToken cancellationToken)
    {
#pragma warning disable CA2000 // Ownership transfers to the returned session; failures dispose below.
        var client = new DeepgramListenV2RealtimeClient();
#pragma warning restore CA2000
        try
        {
            client.AuthorizeUsingToken(apiKey);
            await client.ConnectAsync(
                uri: DeepgramRealtimeTranscription.BuildListenV2Uri(options),
                keepAliveInterval: options.KeepAliveInterval,
                connectTimeout: options.ConnectTimeout,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            return new(client);
        }
        catch
        {
            await client.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    public Task SendAudioAsync(ArraySegment<byte> audioBytes, CancellationToken cancellationToken = default) =>
        client.SendAsync(audioBytes, WebSocketMessageType.Binary, endOfMessage: true, cancellationToken);

    public Task CloseStreamAsync(CancellationToken cancellationToken = default) =>
        client.SendListenV2CloseStreamAsync(
            new ListenV2ListenV2CloseStream(ChannelsListenV2MessagesListenV2CloseStreamType.CloseStream),
            cancellationToken);

    public async IAsyncEnumerable<DeepgramRealtimeTranscriptUpdate> ReceiveEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
        {
            var mapped = DeepgramRealtimeTranscription.MapListenV2ServerEvent(serverEvent);
            RaiseRawFrame(serverEvent, mapped);
            if (mapped is not null)
            {
                yield return mapped;
            }
        }
    }

    private void RaiseRawFrame(
        ListenV2ServerEvent serverEvent,
        DeepgramRealtimeTranscriptUpdate? mapped)
    {
        var handler = RawFrameReceived;
        if (handler is null)
        {
            return;
        }

        handler(this, new(new(
            mapped?.EventType ?? "Other",
            TrySerialize(serverEvent),
            mapped is null ? "suppressed" : mapped.IsFinal ? "emitted-final" : "emitted-partial",
            mapped?.EventType,
            mapped?.IsFinal,
            mapped?.Text,
            mapped?.ProviderSegmentId,
            0,
            0,
            DateTimeOffset.UtcNow)));
    }

    private static string? TrySerialize(ListenV2ServerEvent serverEvent)
    {
        try
        {
            if (serverEvent.TryPickListenV2ListenV2TurnInfo(out var turnInfo) && turnInfo is not null)
            {
                return JsonSerializer.Serialize(turnInfo);
            }
            if (serverEvent.TryPickListenV2ListenV2FatalError(out var fatalError) && fatalError is not null)
            {
                return JsonSerializer.Serialize(fatalError);
            }
            if (serverEvent.TryPickListenV2ListenV2ConfigureFailure(out var failure) && failure is not null)
            {
                return JsonSerializer.Serialize(failure);
            }
            return JsonSerializer.Serialize(serverEvent);
        }
        catch (JsonException)
        {
            return null;
        }
        catch (NotSupportedException)
        {
            return null;
        }
    }

    public ValueTask DisposeAsync() => client.DisposeAsync();
}
