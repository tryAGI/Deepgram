
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - flac. Lossless audio format for high-quality compression.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingFlac
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingFlacExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingFlac value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingFlac.Flac => "flac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingFlac? ToEnum(string value)
        {
            return value switch
            {
                "flac" => SpeakV1AudioGenerateEncodingFlac.Flac,
                _ => null,
            };
        }
    }
}