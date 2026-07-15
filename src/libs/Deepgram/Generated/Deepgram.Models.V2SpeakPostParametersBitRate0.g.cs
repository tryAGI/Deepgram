
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mp3(default). Supported bitrates - 8000, 16000, 24000, 32000, 40000, 48000(default) bps.
    /// </summary>
    public enum V2SpeakPostParametersBitRate0
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
        x40000,
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
    public static class V2SpeakPostParametersBitRate0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersBitRate0 value)
        {
            return value switch
            {
                V2SpeakPostParametersBitRate0.x16000 => "16000",
                V2SpeakPostParametersBitRate0.x24000 => "24000",
                V2SpeakPostParametersBitRate0.x32000 => "32000",
                V2SpeakPostParametersBitRate0.x40000 => "40000",
                V2SpeakPostParametersBitRate0.x48000 => "48000",
                V2SpeakPostParametersBitRate0.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersBitRate0? ToEnum(string value)
        {
            return value switch
            {
                "16000" => V2SpeakPostParametersBitRate0.x16000,
                "24000" => V2SpeakPostParametersBitRate0.x24000,
                "32000" => V2SpeakPostParametersBitRate0.x32000,
                "40000" => V2SpeakPostParametersBitRate0.x40000,
                "48000" => V2SpeakPostParametersBitRate0.x48000,
                "8000" => V2SpeakPostParametersBitRate0.x8000,
                _ => null,
            };
        }
    }
}