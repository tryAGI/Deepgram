
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV1ControlEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Flushed,
        /// <summary>
        /// 
        /// </summary>
        Cleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1ControlEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1ControlEventType value)
        {
            return value switch
            {
                SpeakV1ControlEventType.Flushed => "Flushed",
                SpeakV1ControlEventType.Cleared => "Cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1ControlEventType? ToEnum(string value)
        {
            return value switch
            {
                "Flushed" => SpeakV1ControlEventType.Flushed,
                "Cleared" => SpeakV1ControlEventType.Cleared,
                _ => null,
            };
        }
    }
}