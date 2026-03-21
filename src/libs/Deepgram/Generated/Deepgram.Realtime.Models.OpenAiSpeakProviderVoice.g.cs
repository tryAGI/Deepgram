
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// OpenAI voice
    /// </summary>
    public enum OpenAiSpeakProviderVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Fable,
        /// <summary>
        /// 
        /// </summary>
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiSpeakProviderVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiSpeakProviderVoice value)
        {
            return value switch
            {
                OpenAiSpeakProviderVoice.Alloy => "alloy",
                OpenAiSpeakProviderVoice.Echo => "echo",
                OpenAiSpeakProviderVoice.Fable => "fable",
                OpenAiSpeakProviderVoice.Onyx => "onyx",
                OpenAiSpeakProviderVoice.Nova => "nova",
                OpenAiSpeakProviderVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiSpeakProviderVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => OpenAiSpeakProviderVoice.Alloy,
                "echo" => OpenAiSpeakProviderVoice.Echo,
                "fable" => OpenAiSpeakProviderVoice.Fable,
                "onyx" => OpenAiSpeakProviderVoice.Onyx,
                "nova" => OpenAiSpeakProviderVoice.Nova,
                "shimmer" => OpenAiSpeakProviderVoice.Shimmer,
                _ => null,
            };
        }
    }
}