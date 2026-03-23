
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Identify and extract key entities from content in submitted audio<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1Dictation
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
    public static class ListenV1DictationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Dictation value)
        {
            return value switch
            {
                ListenV1Dictation.False => "false",
                ListenV1Dictation.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Dictation? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListenV1Dictation.False,
                "true" => ListenV1Dictation.True,
                _ => null,
            };
        }
    }
}