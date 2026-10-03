
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1ConfigureType
    {
        /// <summary>
        ///
        /// </summary>
        Configure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1ConfigureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1ConfigureType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1ConfigureType.Configure => "Configure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1ConfigureType? ToEnum(string value)
        {
            return value switch
            {
                "Configure" => ChannelsListenV1MessagesListenV1ConfigureType.Configure,
                _ => null,
            };
        }
    }
}