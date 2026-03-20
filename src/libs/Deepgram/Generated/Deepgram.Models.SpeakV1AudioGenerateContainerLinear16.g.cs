
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - linear16. Supported container - wav (default), or no container.
    /// </summary>
    public enum SpeakV1AudioGenerateContainerLinear16
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateContainerLinear16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateContainerLinear16 value)
        {
            return value switch
            {
                SpeakV1AudioGenerateContainerLinear16.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateContainerLinear16? ToEnum(string value)
        {
            return value switch
            {
                "wav" => SpeakV1AudioGenerateContainerLinear16.Wav,
                _ => null,
            };
        }
    }
}