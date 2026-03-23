
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// HTTP method by which the callback request will be made<br/>
    /// Default Value: POST
    /// </summary>
    public enum ListenV1CallbackMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
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
    public static class ListenV1CallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1CallbackMethod value)
        {
            return value switch
            {
                ListenV1CallbackMethod.Delete => "DELETE",
                ListenV1CallbackMethod.Get => "GET",
                ListenV1CallbackMethod.Post => "POST",
                ListenV1CallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1CallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ListenV1CallbackMethod.Delete,
                "GET" => ListenV1CallbackMethod.Get,
                "POST" => ListenV1CallbackMethod.Post,
                "PUT" => ListenV1CallbackMethod.Put,
                _ => null,
            };
        }
    }
}