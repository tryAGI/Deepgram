
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The configuration field the failure is about. Absent when the failure is not tied to one field.
    /// </summary>
    public enum ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField
    {
        /// <summary>
        ///
        /// </summary>
        Speed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV2MessagesSpeakV2ConfigureFailureFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField value)
        {
            return value switch
            {
                ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField.Speed => "speed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField? ToEnum(string value)
        {
            return value switch
            {
                "speed" => ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField.Speed,
                _ => null,
            };
        }
    }
}