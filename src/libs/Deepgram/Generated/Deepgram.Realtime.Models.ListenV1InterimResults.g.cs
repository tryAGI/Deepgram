
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specifies whether the streaming endpoint should provide ongoing transcription updates as more audio is received. When set to true, the endpoint sends continuous updates, meaning transcription results may evolve over time<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1InterimResults
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1InterimResultsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1InterimResults value)
        {
            return value switch
            {
                ListenV1InterimResults.False => "false",
                ListenV1InterimResults.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1InterimResults? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListenV1InterimResults.False,
                "true" => ListenV1InterimResults.True,
                _ => null,
            };
        }
    }
}