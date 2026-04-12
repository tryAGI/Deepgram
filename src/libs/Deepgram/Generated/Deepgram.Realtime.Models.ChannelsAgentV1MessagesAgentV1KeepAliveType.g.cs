
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1KeepAliveType
    {
        /// <summary>
        /// 
        /// </summary>
        KeepAlive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1KeepAliveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1KeepAliveType value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1KeepAliveType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1KeepAliveType? ToEnum(string value)
        {
            return value switch
            {
                "KeepAlive" => ChannelsAgentV1MessagesAgentV1KeepAliveType.KeepAlive,
                _ => null,
            };
        }
    }
}