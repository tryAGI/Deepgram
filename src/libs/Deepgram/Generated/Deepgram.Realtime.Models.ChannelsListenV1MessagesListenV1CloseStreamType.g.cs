
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1CloseStreamType
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
    public static class ChannelsListenV1MessagesListenV1CloseStreamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1CloseStreamType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1CloseStreamType.CloseStream => "CloseStream",
                ChannelsListenV1MessagesListenV1CloseStreamType.Finalize => "Finalize",
                ChannelsListenV1MessagesListenV1CloseStreamType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1CloseStreamType? ToEnum(string value)
        {
            return value switch
            {
                "CloseStream" => ChannelsListenV1MessagesListenV1CloseStreamType.CloseStream,
                "Finalize" => ChannelsListenV1MessagesListenV1CloseStreamType.Finalize,
                "KeepAlive" => ChannelsListenV1MessagesListenV1CloseStreamType.KeepAlive,
                _ => null,
            };
        }
    }
}