
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum V1ListenPostParametersCustomIntentMode
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
    public static class V1ListenPostParametersCustomIntentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersCustomIntentMode value)
        {
            return value switch
            {
                V1ListenPostParametersCustomIntentMode.Extended => "extended",
                V1ListenPostParametersCustomIntentMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersCustomIntentMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => V1ListenPostParametersCustomIntentMode.Extended,
                "strict" => V1ListenPostParametersCustomIntentMode.Strict,
                _ => null,
            };
        }
    }
}