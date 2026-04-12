
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for injecting a user message
    /// </summary>
    public enum AgentV1AgentV1InjectUserMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        InjectUserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1InjectUserMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1InjectUserMessageType value)
        {
            return value switch
            {
                AgentV1AgentV1InjectUserMessageType.InjectUserMessage => "InjectUserMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1InjectUserMessageType? ToEnum(string value)
        {
            return value switch
            {
                "InjectUserMessage" => AgentV1AgentV1InjectUserMessageType.InjectUserMessage,
                _ => null,
            };
        }
    }
}