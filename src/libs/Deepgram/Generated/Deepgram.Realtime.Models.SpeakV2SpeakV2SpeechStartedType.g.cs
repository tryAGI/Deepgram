
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2SpeechStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2SpeechStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2SpeechStartedType value)
        {
            return value switch
            {
                SpeakV2SpeakV2SpeechStartedType.SpeechStarted => "SpeechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2SpeechStartedType? ToEnum(string value)
        {
            return value switch
            {
                "SpeechStarted" => SpeakV2SpeakV2SpeechStartedType.SpeechStarted,
                _ => null,
            };
        }
    }
}