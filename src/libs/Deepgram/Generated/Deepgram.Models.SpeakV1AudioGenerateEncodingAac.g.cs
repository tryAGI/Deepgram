
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - aac. Advanced audio format offering better quality at smaller file sizes than mp3.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingAac
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingAacExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingAac value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingAac.Aac => "aac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingAac? ToEnum(string value)
        {
            return value switch
            {
                "aac" => SpeakV1AudioGenerateEncodingAac.Aac,
                _ => null,
            };
        }
    }
}