
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mp3(default). Supported bitrates - 32000, 48000(default) bps.
    /// </summary>
    public enum V1SpeakPostParametersBitRate0
    {
        /// <summary>
        /// 
        /// </summary>
        x32000,
        /// <summary>
        /// 
        /// </summary>
        x48000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersBitRate0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersBitRate0 value)
        {
            return value switch
            {
                V1SpeakPostParametersBitRate0.x32000 => "32000",
                V1SpeakPostParametersBitRate0.x48000 => "48000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersBitRate0? ToEnum(string value)
        {
            return value switch
            {
                "32000" => V1SpeakPostParametersBitRate0.x32000,
                "48000" => V1SpeakPostParametersBitRate0.x48000,
                _ => null,
            };
        }
    }
}