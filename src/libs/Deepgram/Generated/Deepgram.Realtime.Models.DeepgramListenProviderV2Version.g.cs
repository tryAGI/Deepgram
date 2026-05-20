
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specifies usage of the V2 Deepgram speech-to-text API (e.g. Flux)
    /// </summary>
    public enum DeepgramListenProviderV2Version
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramListenProviderV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramListenProviderV2Version value)
        {
            return value switch
            {
                DeepgramListenProviderV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramListenProviderV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => DeepgramListenProviderV2Version.V2,
                _ => null,
            };
        }
    }
}