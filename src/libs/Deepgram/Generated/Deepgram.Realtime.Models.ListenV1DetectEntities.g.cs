
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Identifies and extracts key entities from content in submitted audio. Entities appear in final results. When enabled, Punctuation will also be enabled by default<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1DetectEntities
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
    public static class ListenV1DetectEntitiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1DetectEntities value)
        {
            return value switch
            {
                ListenV1DetectEntities.True => "true",
                ListenV1DetectEntities.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1DetectEntities? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1DetectEntities.True,
                "false" => ListenV1DetectEntities.False,
                _ => null,
            };
        }
    }
}