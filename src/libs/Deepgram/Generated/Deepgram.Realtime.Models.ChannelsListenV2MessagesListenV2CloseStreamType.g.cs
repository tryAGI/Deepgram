
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV2MessagesListenV2CloseStreamType
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
    public static class ChannelsListenV2MessagesListenV2CloseStreamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV2MessagesListenV2CloseStreamType value)
        {
            return value switch
            {
                ChannelsListenV2MessagesListenV2CloseStreamType.CloseStream => "CloseStream",
                ChannelsListenV2MessagesListenV2CloseStreamType.Finalize => "Finalize",
                ChannelsListenV2MessagesListenV2CloseStreamType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV2MessagesListenV2CloseStreamType? ToEnum(string value)
        {
            return value switch
            {
                "CloseStream" => ChannelsListenV2MessagesListenV2CloseStreamType.CloseStream,
                "Finalize" => ChannelsListenV2MessagesListenV2CloseStreamType.Finalize,
                "KeepAlive" => ChannelsListenV2MessagesListenV2CloseStreamType.KeepAlive,
                _ => null,
            };
        }
    }
}