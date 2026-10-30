
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Reasoning effort. For phonellm-mini-alpha-2-fp8, use none or omit it; other values put reasoning text in the reply, which the agent speaks.
    /// </summary>
    public enum DeepgramThinkProviderReasoningMode
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
    public static class DeepgramThinkProviderReasoningModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramThinkProviderReasoningMode value)
        {
            return value switch
            {
                DeepgramThinkProviderReasoningMode.High => "high",
                DeepgramThinkProviderReasoningMode.Low => "low",
                DeepgramThinkProviderReasoningMode.Medium => "medium",
                DeepgramThinkProviderReasoningMode.Minimal => "minimal",
                DeepgramThinkProviderReasoningMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramThinkProviderReasoningMode? ToEnum(string value)
        {
            return value switch
            {
                "high" => DeepgramThinkProviderReasoningMode.High,
                "low" => DeepgramThinkProviderReasoningMode.Low,
                "medium" => DeepgramThinkProviderReasoningMode.Medium,
                "minimal" => DeepgramThinkProviderReasoningMode.Minimal,
                "none" => DeepgramThinkProviderReasoningMode.None,
                _ => null,
            };
        }
    }
}