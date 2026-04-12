
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for speak update confirmation
    /// </summary>
    public enum AgentV1AgentV1SpeakUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeakUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1SpeakUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1SpeakUpdatedType value)
        {
            return value switch
            {
                AgentV1AgentV1SpeakUpdatedType.SpeakUpdated => "SpeakUpdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1SpeakUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "SpeakUpdated" => AgentV1AgentV1SpeakUpdatedType.SpeakUpdated,
                _ => null,
            };
        }
    }
}