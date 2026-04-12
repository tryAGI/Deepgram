
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum V1SpeakPostParametersCallbackMethod
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
    public static class V1SpeakPostParametersCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersCallbackMethod value)
        {
            return value switch
            {
                V1SpeakPostParametersCallbackMethod.Post => "POST",
                V1SpeakPostParametersCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => V1SpeakPostParametersCallbackMethod.Post,
                "PUT" => V1SpeakPostParametersCallbackMethod.Put,
                _ => null,
            };
        }
    }
}