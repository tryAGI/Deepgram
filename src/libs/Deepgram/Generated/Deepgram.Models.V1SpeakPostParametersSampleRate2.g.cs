
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - alaw. Supported sample rates - 8000, 16000 Hz.
    /// </summary>
    public enum V1SpeakPostParametersSampleRate2
    {
        /// <summary>
        /// 
        /// </summary>
        x16000,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersSampleRate2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersSampleRate2 value)
        {
            return value switch
            {
                V1SpeakPostParametersSampleRate2.x16000 => "16000",
                V1SpeakPostParametersSampleRate2.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersSampleRate2? ToEnum(string value)
        {
            return value switch
            {
                "16000" => V1SpeakPostParametersSampleRate2.x16000,
                "8000" => V1SpeakPostParametersSampleRate2.x8000,
                _ => null,
            };
        }
    }
}