
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for error responses
    /// </summary>
    public enum AgentV1ErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1ErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1ErrorEventType value)
        {
            return value switch
            {
                AgentV1ErrorEventType.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1ErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "Error" => AgentV1ErrorEventType.Error,
                _ => null,
            };
        }
    }
}