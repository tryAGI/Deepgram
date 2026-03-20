
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum ReadV1TextAnalyzeCallbackMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadV1TextAnalyzeCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadV1TextAnalyzeCallbackMethod value)
        {
            return value switch
            {
                ReadV1TextAnalyzeCallbackMethod.Post => "POST",
                ReadV1TextAnalyzeCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadV1TextAnalyzeCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => ReadV1TextAnalyzeCallbackMethod.Post,
                "PUT" => ReadV1TextAnalyzeCallbackMethod.Put,
                _ => null,
            };
        }
    }
}