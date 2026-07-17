
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Numerals converts numbers from written format to numerical format<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV2Numerals
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
    public static class ListenV2NumeralsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2Numerals value)
        {
            return value switch
            {
                ListenV2Numerals.False => "false",
                ListenV2Numerals.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2Numerals? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListenV2Numerals.False,
                "true" => ListenV2Numerals.True,
                _ => null,
            };
        }
    }
}