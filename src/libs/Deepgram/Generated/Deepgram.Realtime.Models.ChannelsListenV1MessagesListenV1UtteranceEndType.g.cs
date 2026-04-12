
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1UtteranceEndType
    {
        /// <summary>
        /// 
        /// </summary>
        UtteranceEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1UtteranceEndTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1UtteranceEndType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1UtteranceEndType.UtteranceEnd => "UtteranceEnd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1UtteranceEndType? ToEnum(string value)
        {
            return value switch
            {
                "UtteranceEnd" => ChannelsListenV1MessagesListenV1UtteranceEndType.UtteranceEnd,
                _ => null,
            };
        }
    }
}