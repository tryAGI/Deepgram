
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - linear16. Supported container - wav (default), or no container.
    /// </summary>
    public enum V2SpeakPostParametersContainer1
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersContainer1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersContainer1 value)
        {
            return value switch
            {
                V2SpeakPostParametersContainer1.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersContainer1? ToEnum(string value)
        {
            return value switch
            {
                "wav" => V2SpeakPostParametersContainer1.Wav,
                _ => null,
            };
        }
    }
}