
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
    /// </summary>
    public enum V2SpeakPostParametersEncoding6
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersEncoding6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersEncoding6 value)
        {
            return value switch
            {
                V2SpeakPostParametersEncoding6.Aac => "aac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersEncoding6? ToEnum(string value)
        {
            return value switch
            {
                "aac" => V2SpeakPostParametersEncoding6.Aac,
                _ => null,
            };
        }
    }
}