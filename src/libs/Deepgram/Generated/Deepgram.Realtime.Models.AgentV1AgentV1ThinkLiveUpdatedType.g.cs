
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for Think Live model update confirmation
    /// </summary>
    public enum AgentV1AgentV1ThinkLiveUpdatedType
    {
        /// <summary>
        ///
        /// </summary>
        ThinkLiveUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1ThinkLiveUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1ThinkLiveUpdatedType value)
        {
            return value switch
            {
                AgentV1AgentV1ThinkLiveUpdatedType.ThinkLiveUpdated => "ThinkLiveUpdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1ThinkLiveUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "ThinkLiveUpdated" => AgentV1AgentV1ThinkLiveUpdatedType.ThinkLiveUpdated,
                _ => null,
            };
        }
    }
}