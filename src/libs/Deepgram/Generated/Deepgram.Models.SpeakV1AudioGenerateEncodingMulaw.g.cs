
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mulaw. Compressed audio format commonly used in telephony.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingMulaw
    {
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingMulawExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingMulaw value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingMulaw.Mulaw => "mulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingMulaw? ToEnum(string value)
        {
            return value switch
            {
                "mulaw" => SpeakV1AudioGenerateEncodingMulaw.Mulaw,
                _ => null,
            };
        }
    }
}