
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV1MetadataEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1MetadataEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1MetadataEventType value)
        {
            return value switch
            {
                SpeakV1MetadataEventType.Metadata => "Metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1MetadataEventType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => SpeakV1MetadataEventType.Metadata,
                _ => null,
            };
        }
    }
}