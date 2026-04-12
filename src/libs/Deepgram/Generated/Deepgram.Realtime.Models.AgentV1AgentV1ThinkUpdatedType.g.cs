
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for think update confirmation
    /// </summary>
    public enum AgentV1AgentV1ThinkUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1ThinkUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1ThinkUpdatedType value)
        {
            return value switch
            {
                AgentV1AgentV1ThinkUpdatedType.ThinkUpdated => "ThinkUpdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1ThinkUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "ThinkUpdated" => AgentV1AgentV1ThinkUpdatedType.ThinkUpdated,
                _ => null,
            };
        }
    }
}