
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ReadPostParametersSummarize0
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ReadPostParametersSummarize0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ReadPostParametersSummarize0 value)
        {
            return value switch
            {
                V1ReadPostParametersSummarize0.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ReadPostParametersSummarize0? ToEnum(string value)
        {
            return value switch
            {
                "v2" => V1ReadPostParametersSummarize0.V2,
                _ => null,
            };
        }
    }
}