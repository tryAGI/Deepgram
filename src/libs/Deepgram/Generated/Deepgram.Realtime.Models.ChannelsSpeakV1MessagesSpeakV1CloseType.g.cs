
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1CloseType
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
    public static class ChannelsSpeakV1MessagesSpeakV1CloseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1CloseType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1CloseType.Clear => "Clear",
                ChannelsSpeakV1MessagesSpeakV1CloseType.Close => "Close",
                ChannelsSpeakV1MessagesSpeakV1CloseType.Flush => "Flush",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1CloseType? ToEnum(string value)
        {
            return value switch
            {
                "Clear" => ChannelsSpeakV1MessagesSpeakV1CloseType.Clear,
                "Close" => ChannelsSpeakV1MessagesSpeakV1CloseType.Close,
                "Flush" => ChannelsSpeakV1MessagesSpeakV1CloseType.Flush,
                _ => null,
            };
        }
    }
}