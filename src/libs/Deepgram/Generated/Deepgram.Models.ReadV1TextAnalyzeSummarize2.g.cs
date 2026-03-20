
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReadV1TextAnalyzeSummarize2
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadV1TextAnalyzeSummarize2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadV1TextAnalyzeSummarize2 value)
        {
            return value switch
            {
                ReadV1TextAnalyzeSummarize2.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadV1TextAnalyzeSummarize2? ToEnum(string value)
        {
            return value switch
            {
                "v2" => ReadV1TextAnalyzeSummarize2.V2,
                _ => null,
            };
        }
    }
}