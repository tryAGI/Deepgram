
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeakV1ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                SpeakV1ServerEventDiscriminatorMessageType.Metadata => "Metadata",
                SpeakV1ServerEventDiscriminatorMessageType.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => SpeakV1ServerEventDiscriminatorMessageType.Metadata,
                "Warning" => SpeakV1ServerEventDiscriminatorMessageType.Warning,
                _ => null,
            };
        }
    }
}