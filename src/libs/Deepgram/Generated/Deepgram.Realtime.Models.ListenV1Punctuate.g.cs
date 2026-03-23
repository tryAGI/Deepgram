
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Add punctuation and capitalization to the transcript<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1Punctuate
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
    public static class ListenV1PunctuateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Punctuate value)
        {
            return value switch
            {
                ListenV1Punctuate.False => "false",
                ListenV1Punctuate.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Punctuate? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListenV1Punctuate.False,
                "true" => ListenV1Punctuate.True,
                _ => null,
            };
        }
    }
}