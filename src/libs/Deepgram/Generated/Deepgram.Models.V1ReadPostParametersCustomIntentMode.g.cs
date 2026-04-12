
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum V1ReadPostParametersCustomIntentMode
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
    public static class V1ReadPostParametersCustomIntentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ReadPostParametersCustomIntentMode value)
        {
            return value switch
            {
                V1ReadPostParametersCustomIntentMode.Extended => "extended",
                V1ReadPostParametersCustomIntentMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ReadPostParametersCustomIntentMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => V1ReadPostParametersCustomIntentMode.Extended,
                "strict" => V1ReadPostParametersCustomIntentMode.Strict,
                _ => null,
            };
        }
    }
}