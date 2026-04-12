
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1KeepAliveType
    {
        /// <summary>
        /// 
        /// </summary>
        CloseStream,
        /// <summary>
        /// 
        /// </summary>
        Finalize,
        /// <summary>
        /// 
        /// </summary>
        KeepAlive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1KeepAliveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1KeepAliveType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1KeepAliveType.CloseStream => "CloseStream",
                ChannelsListenV1MessagesListenV1KeepAliveType.Finalize => "Finalize",
                ChannelsListenV1MessagesListenV1KeepAliveType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1KeepAliveType? ToEnum(string value)
        {
            return value switch
            {
                "CloseStream" => ChannelsListenV1MessagesListenV1KeepAliveType.CloseStream,
                "Finalize" => ChannelsListenV1MessagesListenV1KeepAliveType.Finalize,
                "KeepAlive" => ChannelsListenV1MessagesListenV1KeepAliveType.KeepAlive,
                _ => null,
            };
        }
    }
}