
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// OpenAI reasoning_effort
    /// </summary>
    public enum OpenAiThinkProviderReasoningMode
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiThinkProviderReasoningModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiThinkProviderReasoningMode value)
        {
            return value switch
            {
                OpenAiThinkProviderReasoningMode.High => "high",
                OpenAiThinkProviderReasoningMode.Low => "low",
                OpenAiThinkProviderReasoningMode.Medium => "medium",
                OpenAiThinkProviderReasoningMode.Minimal => "minimal",
                OpenAiThinkProviderReasoningMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiThinkProviderReasoningMode? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAiThinkProviderReasoningMode.High,
                "low" => OpenAiThinkProviderReasoningMode.Low,
                "medium" => OpenAiThinkProviderReasoningMode.Medium,
                "minimal" => OpenAiThinkProviderReasoningMode.Minimal,
                "none" => OpenAiThinkProviderReasoningMode.None,
                _ => null,
            };
        }
    }
}