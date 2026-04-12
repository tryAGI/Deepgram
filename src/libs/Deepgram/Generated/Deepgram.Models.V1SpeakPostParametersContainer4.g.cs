
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - opus. Supported container - ogg (default).
    /// </summary>
    public enum V1SpeakPostParametersContainer4
    {
        /// <summary>
        /// 
        /// </summary>
        Ogg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersContainer4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersContainer4 value)
        {
            return value switch
            {
                V1SpeakPostParametersContainer4.Ogg => "ogg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersContainer4? ToEnum(string value)
        {
            return value switch
            {
                "ogg" => V1SpeakPostParametersContainer4.Ogg,
                _ => null,
            };
        }
    }
}