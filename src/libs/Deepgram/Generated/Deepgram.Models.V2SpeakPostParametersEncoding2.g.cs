
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mulaw. Compressed audio format commonly used in telephony.
    /// </summary>
    public enum V2SpeakPostParametersEncoding2
    {
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersEncoding2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersEncoding2 value)
        {
            return value switch
            {
                V2SpeakPostParametersEncoding2.Mulaw => "mulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersEncoding2? ToEnum(string value)
        {
            return value switch
            {
                "mulaw" => V2SpeakPostParametersEncoding2.Mulaw,
                _ => null,
            };
        }
    }
}