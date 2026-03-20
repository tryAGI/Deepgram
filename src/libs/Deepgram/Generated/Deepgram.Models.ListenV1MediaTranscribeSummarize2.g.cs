
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1MediaTranscribeSummarize2
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1MediaTranscribeSummarize2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeSummarize2 value)
        {
            return value switch
            {
                ListenV1MediaTranscribeSummarize2.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeSummarize2? ToEnum(string value)
        {
            return value switch
            {
                "v2" => ListenV1MediaTranscribeSummarize2.V2,
                _ => null,
            };
        }
    }
}