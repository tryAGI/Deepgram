
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// OpenAI TTS model
    /// </summary>
    public enum OpenAiSpeakProviderModel
    {
        /// <summary>
        /// 
        /// </summary>
        Tts1,
        /// <summary>
        /// 
        /// </summary>
        Tts1Hd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiSpeakProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiSpeakProviderModel value)
        {
            return value switch
            {
                OpenAiSpeakProviderModel.Tts1 => "tts-1",
                OpenAiSpeakProviderModel.Tts1Hd => "tts-1-hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiSpeakProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "tts-1" => OpenAiSpeakProviderModel.Tts1,
                "tts-1-hd" => OpenAiSpeakProviderModel.Tts1Hd,
                _ => null,
            };
        }
    }
}