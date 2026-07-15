
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2SpeechMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2SpeechMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2SpeechMetadataType value)
        {
            return value switch
            {
                SpeakV2SpeakV2SpeechMetadataType.SpeechMetadata => "SpeechMetadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2SpeechMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "SpeechMetadata" => SpeakV2SpeakV2SpeechMetadataType.SpeechMetadata,
                _ => null,
            };
        }
    }
}