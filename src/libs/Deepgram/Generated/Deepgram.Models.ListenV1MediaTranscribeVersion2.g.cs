
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Use the latest version of a model
    /// </summary>
    public enum ListenV1MediaTranscribeVersion2
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1MediaTranscribeVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MediaTranscribeVersion2 value)
        {
            return value switch
            {
                ListenV1MediaTranscribeVersion2.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MediaTranscribeVersion2? ToEnum(string value)
        {
            return value switch
            {
                "latest" => ListenV1MediaTranscribeVersion2.Latest,
                _ => null,
            };
        }
    }
}