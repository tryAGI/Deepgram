
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum ReadV1TextAnalyzeCustomIntentMode
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
    public static class ReadV1TextAnalyzeCustomIntentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadV1TextAnalyzeCustomIntentMode value)
        {
            return value switch
            {
                ReadV1TextAnalyzeCustomIntentMode.Extended => "extended",
                ReadV1TextAnalyzeCustomIntentMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadV1TextAnalyzeCustomIntentMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => ReadV1TextAnalyzeCustomIntentMode.Extended,
                "strict" => ReadV1TextAnalyzeCustomIntentMode.Strict,
                _ => null,
            };
        }
    }
}