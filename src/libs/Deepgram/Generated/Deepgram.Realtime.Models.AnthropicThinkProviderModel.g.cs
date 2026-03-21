
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Anthropic model to use
    /// </summary>
    public enum AnthropicThinkProviderModel
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35HaikuLatest,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet420250514,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkProviderModel value)
        {
            return value switch
            {
                AnthropicThinkProviderModel.Claude35HaikuLatest => "claude-3-5-haiku-latest",
                AnthropicThinkProviderModel.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-latest" => AnthropicThinkProviderModel.Claude35HaikuLatest,
                "claude-sonnet-4-20250514" => AnthropicThinkProviderModel.ClaudeSonnet420250514,
                _ => null,
            };
        }
    }
}