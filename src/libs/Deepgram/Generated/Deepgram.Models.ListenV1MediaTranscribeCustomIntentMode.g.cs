
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Default Value: extended
    /// </summary>
    public enum ListenV1MediaTranscribeCustomIntentMode
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
    public static class ListenV1MediaTranscribeCustomIntentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeCustomIntentMode value)
        {
            return value switch
            {
                ListenV1MediaTranscribeCustomIntentMode.Extended => "extended",
                ListenV1MediaTranscribeCustomIntentMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeCustomIntentMode? ToEnum(string value)
        {
            return value switch
            {
                "extended" => ListenV1MediaTranscribeCustomIntentMode.Extended,
                "strict" => ListenV1MediaTranscribeCustomIntentMode.Strict,
                _ => null,
            };
        }
    }
}