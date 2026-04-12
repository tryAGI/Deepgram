
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for agent thinking
    /// </summary>
    public enum AgentV1AgentV1AgentThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1AgentThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1AgentThinkingType value)
        {
            return value switch
            {
                AgentV1AgentV1AgentThinkingType.AgentThinking => "AgentThinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1AgentThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "AgentThinking" => AgentV1AgentV1AgentThinkingType.AgentThinking,
                _ => null,
            };
        }
    }
}