
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Provider type for speech-to-text
    /// </summary>
    public enum DeepgramListenProviderV1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramListenProviderV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramListenProviderV1Type value)
        {
            return value switch
            {
                DeepgramListenProviderV1Type.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramListenProviderV1Type? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => DeepgramListenProviderV1Type.Deepgram,
                _ => null,
            };
        }
    }
}