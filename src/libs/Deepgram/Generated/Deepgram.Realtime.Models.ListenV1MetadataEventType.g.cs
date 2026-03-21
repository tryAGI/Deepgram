
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV1MetadataEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1MetadataEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1MetadataEventType value)
        {
            return value switch
            {
                ListenV1MetadataEventType.Metadata => "Metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1MetadataEventType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => ListenV1MetadataEventType.Metadata,
                _ => null,
            };
        }
    }
}