
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum ReadV1TextAnalyzeCustomTopicMode
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
    public static class ReadV1TextAnalyzeCustomTopicModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadV1TextAnalyzeCustomTopicMode value)
        {
            return value switch
            {
                ReadV1TextAnalyzeCustomTopicMode.Extended => "extended",
                ReadV1TextAnalyzeCustomTopicMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadV1TextAnalyzeCustomTopicMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => ReadV1TextAnalyzeCustomTopicMode.Extended,
                "strict" => ReadV1TextAnalyzeCustomTopicMode.Strict,
                _ => null,
            };
        }
    }
}