
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Redaction removes sensitive information from your transcripts<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1Redact
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        Pci,
        /// <summary>
        /// 
        /// </summary>
        Numbers,
        /// <summary>
        /// 
        /// </summary>
        AggressiveNumbers,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1RedactExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Redact value)
        {
            return value switch
            {
                ListenV1Redact.True => "true",
                ListenV1Redact.False => "false",
                ListenV1Redact.Pci => "pci",
                ListenV1Redact.Numbers => "numbers",
                ListenV1Redact.AggressiveNumbers => "aggressive_numbers",
                ListenV1Redact.Ssn => "ssn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Redact? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1Redact.True,
                "false" => ListenV1Redact.False,
                "pci" => ListenV1Redact.Pci,
                "numbers" => ListenV1Redact.Numbers,
                "aggressive_numbers" => ListenV1Redact.AggressiveNumbers,
                "ssn" => ListenV1Redact.Ssn,
                _ => null,
            };
        }
    }
}