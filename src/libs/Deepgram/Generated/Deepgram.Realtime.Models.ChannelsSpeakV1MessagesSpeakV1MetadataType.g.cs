
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1MetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV1MessagesSpeakV1MetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1MetadataType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1MetadataType.Metadata => "Metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1MetadataType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => ChannelsSpeakV1MessagesSpeakV1MetadataType.Metadata,
                _ => null,
            };
        }
    }
}