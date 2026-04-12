
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum V1ReadPostParametersCallbackMethod
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
    public static class V1ReadPostParametersCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ReadPostParametersCallbackMethod value)
        {
            return value switch
            {
                V1ReadPostParametersCallbackMethod.Post => "POST",
                V1ReadPostParametersCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ReadPostParametersCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => V1ReadPostParametersCallbackMethod.Post,
                "PUT" => V1ReadPostParametersCallbackMethod.Put,
                _ => null,
            };
        }
    }
}