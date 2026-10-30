
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Provider type for Deepgram-hosted language models. Must be `deepgram`.
    /// </summary>
    public enum DeepgramThinkProviderType
    {
        /// <summary>
        ///
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramThinkProviderType value)
        {
            return value switch
            {
                DeepgramThinkProviderType.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => DeepgramThinkProviderType.Deepgram,
                _ => null,
            };
        }
    }
}