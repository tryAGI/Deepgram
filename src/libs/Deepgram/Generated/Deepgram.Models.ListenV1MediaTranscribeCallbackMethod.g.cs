
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum ListenV1MediaTranscribeCallbackMethod
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
    public static class ListenV1MediaTranscribeCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeCallbackMethod value)
        {
            return value switch
            {
                ListenV1MediaTranscribeCallbackMethod.Post => "POST",
                ListenV1MediaTranscribeCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => ListenV1MediaTranscribeCallbackMethod.Post,
                "PUT" => ListenV1MediaTranscribeCallbackMethod.Put,
                _ => null,
            };
        }
    }
}