
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2SessionMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2SessionMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2SessionMetadataType value)
        {
            return value switch
            {
                SpeakV2SpeakV2SessionMetadataType.SessionMetadata => "SessionMetadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2SessionMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "SessionMetadata" => SpeakV2SpeakV2SessionMetadataType.SessionMetadata,
                _ => null,
            };
        }
    }
}