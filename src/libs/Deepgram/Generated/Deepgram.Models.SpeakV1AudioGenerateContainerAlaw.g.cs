
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - alaw. Supported container - wav (default), or no container.
    /// </summary>
    public enum SpeakV1AudioGenerateContainerAlaw
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateContainerAlawExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateContainerAlaw value)
        {
            return value switch
            {
                SpeakV1AudioGenerateContainerAlaw.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateContainerAlaw? ToEnum(string value)
        {
            return value switch
            {
                "wav" => SpeakV1AudioGenerateContainerAlaw.Wav,
                _ => null,
            };
        }
    }
}