
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Provider type for the Think Live model. Must be `deepgram`
    /// </summary>
    public enum DeepgramThinkLiveProviderV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramThinkLiveProviderV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramThinkLiveProviderV1Type value)
        {
            return value switch
            {
                DeepgramThinkLiveProviderV1Type.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramThinkLiveProviderV1Type? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => DeepgramThinkLiveProviderV1Type.Deepgram,
                _ => null,
            };
        }
    }
}