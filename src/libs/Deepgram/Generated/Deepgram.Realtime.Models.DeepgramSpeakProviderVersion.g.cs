
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the Deepgram text-to-speech API
    /// </summary>
    public enum DeepgramSpeakProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramSpeakProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramSpeakProviderVersion value)
        {
            return value switch
            {
                DeepgramSpeakProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramSpeakProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => DeepgramSpeakProviderVersion.V1,
                _ => null,
            };
        }
    }
}