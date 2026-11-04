
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Replaces the values of user-supplied text parameters (`keyterm`, `keywords`, `replace`, `search`, and `extra`) with `[REDACTED]` in this request's usage records. Does not affect transcription, the response, or `tag`. Independent of `mip_opt_out`. https://developers.deepgram.com/docs/redact-usage<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1RedactUsage
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
    public static class ListenV1RedactUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1RedactUsage value)
        {
            return value switch
            {
                ListenV1RedactUsage.False => "false",
                ListenV1RedactUsage.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1RedactUsage? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListenV1RedactUsage.False,
                "true" => ListenV1RedactUsage.True,
                _ => null,
            };
        }
    }
}