
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Defaults to `false`. Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1Diarize
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
    public static class ListenV1DiarizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Diarize value)
        {
            return value switch
            {
                ListenV1Diarize.True => "true",
                ListenV1Diarize.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Diarize? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1Diarize.True,
                "false" => ListenV1Diarize.False,
                _ => null,
            };
        }
    }
}