
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1SpeechStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1SpeechStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1SpeechStartedType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1SpeechStartedType.SpeechStarted => "SpeechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1SpeechStartedType? ToEnum(string value)
        {
            return value switch
            {
                "SpeechStarted" => ChannelsListenV1MessagesListenV1SpeechStartedType.SpeechStarted,
                _ => null,
            };
        }
    }
}