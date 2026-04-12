
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for warnings
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1WarningType
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1WarningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1WarningType value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1WarningType.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1WarningType? ToEnum(string value)
        {
            return value switch
            {
                "Warning" => ChannelsAgentV1MessagesAgentV1WarningType.Warning,
                _ => null,
            };
        }
    }
}