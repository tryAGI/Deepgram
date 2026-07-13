
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Controls how the injection interacts with any in-progress user or agent turn.<br/>
    /// * `default` — The agent speaks only if neither the user nor the agent is mid-turn. If a turn is in progress, the server replies with `InjectionRefused`.<br/>
    /// * `queue` — The message is appended after any already-queued `ConversationText` without interrupting the current agent turn or think response. If nothing is queued, the message plays immediately.<br/>
    /// * `interrupt` — The agent immediately speaks. If the agent was already speaking, it interrupts the current speech and replaces it with the new message. If the user is speaking, the agent interrupts with the new message, but the user's continued speech triggers `UserStartedSpeaking`, which quickly interrupts the agent.<br/>
    /// Default Value: default
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Interrupt,
        /// <summary>
        /// 
        /// </summary>
        Queue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior.Default => "default",
                ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior.Interrupt => "interrupt",
                ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior.Queue => "queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior? ToEnum(string value)
        {
            return value switch
            {
                "default" => ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior.Default,
                "interrupt" => ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior.Interrupt,
                "queue" => ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior.Queue,
                _ => null,
            };
        }
    }
}