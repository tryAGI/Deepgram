
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for listen update confirmation
    /// </summary>
    public enum AgentV1AgentV1ListenUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ListenUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1AgentV1ListenUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1AgentV1ListenUpdatedType value)
        {
            return value switch
            {
                AgentV1AgentV1ListenUpdatedType.ListenUpdated => "ListenUpdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1AgentV1ListenUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "ListenUpdated" => AgentV1AgentV1ListenUpdatedType.ListenUpdated,
                _ => null,
            };
        }
    }
}