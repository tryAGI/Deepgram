
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
        SixteenThousand,
        /// <summary>
        /// 
        /// </summary>
        TwentyFourThousand,
        /// <summary>
        /// 
        /// </summary>
        ThirtyTwoThousand,
        /// <summary>
        /// 
        /// </summary>
        FortyEightThousand,
        /// <summary>
        /// 
        /// </summary>
        EightThousand,
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
                SpeakV1SampleRate.SixteenThousand => "16000",
                SpeakV1SampleRate.TwentyFourThousand => "24000",
                SpeakV1SampleRate.ThirtyTwoThousand => "32000",
                SpeakV1SampleRate.FortyEightThousand => "48000",
                SpeakV1SampleRate.EightThousand => "8000",
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
                "16000" => SpeakV1SampleRate.SixteenThousand,
                "24000" => SpeakV1SampleRate.TwentyFourThousand,
                "32000" => SpeakV1SampleRate.ThirtyTwoThousand,
                "48000" => SpeakV1SampleRate.FortyEightThousand,
                "8000" => SpeakV1SampleRate.EightThousand,
                _ => null,
            };
        }
    }
}