
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier<br/>
    /// Example: Speak
    /// </summary>
    public enum SpeakV1TextMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Speak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1TextMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1TextMessageType value)
        {
            return value switch
            {
                SpeakV1TextMessageType.Speak => "Speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1TextMessageType? ToEnum(string value)
        {
            return value switch
            {
                "Speak" => SpeakV1TextMessageType.Speak,
                _ => null,
            };
        }
    }
}