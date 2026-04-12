
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum V1ListenPostParametersCallbackMethod
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
    public static class V1ListenPostParametersCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersCallbackMethod value)
        {
            return value switch
            {
                V1ListenPostParametersCallbackMethod.Post => "POST",
                V1ListenPostParametersCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => V1ListenPostParametersCallbackMethod.Post,
                "PUT" => V1ListenPostParametersCallbackMethod.Put,
                _ => null,
            };
        }
    }
}