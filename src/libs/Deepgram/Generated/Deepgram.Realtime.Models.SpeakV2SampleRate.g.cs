
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Output sample rate in Hz. With `linear16`, valid values are `8000`, `16000`, `24000`, `32000`, `44100`, and `48000`. With `mulaw` or `alaw`, valid values are `8000` and `16000`. Defaults to the model's native sample rate.
    /// </summary>
    public enum SpeakV2SampleRate
    {
        /// <summary>
        /// 
        /// </summary>
        x16000,
        /// <summary>
        /// 
        /// </summary>
        x24000,
        /// <summary>
        /// 
        /// </summary>
        x32000,
        /// <summary>
        /// 
        /// </summary>
        x44100,
        /// <summary>
        /// 
        /// </summary>
        x48000,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SampleRate value)
        {
            return value switch
            {
                SpeakV2SampleRate.x16000 => "16000",
                SpeakV2SampleRate.x24000 => "24000",
                SpeakV2SampleRate.x32000 => "32000",
                SpeakV2SampleRate.x44100 => "44100",
                SpeakV2SampleRate.x48000 => "48000",
                SpeakV2SampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => SpeakV2SampleRate.x16000,
                "24000" => SpeakV2SampleRate.x24000,
                "32000" => SpeakV2SampleRate.x32000,
                "44100" => SpeakV2SampleRate.x44100,
                "48000" => SpeakV2SampleRate.x48000,
                "8000" => SpeakV2SampleRate.x8000,
                _ => null,
            };
        }
    }
}