
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1ClearedType
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
    public static class ChannelsSpeakV1MessagesSpeakV1ClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1ClearedType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1ClearedType.Cleared => "Cleared",
                ChannelsSpeakV1MessagesSpeakV1ClearedType.Flushed => "Flushed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1ClearedType? ToEnum(string value)
        {
            return value switch
            {
                "Cleared" => ChannelsSpeakV1MessagesSpeakV1ClearedType.Cleared,
                "Flushed" => ChannelsSpeakV1MessagesSpeakV1ClearedType.Flushed,
                _ => null,
            };
        }
    }
}