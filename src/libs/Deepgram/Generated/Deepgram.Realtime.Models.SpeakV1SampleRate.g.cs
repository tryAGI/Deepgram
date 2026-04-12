
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Sample Rate specifies the sample rate for the output audio. Based on encoding 8000 or 24000 are possible defaults. For some encodings sample rate is not configurable.<br/>
    /// Default Value: 24000
    /// </summary>
    public enum SpeakV1SampleRate
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
        x48000,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1SampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1SampleRate value)
        {
            return value switch
            {
                SpeakV1SampleRate.x16000 => "16000",
                SpeakV1SampleRate.x24000 => "24000",
                SpeakV1SampleRate.x32000 => "32000",
                SpeakV1SampleRate.x48000 => "48000",
                SpeakV1SampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1SampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => SpeakV1SampleRate.x16000,
                "24000" => SpeakV1SampleRate.x24000,
                "32000" => SpeakV1SampleRate.x32000,
                "48000" => SpeakV1SampleRate.x48000,
                "8000" => SpeakV1SampleRate.x8000,
                _ => null,
            };
        }
    }
}