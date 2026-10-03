
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier for error responses
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1ErrorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1ErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1ErrorType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1ErrorType.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1ErrorType? ToEnum(string value)
        {
            return value switch
            {
                "Error" => ChannelsListenV1MessagesListenV1ErrorType.Error,
                _ => null,
            };
        }
    }
}