
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - alaw. Supported container - wav (default), or no container.
    /// </summary>
    public enum V1SpeakPostParametersContainer3
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersContainer3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersContainer3 value)
        {
            return value switch
            {
                V1SpeakPostParametersContainer3.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersContainer3? ToEnum(string value)
        {
            return value switch
            {
                "wav" => V1SpeakPostParametersContainer3.Wav,
                _ => null,
            };
        }
    }
}