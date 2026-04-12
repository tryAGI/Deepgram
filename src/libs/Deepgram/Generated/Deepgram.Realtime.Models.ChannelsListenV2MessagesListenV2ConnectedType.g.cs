
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV2MessagesListenV2ConnectedType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV2MessagesListenV2ConnectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV2MessagesListenV2ConnectedType value)
        {
            return value switch
            {
                ChannelsListenV2MessagesListenV2ConnectedType.Connected => "Connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV2MessagesListenV2ConnectedType? ToEnum(string value)
        {
            return value switch
            {
                "Connected" => ChannelsListenV2MessagesListenV2ConnectedType.Connected,
                _ => null,
            };
        }
    }
}