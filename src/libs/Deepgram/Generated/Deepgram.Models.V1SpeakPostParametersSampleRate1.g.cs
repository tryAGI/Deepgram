
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mulaw. Supported sample rates - 8000, 16000 Hz.
    /// </summary>
    public enum V1SpeakPostParametersSampleRate1
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
    public static class V1SpeakPostParametersSampleRate1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersSampleRate1 value)
        {
            return value switch
            {
                V1SpeakPostParametersSampleRate1.x16000 => "16000",
                V1SpeakPostParametersSampleRate1.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersSampleRate1? ToEnum(string value)
        {
            return value switch
            {
                "16000" => V1SpeakPostParametersSampleRate1.x16000,
                "8000" => V1SpeakPostParametersSampleRate1.x8000,
                _ => null,
            };
        }
    }
}