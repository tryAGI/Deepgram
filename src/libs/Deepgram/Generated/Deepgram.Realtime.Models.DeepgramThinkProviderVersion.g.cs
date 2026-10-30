
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// API version for the Deepgram think provider. Defaults to `v1`.<br/>
    /// Default Value: v1
    /// </summary>
    public enum DeepgramThinkProviderVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramThinkProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramThinkProviderVersion value)
        {
            return value switch
            {
                DeepgramThinkProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramThinkProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => DeepgramThinkProviderVersion.V1,
                _ => null,
            };
        }
    }
}