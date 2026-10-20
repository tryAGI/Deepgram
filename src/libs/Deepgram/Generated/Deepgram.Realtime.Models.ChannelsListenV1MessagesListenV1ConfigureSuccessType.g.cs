
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1ConfigureSuccessType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigureSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1ConfigureSuccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1ConfigureSuccessType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1ConfigureSuccessType.ConfigureSuccess => "ConfigureSuccess",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1ConfigureSuccessType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureSuccess" => ChannelsListenV1MessagesListenV1ConfigureSuccessType.ConfigureSuccess,
                _ => null,
            };
        }
    }
}