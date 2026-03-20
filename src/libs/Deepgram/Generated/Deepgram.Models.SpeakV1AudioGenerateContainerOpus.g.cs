
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - opus. Supported container - ogg (default).
    /// </summary>
    public enum SpeakV1AudioGenerateContainerOpus
    {
        /// <summary>
        /// 
        /// </summary>
        Ogg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateContainerOpusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateContainerOpus value)
        {
            return value switch
            {
                SpeakV1AudioGenerateContainerOpus.Ogg => "ogg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateContainerOpus? ToEnum(string value)
        {
            return value switch
            {
                "ogg" => SpeakV1AudioGenerateContainerOpus.Ogg,
                _ => null,
            };
        }
    }
}