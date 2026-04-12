
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1FlushedType
    {
        /// <summary>
        /// 
        /// </summary>
        Cleared,
        /// <summary>
        /// 
        /// </summary>
        Flushed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV1MessagesSpeakV1FlushedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1FlushedType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1FlushedType.Cleared => "Cleared",
                ChannelsSpeakV1MessagesSpeakV1FlushedType.Flushed => "Flushed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1FlushedType? ToEnum(string value)
        {
            return value switch
            {
                "Cleared" => ChannelsSpeakV1MessagesSpeakV1FlushedType.Cleared,
                "Flushed" => ChannelsSpeakV1MessagesSpeakV1FlushedType.Flushed,
                _ => null,
            };
        }
    }
}