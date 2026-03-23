
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
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
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
                ListenV1Diarize.False => "false",
                ListenV1Diarize.True => "true",
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
                "false" => ListenV1Diarize.False,
                "true" => ListenV1Diarize.True,
                _ => null,
            };
        }
    }
}