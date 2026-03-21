
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Convert numbers from written format to numerical format<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1Numerals
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
    public static class ListenV1NumeralsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Numerals value)
        {
            return value switch
            {
                ListenV1Numerals.True => "true",
                ListenV1Numerals.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Numerals? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1Numerals.True,
                "false" => ListenV1Numerals.False,
                _ => null,
            };
        }
    }
}