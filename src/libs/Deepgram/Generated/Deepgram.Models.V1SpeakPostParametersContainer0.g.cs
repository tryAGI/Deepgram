
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// No container.
    /// </summary>
    public enum V1SpeakPostParametersContainer0
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersContainer0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersContainer0 value)
        {
            return value switch
            {
                V1SpeakPostParametersContainer0.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersContainer0? ToEnum(string value)
        {
            return value switch
            {
                "none" => V1SpeakPostParametersContainer0.None,
                _ => null,
            };
        }
    }
}