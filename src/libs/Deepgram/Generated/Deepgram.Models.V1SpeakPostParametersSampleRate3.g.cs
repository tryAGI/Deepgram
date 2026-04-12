
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - mp3. Sample rate is fixed and not configurable (22050 Hz).
    /// </summary>
    public enum V1SpeakPostParametersSampleRate3
    {
        /// <summary>
        /// 
        /// </summary>
        x22050,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersSampleRate3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersSampleRate3 value)
        {
            return value switch
            {
                V1SpeakPostParametersSampleRate3.x22050 => "22050",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersSampleRate3? ToEnum(string value)
        {
            return value switch
            {
                "22050" => V1SpeakPostParametersSampleRate3.x22050,
                _ => null,
            };
        }
    }
}