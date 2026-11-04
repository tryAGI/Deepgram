
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Replaces keyterms and other user-supplied text with `[REDACTED]` in this connection's usage records, including keyterms sent in later Configure messages. Does not affect transcription, the response, or `tag`. Independent of `mip_opt_out`. https://developers.deepgram.com/docs/redact-usage<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV2RedactUsage
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
    public static class ListenV2RedactUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2RedactUsage value)
        {
            return value switch
            {
                ListenV2RedactUsage.False => "false",
                ListenV2RedactUsage.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2RedactUsage? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListenV2RedactUsage.False,
                "true" => ListenV2RedactUsage.True,
                _ => null,
            };
        }
    }
}