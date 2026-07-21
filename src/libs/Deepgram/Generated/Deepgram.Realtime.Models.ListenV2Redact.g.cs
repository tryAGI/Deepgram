
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Redaction removes sensitive information from your transcripts. On Flux, only `numbers` and `aggressive_numbers` are supported.
    /// </summary>
    public enum ListenV2Redact
    {
        /// <summary>
        /// 
        /// </summary>
        AggressiveNumbers,
        /// <summary>
        /// 
        /// </summary>
        Numbers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2RedactExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2Redact value)
        {
            return value switch
            {
                ListenV2Redact.AggressiveNumbers => "aggressive_numbers",
                ListenV2Redact.Numbers => "numbers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2Redact? ToEnum(string value)
        {
            return value switch
            {
                "aggressive_numbers" => ListenV2Redact.AggressiveNumbers,
                "numbers" => ListenV2Redact.Numbers,
                _ => null,
            };
        }
    }
}