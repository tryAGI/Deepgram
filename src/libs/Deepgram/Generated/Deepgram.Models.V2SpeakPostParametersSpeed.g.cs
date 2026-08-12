
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum V2SpeakPostParametersSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        x085,
        /// <summary>
        /// 
        /// </summary>
        x09,
        /// <summary>
        /// 
        /// </summary>
        x095,
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        x105,
        /// <summary>
        /// 
        /// </summary>
        x11,
        /// <summary>
        /// 
        /// </summary>
        x115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersSpeed value)
        {
            return value switch
            {
                V2SpeakPostParametersSpeed.x085 => "0.85",
                V2SpeakPostParametersSpeed.x09 => "0.9",
                V2SpeakPostParametersSpeed.x095 => "0.95",
                V2SpeakPostParametersSpeed.x1 => "1",
                V2SpeakPostParametersSpeed.x105 => "1.05",
                V2SpeakPostParametersSpeed.x11 => "1.1",
                V2SpeakPostParametersSpeed.x115 => "1.15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersSpeed? ToEnum(string value)
        {
            return value switch
            {
                "0.85" => V2SpeakPostParametersSpeed.x085,
                "0.9" => V2SpeakPostParametersSpeed.x09,
                "0.95" => V2SpeakPostParametersSpeed.x095,
                "1" => V2SpeakPostParametersSpeed.x1,
                "1.05" => V2SpeakPostParametersSpeed.x105,
                "1.1" => V2SpeakPostParametersSpeed.x11,
                "1.15" => V2SpeakPostParametersSpeed.x115,
                _ => null,
            };
        }
    }
}