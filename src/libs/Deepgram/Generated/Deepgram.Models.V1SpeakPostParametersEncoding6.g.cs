
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
    /// </summary>
    public enum V1SpeakPostParametersEncoding6
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersEncoding6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersEncoding6 value)
        {
            return value switch
            {
                V1SpeakPostParametersEncoding6.Aac => "aac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersEncoding6? ToEnum(string value)
        {
            return value switch
            {
                "aac" => V1SpeakPostParametersEncoding6.Aac,
                _ => null,
            };
        }
    }
}