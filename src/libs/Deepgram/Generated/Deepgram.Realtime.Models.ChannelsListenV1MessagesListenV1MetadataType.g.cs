
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1MetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1MetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1MetadataType value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1MetadataType.Metadata => "Metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1MetadataType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => ChannelsListenV1MessagesListenV1MetadataType.Metadata,
                _ => null,
            };
        }
    }
}