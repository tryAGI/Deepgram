
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
        AggressiveNumbers,
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        Numbers,
        /// <summary>
        /// 
        /// </summary>
        Pci,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
        /// <summary>
        /// 
        /// </summary>
        True,
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
                ListenV1Redact.AggressiveNumbers => "aggressive_numbers",
                ListenV1Redact.False => "false",
                ListenV1Redact.Numbers => "numbers",
                ListenV1Redact.Pci => "pci",
                ListenV1Redact.Ssn => "ssn",
                ListenV1Redact.True => "true",
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
                "aggressive_numbers" => ListenV1Redact.AggressiveNumbers,
                "false" => ListenV1Redact.False,
                "numbers" => ListenV1Redact.Numbers,
                "pci" => ListenV1Redact.Pci,
                "ssn" => ListenV1Redact.Ssn,
                "true" => ListenV1Redact.True,
                _ => null,
            };
        }
    }
}