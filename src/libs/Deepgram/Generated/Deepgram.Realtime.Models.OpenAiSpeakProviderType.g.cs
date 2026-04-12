
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiSpeakProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        OpenAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiSpeakProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiSpeakProviderType value)
        {
            return value switch
            {
                OpenAiSpeakProviderType.OpenAi => "open_ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiSpeakProviderType? ToEnum(string value)
        {
            return value switch
            {
                "open_ai" => OpenAiSpeakProviderType.OpenAi,
                _ => null,
            };
        }
    }
}