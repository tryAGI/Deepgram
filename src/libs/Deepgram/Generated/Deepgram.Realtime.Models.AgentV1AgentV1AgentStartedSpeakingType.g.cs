
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for agent started speaking
    /// </summary>
    public enum AgentV1AgentV1AgentStartedSpeakingType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentStartedSpeaking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1AgentStartedSpeakingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1AgentStartedSpeakingType value)
        {
            return value switch
            {
                AgentV1AgentV1AgentStartedSpeakingType.AgentStartedSpeaking => "AgentStartedSpeaking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1AgentStartedSpeakingType? ToEnum(string value)
        {
            return value switch
            {
                "AgentStartedSpeaking" => AgentV1AgentV1AgentStartedSpeakingType.AgentStartedSpeaking,
                _ => null,
            };
        }
    }
}