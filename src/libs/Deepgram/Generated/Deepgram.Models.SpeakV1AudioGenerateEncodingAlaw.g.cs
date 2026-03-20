
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - alaw. Similar to mulaw but used in international telephony.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingAlaw
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingAlawExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingAlaw value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingAlaw.Alaw => "alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingAlaw? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => SpeakV1AudioGenerateEncodingAlaw.Alaw,
                _ => null,
            };
        }
    }
}