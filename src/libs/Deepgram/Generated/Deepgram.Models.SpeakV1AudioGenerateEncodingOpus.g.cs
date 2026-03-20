
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - opus. High-compression audio format optimized for real-time communications.
    /// </summary>
    public enum SpeakV1AudioGenerateEncodingOpus
    {
        /// <summary>
        /// 
        /// </summary>
        Opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateEncodingOpusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateEncodingOpus value)
        {
            return value switch
            {
                SpeakV1AudioGenerateEncodingOpus.Opus => "opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateEncodingOpus? ToEnum(string value)
        {
            return value switch
            {
                "opus" => SpeakV1AudioGenerateEncodingOpus.Opus,
                _ => null,
            };
        }
    }
}