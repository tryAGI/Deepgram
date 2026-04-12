
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum V1ReadPostParametersCustomTopicMode
    {
        /// <summary>
        /// 
        /// </summary>
        Extended,
        /// <summary>
        /// 
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ReadPostParametersCustomTopicModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ReadPostParametersCustomTopicMode value)
        {
            return value switch
            {
                V1ReadPostParametersCustomTopicMode.Extended => "extended",
                V1ReadPostParametersCustomTopicMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ReadPostParametersCustomTopicMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => V1ReadPostParametersCustomTopicMode.Extended,
                "strict" => V1ReadPostParametersCustomTopicMode.Strict,
                _ => null,
            };
        }
    }
}