
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ChannelsSpeakV1MessagesSpeakV1TextType
    {
        /// <summary>
        /// 
        /// </summary>
        Speak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV1MessagesSpeakV1TextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV1MessagesSpeakV1TextType value)
        {
            return value switch
            {
                ChannelsSpeakV1MessagesSpeakV1TextType.Speak => "Speak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV1MessagesSpeakV1TextType? ToEnum(string value)
        {
            return value switch
            {
                "Speak" => ChannelsSpeakV1MessagesSpeakV1TextType.Speak,
                _ => null,
            };
        }
    }
}