
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Speech-rate multiplier. `1.00` is the model's nominal rate; lower is slower. Accepted values: `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.<br/>
    /// Default Value: 1.00
    /// </summary>
    public enum SpeakV2Speed
    {
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x085,
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x090,
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x095,
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x100,
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x105,
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x110,
        /// <summary>
        /// `0.85`, `0.90`, `0.95`, `1.00`, `1.05`, `1.10`, `1.15`. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.
        /// </summary>
        x115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2Speed value)
        {
            return value switch
            {
                SpeakV2Speed.x085 => "0.85",
                SpeakV2Speed.x090 => "0.90",
                SpeakV2Speed.x095 => "0.95",
                SpeakV2Speed.x100 => "1.00",
                SpeakV2Speed.x105 => "1.05",
                SpeakV2Speed.x110 => "1.10",
                SpeakV2Speed.x115 => "1.15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2Speed? ToEnum(string value)
        {
            return value switch
            {
                "0.85" => SpeakV2Speed.x085,
                "0.90" => SpeakV2Speed.x090,
                "0.95" => SpeakV2Speed.x095,
                "1.00" => SpeakV2Speed.x100,
                "1.05" => SpeakV2Speed.x105,
                "1.10" => SpeakV2Speed.x110,
                "1.15" => SpeakV2Speed.x115,
                _ => null,
            };
        }
    }
}