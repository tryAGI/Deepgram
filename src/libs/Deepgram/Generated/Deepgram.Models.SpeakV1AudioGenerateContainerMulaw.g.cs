
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mulaw. Supported container - wav (default), or no container.
    /// </summary>
    public enum SpeakV1AudioGenerateContainerMulaw
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateContainerMulawExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateContainerMulaw value)
        {
            return value switch
            {
                SpeakV1AudioGenerateContainerMulaw.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateContainerMulaw? ToEnum(string value)
        {
            return value switch
            {
                "wav" => SpeakV1AudioGenerateContainerMulaw.Wav,
                _ => null,
            };
        }
    }
}