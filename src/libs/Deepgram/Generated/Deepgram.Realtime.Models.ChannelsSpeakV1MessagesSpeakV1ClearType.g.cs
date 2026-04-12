
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1ClearType
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
    public static class ChannelsSpeakV1MessagesSpeakV1ClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1ClearType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1ClearType.Clear => "Clear",
                ChannelsSpeakV1MessagesSpeakV1ClearType.Close => "Close",
                ChannelsSpeakV1MessagesSpeakV1ClearType.Flush => "Flush",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1ClearType? ToEnum(string value)
        {
            return value switch
            {
                "Clear" => ChannelsSpeakV1MessagesSpeakV1ClearType.Clear,
                "Close" => ChannelsSpeakV1MessagesSpeakV1ClearType.Close,
                "Flush" => ChannelsSpeakV1MessagesSpeakV1ClearType.Flush,
                _ => null,
            };
        }
    }
}