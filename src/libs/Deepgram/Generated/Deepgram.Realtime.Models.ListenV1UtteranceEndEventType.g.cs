
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV1UtteranceEndEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UtteranceEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1UtteranceEndEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1UtteranceEndEventType value)
        {
            return value switch
            {
                ListenV1UtteranceEndEventType.UtteranceEnd => "UtteranceEnd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1UtteranceEndEventType? ToEnum(string value)
        {
            return value switch
            {
                "UtteranceEnd" => ListenV1UtteranceEndEventType.UtteranceEnd,
                _ => null,
            };
        }
    }
}