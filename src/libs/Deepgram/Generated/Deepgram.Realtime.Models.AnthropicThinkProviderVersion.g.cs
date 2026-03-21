
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the Anthropic Messages API
    /// </summary>
    public enum AnthropicThinkProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkProviderVersion value)
        {
            return value switch
            {
                AnthropicThinkProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => AnthropicThinkProviderVersion.V1,
                _ => null,
            };
        }
    }
}