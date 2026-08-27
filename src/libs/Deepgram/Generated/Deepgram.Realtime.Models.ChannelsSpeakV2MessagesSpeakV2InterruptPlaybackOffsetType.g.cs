
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Offset unit. `time_ms` is the only supported form.
    /// </summary>
    public enum ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType
    {
        /// <summary>
        ///
        /// </summary>
        TimeMs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType value)
        {
            return value switch
            {
                ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType.TimeMs => "time_ms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType? ToEnum(string value)
        {
            return value switch
            {
                "time_ms" => ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType.TimeMs,
                _ => null,
            };
        }
    }
}