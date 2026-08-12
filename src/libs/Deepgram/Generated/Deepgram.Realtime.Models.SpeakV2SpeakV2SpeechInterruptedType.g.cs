
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2SpeechInterruptedType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechInterrupted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2SpeechInterruptedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2SpeechInterruptedType value)
        {
            return value switch
            {
                SpeakV2SpeakV2SpeechInterruptedType.SpeechInterrupted => "SpeechInterrupted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2SpeechInterruptedType? ToEnum(string value)
        {
            return value switch
            {
                "SpeechInterrupted" => SpeakV2SpeakV2SpeechInterruptedType.SpeechInterrupted,
                _ => null,
            };
        }
    }
}