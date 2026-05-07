#nullable enable
#pragma warning disable CS1591

namespace Deepgram.Realtime;

public readonly partial struct ListenV1ServerEvent
{
    public ListenV1ListenV1Results? ListenV1Results => ListenV1ListenV1Results;

    public ListenV1ListenV1Results? Results => ListenV1ListenV1Results;

    public bool IsResults => IsListenV1ListenV1Results;

    public ListenV1ListenV1Metadata? ListenV1Metadata => ListenV1ListenV1Metadata;

    public ListenV1ListenV1Metadata? Metadata => ListenV1ListenV1Metadata;

    public bool IsMetadata => IsListenV1ListenV1Metadata;

    public ListenV1ListenV1UtteranceEnd? ListenV1UtteranceEnd => ListenV1ListenV1UtteranceEnd;

    public ListenV1ListenV1UtteranceEnd? UtteranceEnd => ListenV1ListenV1UtteranceEnd;

    public bool IsUtteranceEnd => IsListenV1ListenV1UtteranceEnd;

    public ListenV1ListenV1SpeechStarted? ListenV1SpeechStarted => ListenV1ListenV1SpeechStarted;

    public ListenV1ListenV1SpeechStarted? SpeechStarted => ListenV1ListenV1SpeechStarted;

    public bool IsSpeechStarted => IsListenV1ListenV1SpeechStarted;
}

public readonly partial struct ListenV2ServerEvent
{
    public ListenV2ListenV2Connected? ListenV2Connected => ListenV2ListenV2Connected;

    public ListenV2ListenV2TurnInfo? ListenV2TurnInfo => ListenV2ListenV2TurnInfo;

    public ListenV2ListenV2ConfigureSuccess? ListenV2ConfigureSuccess => ListenV2ListenV2ConfigureSuccess;

    public ListenV2ListenV2ConfigureFailure? ListenV2ConfigureFailure => ListenV2ListenV2ConfigureFailure;

    public ListenV2ListenV2FatalError? ListenV2FatalError => ListenV2ListenV2FatalError;
}

public readonly partial struct SpeakV1ServerEvent
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1819:Properties should not return arrays",
        Justification = "Matches the generated websocket event dispatch property shape.")]
    public byte[]? SpeakV1Audio => SpeakV1SpeakV1Audio;

    public SpeakV1SpeakV1Metadata? SpeakV1Metadata => SpeakV1SpeakV1Metadata;

    public SpeakV1SpeakV1Flushed? SpeakV1Flushed => SpeakV1SpeakV1Flushed;

    public SpeakV1SpeakV1Cleared? SpeakV1Cleared => SpeakV1SpeakV1Cleared;

    public SpeakV1SpeakV1Warning? SpeakV1Warning => SpeakV1SpeakV1Warning;
}

public readonly partial struct AgentV1ServerEvent
{
    public AgentV1AgentV1ReceiveFunctionCallResponse? AgentV1ReceiveFunctionCallResponse => AgentV1AgentV1ReceiveFunctionCallResponse;

    public AgentV1AgentV1PromptUpdated? AgentV1PromptUpdated => AgentV1AgentV1PromptUpdated;

    public AgentV1AgentV1SpeakUpdated? AgentV1SpeakUpdated => AgentV1AgentV1SpeakUpdated;

    public AgentV1AgentV1ThinkUpdated? AgentV1ThinkUpdated => AgentV1AgentV1ThinkUpdated;

    public AgentV1AgentV1InjectionRefused? AgentV1InjectionRefused => AgentV1AgentV1InjectionRefused;

    public AgentV1AgentV1Welcome? AgentV1Welcome => AgentV1AgentV1Welcome;

    public AgentV1AgentV1SettingsApplied? AgentV1SettingsApplied => AgentV1AgentV1SettingsApplied;

    public AgentV1AgentV1ConversationText? AgentV1ConversationText => AgentV1AgentV1ConversationText;

    public AgentV1AgentV1UserStartedSpeaking? AgentV1UserStartedSpeaking => AgentV1AgentV1UserStartedSpeaking;

    public AgentV1AgentV1AgentThinking? AgentV1AgentThinking => AgentV1AgentV1AgentThinking;

    public AgentV1AgentV1FunctionCallRequest? AgentV1FunctionCallRequest => AgentV1AgentV1FunctionCallRequest;

    public AgentV1AgentV1AgentStartedSpeaking? AgentV1AgentStartedSpeaking => AgentV1AgentV1AgentStartedSpeaking;

    public AgentV1AgentV1AgentAudioDone? AgentV1AgentAudioDone => AgentV1AgentV1AgentAudioDone;

    public AgentV1AgentV1Error? AgentV1Error => AgentV1AgentV1Error;

    public AgentV1AgentV1Warning? AgentV1Warning => AgentV1AgentV1Warning;

    public AgentV1AgentV1History? AgentV1History => AgentV1AgentV1History;

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1819:Properties should not return arrays",
        Justification = "Matches the generated websocket event dispatch property shape.")]
    public byte[]? AgentV1Audio => AgentV1AgentV1Audio;
}

public enum ListenV1ControlMessageType
{
    CloseStream,
    Finalize,
    KeepAlive,
}

public static class ListenV1ControlMessageTypeExtensions
{
    public static string ToValueString(this ListenV1ControlMessageType value)
    {
        return value switch
        {
            ListenV1ControlMessageType.CloseStream => "CloseStream",
            ListenV1ControlMessageType.Finalize => "Finalize",
            ListenV1ControlMessageType.KeepAlive => "KeepAlive",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }

    public static ListenV1ControlMessageType? ToEnum(string value)
    {
        return value switch
        {
            "CloseStream" => ListenV1ControlMessageType.CloseStream,
            "Finalize" => ListenV1ControlMessageType.Finalize,
            "KeepAlive" => ListenV1ControlMessageType.KeepAlive,
            _ => null,
        };
    }
}

public sealed partial class ListenV1ControlMessage
{
    public required ListenV1ControlMessageType Type { get; set; }

    [System.Text.Json.Serialization.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties { get; } = new Dictionary<string, object>();

    public ListenV1ControlMessage()
    {
    }

    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public ListenV1ControlMessage(ListenV1ControlMessageType type)
    {
        Type = type;
    }
}

public sealed partial class DeepgramListenV1RealtimeClient
{
    public Task SendListenV1CloseStreamAsync(
        ListenV1ControlMessage message,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(message);

        return SendListenV1CloseStreamAsync(
            new ListenV1ListenV1CloseStream
            {
                Type = ToCloseStreamType(message.Type),
            },
            cancellationToken);
    }

    public Task SendListenV1FinalizeAsync(
        ListenV1ControlMessage message,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(message);

        return SendListenV1FinalizeAsync(
            new ListenV1ListenV1Finalize
            {
                Type = ToFinalizeType(message.Type),
            },
            cancellationToken);
    }

    public Task SendListenV1KeepAliveAsync(
        ListenV1ControlMessage message,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(message);

        return SendListenV1KeepAliveAsync(
            new ListenV1ListenV1KeepAlive
            {
                Type = ToKeepAliveType(message.Type),
            },
            cancellationToken);
    }

    private static ChannelsListenV1MessagesListenV1CloseStreamType ToCloseStreamType(ListenV1ControlMessageType type)
    {
        return type switch
        {
            ListenV1ControlMessageType.CloseStream => ChannelsListenV1MessagesListenV1CloseStreamType.CloseStream,
            ListenV1ControlMessageType.Finalize => ChannelsListenV1MessagesListenV1CloseStreamType.Finalize,
            ListenV1ControlMessageType.KeepAlive => ChannelsListenV1MessagesListenV1CloseStreamType.KeepAlive,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
    }

    private static ChannelsListenV1MessagesListenV1FinalizeType ToFinalizeType(ListenV1ControlMessageType type)
    {
        return type switch
        {
            ListenV1ControlMessageType.CloseStream => ChannelsListenV1MessagesListenV1FinalizeType.CloseStream,
            ListenV1ControlMessageType.Finalize => ChannelsListenV1MessagesListenV1FinalizeType.Finalize,
            ListenV1ControlMessageType.KeepAlive => ChannelsListenV1MessagesListenV1FinalizeType.KeepAlive,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
    }

    private static ChannelsListenV1MessagesListenV1KeepAliveType ToKeepAliveType(ListenV1ControlMessageType type)
    {
        return type switch
        {
            ListenV1ControlMessageType.CloseStream => ChannelsListenV1MessagesListenV1KeepAliveType.CloseStream,
            ListenV1ControlMessageType.Finalize => ChannelsListenV1MessagesListenV1KeepAliveType.Finalize,
            ListenV1ControlMessageType.KeepAlive => ChannelsListenV1MessagesListenV1KeepAliveType.KeepAlive,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
    }
}
