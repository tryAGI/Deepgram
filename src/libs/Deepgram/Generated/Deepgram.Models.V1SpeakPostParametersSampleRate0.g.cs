
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - linear16. Supported sample rates - 8000, 16000, 24000, 32000, 48000 Hz.
    /// </summary>
    public enum V1SpeakPostParametersSampleRate0
    {
        /// <summary>
        /// 
        /// </summary>
        x16000,
        /// <summary>
        /// 
        /// </summary>
        x24000,
        /// <summary>
        /// 
        /// </summary>
        x32000,
        /// <summary>
        /// 
        /// </summary>
        x48000,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersSampleRate0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersSampleRate0 value)
        {
            return value switch
            {
                V1SpeakPostParametersSampleRate0.x16000 => "16000",
                V1SpeakPostParametersSampleRate0.x24000 => "24000",
                V1SpeakPostParametersSampleRate0.x32000 => "32000",
                V1SpeakPostParametersSampleRate0.x48000 => "48000",
                V1SpeakPostParametersSampleRate0.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersSampleRate0? ToEnum(string value)
        {
            return value switch
            {
                "16000" => V1SpeakPostParametersSampleRate0.x16000,
                "24000" => V1SpeakPostParametersSampleRate0.x24000,
                "32000" => V1SpeakPostParametersSampleRate0.x32000,
                "48000" => V1SpeakPostParametersSampleRate0.x48000,
                "8000" => V1SpeakPostParametersSampleRate0.x8000,
                _ => null,
            };
        }
    }
}