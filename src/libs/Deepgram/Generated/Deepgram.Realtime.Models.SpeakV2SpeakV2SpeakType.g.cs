
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2SpeakType
    {
        /// <summary>
        /// 
        /// </summary>
        Speak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2SpeakTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2SpeakType value)
        {
            return value switch
            {
                SpeakV2SpeakV2SpeakType.Speak => "Speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2SpeakType? ToEnum(string value)
        {
            return value switch
            {
                "Speak" => SpeakV2SpeakV2SpeakType.Speak,
                _ => null,
            };
        }
    }
}