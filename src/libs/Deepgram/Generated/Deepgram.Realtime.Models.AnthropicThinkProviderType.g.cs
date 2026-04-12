
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicThinkProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkProviderType value)
        {
            return value switch
            {
                AnthropicThinkProviderType.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AnthropicThinkProviderType.Anthropic,
                _ => null,
            };
        }
    }
}