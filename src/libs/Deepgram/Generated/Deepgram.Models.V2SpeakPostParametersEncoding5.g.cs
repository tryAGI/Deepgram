
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - opus. High-compression audio format optimized for real-time communications.
    /// </summary>
    public enum V2SpeakPostParametersEncoding5
    {
        /// <summary>
        /// 
        /// </summary>
        Opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersEncoding5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersEncoding5 value)
        {
            return value switch
            {
                V2SpeakPostParametersEncoding5.Opus => "opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersEncoding5? ToEnum(string value)
        {
            return value switch
            {
                "opus" => V2SpeakPostParametersEncoding5.Opus,
                _ => null,
            };
        }
    }
}