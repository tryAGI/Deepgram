
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum SpeakV1AudioGenerateCallbackMethod
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
    public static class SpeakV1AudioGenerateCallbackMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateCallbackMethod value)
        {
            return value switch
            {
                SpeakV1AudioGenerateCallbackMethod.Post => "POST",
                SpeakV1AudioGenerateCallbackMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateCallbackMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => SpeakV1AudioGenerateCallbackMethod.Post,
                "PUT" => SpeakV1AudioGenerateCallbackMethod.Put,
                _ => null,
            };
        }
    }
}