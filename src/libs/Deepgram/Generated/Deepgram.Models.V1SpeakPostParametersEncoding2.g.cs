
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mulaw. Compressed audio format commonly used in telephony.
    /// </summary>
    public enum V1SpeakPostParametersEncoding2
    {
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersEncoding2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersEncoding2 value)
        {
            return value switch
            {
                V1SpeakPostParametersEncoding2.Mulaw => "mulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersEncoding2? ToEnum(string value)
        {
            return value switch
            {
                "mulaw" => V1SpeakPostParametersEncoding2.Mulaw,
                _ => null,
            };
        }
    }
}