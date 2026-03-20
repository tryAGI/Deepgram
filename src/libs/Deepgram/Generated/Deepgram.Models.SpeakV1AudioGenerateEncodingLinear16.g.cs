
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingLinear16
    {
        /// <summary>
        /// 
        /// </summary>
        Linear16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingLinear16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingLinear16 value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingLinear16.Linear16 => "linear16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingLinear16? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => SpeakV1AudioGenerateEncodingLinear16.Linear16,
                _ => null,
            };
        }
    }
}