
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ResultsPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Results,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResultsPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResultsPayloadType value)
        {
            return value switch
            {
                ResultsPayloadType.Results => "Results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResultsPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "Results" => ResultsPayloadType.Results,
                _ => null,
            };
        }
    }
}