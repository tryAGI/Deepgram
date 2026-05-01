
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// OpenAI reasoning_effort
    /// </summary>
    public enum GroqThinkProviderReasoningMode
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
    public static class GroqThinkProviderReasoningModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroqThinkProviderReasoningMode value)
        {
            return value switch
            {
                GroqThinkProviderReasoningMode.High => "high",
                GroqThinkProviderReasoningMode.Low => "low",
                GroqThinkProviderReasoningMode.Medium => "medium",
                GroqThinkProviderReasoningMode.Minimal => "minimal",
                GroqThinkProviderReasoningMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroqThinkProviderReasoningMode? ToEnum(string value)
        {
            return value switch
            {
                "high" => GroqThinkProviderReasoningMode.High,
                "low" => GroqThinkProviderReasoningMode.Low,
                "medium" => GroqThinkProviderReasoningMode.Medium,
                "minimal" => GroqThinkProviderReasoningMode.Minimal,
                "none" => GroqThinkProviderReasoningMode.None,
                _ => null,
            };
        }
    }
}