
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for injecting an agent message
    /// </summary>
    public enum AgentV1AgentV1InjectAgentMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        InjectAgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1InjectAgentMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1InjectAgentMessageType value)
        {
            return value switch
            {
                AgentV1AgentV1InjectAgentMessageType.InjectAgentMessage => "InjectAgentMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1InjectAgentMessageType? ToEnum(string value)
        {
            return value switch
            {
                "InjectAgentMessage" => AgentV1AgentV1InjectAgentMessageType.InjectAgentMessage,
                _ => null,
            };
        }
    }
}