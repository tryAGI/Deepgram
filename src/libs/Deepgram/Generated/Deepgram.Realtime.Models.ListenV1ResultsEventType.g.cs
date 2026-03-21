
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV1ResultsEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Results,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ResultsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ResultsEventType value)
        {
            return value switch
            {
                ListenV1ResultsEventType.Results => "Results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ResultsEventType? ToEnum(string value)
        {
            return value switch
            {
                "Results" => ListenV1ResultsEventType.Results,
                _ => null,
            };
        }
    }
}