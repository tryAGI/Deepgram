
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - alaw. Similar to mulaw but used in international telephony.
    /// </summary>
    public enum V1SpeakPostParametersEncoding3
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersEncoding3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersEncoding3 value)
        {
            return value switch
            {
                V1SpeakPostParametersEncoding3.Alaw => "alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersEncoding3? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => V1SpeakPostParametersEncoding3.Alaw,
                _ => null,
            };
        }
    }
}