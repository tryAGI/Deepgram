
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - flac. Lossless audio format for high-quality compression.
    /// </summary>
    public enum V2SpeakPostParametersEncoding1
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersEncoding1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersEncoding1 value)
        {
            return value switch
            {
                V2SpeakPostParametersEncoding1.Flac => "flac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersEncoding1? ToEnum(string value)
        {
            return value switch
            {
                "flac" => V2SpeakPostParametersEncoding1.Flac,
                _ => null,
            };
        }
    }
}