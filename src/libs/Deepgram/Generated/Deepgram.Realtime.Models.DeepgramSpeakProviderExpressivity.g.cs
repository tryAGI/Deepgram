
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Delivery register of the generated speech, on a calm-to-animated axis. Flux TTS (version v2) only, on every Flux voice. Accepts the whole numbers -2 to 2, where 0 (the default) is the voice's tuned delivery and the only value validated for production, -2 the calm end of the range and 2 the animated end. Fixed for the session. Beta: behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors. See [Expressivity](/docs/tts-expressivity).
    /// </summary>
    public enum DeepgramSpeakProviderExpressivity
    {
        /// <summary>
        /// 
        /// </summary>
        Minus1,
        /// <summary>
        /// behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors. See [Expressivity](/docs/tts-expressivity).
        /// </summary>
        Minus2,
        /// <summary>
        /// behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors. See [Expressivity](/docs/tts-expressivity).
        /// </summary>
        x0,
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// behavior may change in future model versions, and non-default values increase the risk of hallucinations and pronunciation errors. See [Expressivity](/docs/tts-expressivity).
        /// </summary>
        x2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramSpeakProviderExpressivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramSpeakProviderExpressivity value)
        {
            return value switch
            {
                DeepgramSpeakProviderExpressivity.Minus1 => "-1",
                DeepgramSpeakProviderExpressivity.Minus2 => "-2",
                DeepgramSpeakProviderExpressivity.x0 => "0",
                DeepgramSpeakProviderExpressivity.x1 => "1",
                DeepgramSpeakProviderExpressivity.x2 => "2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramSpeakProviderExpressivity? ToEnum(string value)
        {
            return value switch
            {
                "-1" => DeepgramSpeakProviderExpressivity.Minus1,
                "-2" => DeepgramSpeakProviderExpressivity.Minus2,
                "0" => DeepgramSpeakProviderExpressivity.x0,
                "1" => DeepgramSpeakProviderExpressivity.x1,
                "2" => DeepgramSpeakProviderExpressivity.x2,
                _ => null,
            };
        }
    }
}