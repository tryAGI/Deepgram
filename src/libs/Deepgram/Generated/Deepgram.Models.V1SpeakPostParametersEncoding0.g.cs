
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - linear16. Uncompressed, high-quality audio format often used for telephony or audio processing.
    /// </summary>
    public enum V1SpeakPostParametersEncoding0
    {
        /// <summary>
        /// 
        /// </summary>
        Linear16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersEncoding0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersEncoding0 value)
        {
            return value switch
            {
                V1SpeakPostParametersEncoding0.Linear16 => "linear16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersEncoding0? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => V1SpeakPostParametersEncoding0.Linear16,
                _ => null,
            };
        }
    }
}