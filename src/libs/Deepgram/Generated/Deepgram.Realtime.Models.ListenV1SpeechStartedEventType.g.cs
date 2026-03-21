
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV1SpeechStartedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1SpeechStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1SpeechStartedEventType value)
        {
            return value switch
            {
                ListenV1SpeechStartedEventType.SpeechStarted => "SpeechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1SpeechStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "SpeechStarted" => ListenV1SpeechStartedEventType.SpeechStarted,
                _ => null,
            };
        }
    }
}