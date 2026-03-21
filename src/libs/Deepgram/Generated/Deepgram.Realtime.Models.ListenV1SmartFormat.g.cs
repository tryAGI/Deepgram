
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1SmartFormat
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1SmartFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1SmartFormat value)
        {
            return value switch
            {
                ListenV1SmartFormat.True => "true",
                ListenV1SmartFormat.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1SmartFormat? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1SmartFormat.True,
                "false" => ListenV1SmartFormat.False,
                _ => null,
            };
        }
    }
}