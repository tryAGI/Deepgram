
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for injecting an agent message
    /// </summary>
    public enum AgentV1AgentV1InjectDynamicAgentMessageType
    {
        /// <summary>
        ///
        /// </summary>
        InjectAgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1InjectDynamicAgentMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1InjectDynamicAgentMessageType value)
        {
            return value switch
            {
                AgentV1AgentV1InjectDynamicAgentMessageType.InjectAgentMessage => "InjectAgentMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1InjectDynamicAgentMessageType? ToEnum(string value)
        {
            return value switch
            {
                "InjectAgentMessage" => AgentV1AgentV1InjectDynamicAgentMessageType.InjectAgentMessage,
                _ => null,
            };
        }
    }
}