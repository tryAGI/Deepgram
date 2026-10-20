
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1ConfigureFailureType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigureFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1ConfigureFailureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1ConfigureFailureType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1ConfigureFailureType.ConfigureFailure => "ConfigureFailure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1ConfigureFailureType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureFailure" => ChannelsListenV1MessagesListenV1ConfigureFailureType.ConfigureFailure,
                _ => null,
            };
        }
    }
}