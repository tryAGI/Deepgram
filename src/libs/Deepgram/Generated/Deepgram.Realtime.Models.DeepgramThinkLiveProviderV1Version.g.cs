
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Version of the Deepgram Think Live model. Must be `v1`
    /// </summary>
    public enum DeepgramThinkLiveProviderV1Version
    {
        /// <summary>
        ///
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramThinkLiveProviderV1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramThinkLiveProviderV1Version value)
        {
            return value switch
            {
                DeepgramThinkLiveProviderV1Version.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramThinkLiveProviderV1Version? ToEnum(string value)
        {
            return value switch
            {
                "v1" => DeepgramThinkLiveProviderV1Version.V1,
                _ => null,
            };
        }
    }
}