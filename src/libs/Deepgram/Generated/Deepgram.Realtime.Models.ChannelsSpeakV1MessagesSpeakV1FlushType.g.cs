
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1FlushType
    {
        /// <summary>
        /// 
        /// </summary>
        Clear,
        /// <summary>
        /// 
        /// </summary>
        Close,
        /// <summary>
        /// 
        /// </summary>
        Flush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV1MessagesSpeakV1FlushTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1FlushType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1FlushType.Clear => "Clear",
                ChannelsSpeakV1MessagesSpeakV1FlushType.Close => "Close",
                ChannelsSpeakV1MessagesSpeakV1FlushType.Flush => "Flush",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1FlushType? ToEnum(string value)
        {
            return value switch
            {
                "Clear" => ChannelsSpeakV1MessagesSpeakV1FlushType.Clear,
                "Close" => ChannelsSpeakV1MessagesSpeakV1FlushType.Close,
                "Flush" => ChannelsSpeakV1MessagesSpeakV1FlushType.Flush,
                _ => null,
            };
        }
    }
}