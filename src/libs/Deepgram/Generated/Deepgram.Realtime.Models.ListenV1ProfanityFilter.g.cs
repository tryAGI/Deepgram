
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1ProfanityFilter
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
    public static class ListenV1ProfanityFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ProfanityFilter value)
        {
            return value switch
            {
                ListenV1ProfanityFilter.True => "true",
                ListenV1ProfanityFilter.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ProfanityFilter? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1ProfanityFilter.True,
                "false" => ListenV1ProfanityFilter.False,
                _ => null,
            };
        }
    }
}