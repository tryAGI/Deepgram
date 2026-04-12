
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier indicating that the user has begun speaking
    /// </summary>
    public enum AgentV1AgentV1UserStartedSpeakingType
    {
        /// <summary>
        /// 
        /// </summary>
        UserStartedSpeaking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1UserStartedSpeakingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1UserStartedSpeakingType value)
        {
            return value switch
            {
                AgentV1AgentV1UserStartedSpeakingType.UserStartedSpeaking => "UserStartedSpeaking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1UserStartedSpeakingType? ToEnum(string value)
        {
            return value switch
            {
                "UserStartedSpeaking" => AgentV1AgentV1UserStartedSpeakingType.UserStartedSpeaking,
                _ => null,
            };
        }
    }
}