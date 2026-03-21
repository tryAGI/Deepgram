
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for warnings
    /// </summary>
    public enum AgentV1WarningEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1WarningEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1WarningEventType value)
        {
            return value switch
            {
                AgentV1WarningEventType.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1WarningEventType? ToEnum(string value)
        {
            return value switch
            {
                "Warning" => AgentV1WarningEventType.Warning,
                _ => null,
            };
        }
    }
}