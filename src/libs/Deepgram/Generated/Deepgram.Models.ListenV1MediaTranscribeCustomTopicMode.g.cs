
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum ListenV1MediaTranscribeCustomTopicMode
    {
        /// <summary>
        /// 
        /// </summary>
        Extended,
        /// <summary>
        /// 
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1MediaTranscribeCustomTopicModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeCustomTopicMode value)
        {
            return value switch
            {
                ListenV1MediaTranscribeCustomTopicMode.Extended => "extended",
                ListenV1MediaTranscribeCustomTopicMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeCustomTopicMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => ListenV1MediaTranscribeCustomTopicMode.Extended,
                "strict" => ListenV1MediaTranscribeCustomTopicMode.Strict,
                _ => null,
            };
        }
    }
}