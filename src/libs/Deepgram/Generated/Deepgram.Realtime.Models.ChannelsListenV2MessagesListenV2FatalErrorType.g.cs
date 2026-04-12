
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV2MessagesListenV2FatalErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV2MessagesListenV2FatalErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV2MessagesListenV2FatalErrorType value)
        {
            return value switch
            {
                ChannelsListenV2MessagesListenV2FatalErrorType.Error => "Error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV2MessagesListenV2FatalErrorType? ToEnum(string value)
        {
            return value switch
            {
                "Error" => ChannelsListenV2MessagesListenV2FatalErrorType.Error,
                _ => null,
            };
        }
    }
}