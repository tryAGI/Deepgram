
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specifies usage of the V1 Deepgram speech-to-text API
    /// </summary>
    public enum DeepgramListenProviderV1Version
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramListenProviderV1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramListenProviderV1Version value)
        {
            return value switch
            {
                DeepgramListenProviderV1Version.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramListenProviderV1Version? ToEnum(string value)
        {
            return value switch
            {
                "v1" => DeepgramListenProviderV1Version.V1,
                _ => null,
            };
        }
    }
}