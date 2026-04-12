
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiThinkProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        OpenAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiThinkProviderType value)
        {
            return value switch
            {
                OpenAiThinkProviderType.OpenAi => "open_ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "open_ai" => OpenAiThinkProviderType.OpenAi,
                _ => null,
            };
        }
    }
}