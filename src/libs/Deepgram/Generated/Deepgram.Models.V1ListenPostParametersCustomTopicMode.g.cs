
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum V1ListenPostParametersCustomTopicMode
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
    public static class V1ListenPostParametersCustomTopicModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersCustomTopicMode value)
        {
            return value switch
            {
                V1ListenPostParametersCustomTopicMode.Extended => "extended",
                V1ListenPostParametersCustomTopicMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersCustomTopicMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => V1ListenPostParametersCustomTopicMode.Extended,
                "strict" => V1ListenPostParametersCustomTopicMode.Strict,
                _ => null,
            };
        }
    }
}