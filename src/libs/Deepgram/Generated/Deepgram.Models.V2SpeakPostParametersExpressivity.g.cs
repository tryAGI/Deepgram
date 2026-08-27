
#nullable enable

namespace Deepgram
{
    /// <summary>
    ///
    /// </summary>
    public enum V2SpeakPostParametersExpressivity
    {
        /// <summary>
        ///
        /// </summary>
        Minus1,
        /// <summary>
        ///
        /// </summary>
        Minus2,
        /// <summary>
        ///
        /// </summary>
        x0,
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        x2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersExpressivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersExpressivity value)
        {
            return value switch
            {
                V2SpeakPostParametersExpressivity.Minus1 => "-1",
                V2SpeakPostParametersExpressivity.Minus2 => "-2",
                V2SpeakPostParametersExpressivity.x0 => "0",
                V2SpeakPostParametersExpressivity.x1 => "1",
                V2SpeakPostParametersExpressivity.x2 => "2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersExpressivity? ToEnum(string value)
        {
            return value switch
            {
                "-1" => V2SpeakPostParametersExpressivity.Minus1,
                "-2" => V2SpeakPostParametersExpressivity.Minus2,
                "0" => V2SpeakPostParametersExpressivity.x0,
                "1" => V2SpeakPostParametersExpressivity.x1,
                "2" => V2SpeakPostParametersExpressivity.x2,
                _ => null,
            };
        }
    }
}