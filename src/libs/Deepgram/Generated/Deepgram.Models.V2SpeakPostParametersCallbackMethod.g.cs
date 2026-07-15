
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum V2SpeakPostParametersCallbackMethod
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
    public static class V2SpeakPostParametersCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersCallbackMethod value)
        {
            return value switch
            {
                V2SpeakPostParametersCallbackMethod.Post => "POST",
                V2SpeakPostParametersCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => V2SpeakPostParametersCallbackMethod.Post,
                "PUT" => V2SpeakPostParametersCallbackMethod.Put,
                _ => null,
            };
        }
    }
}