
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2InterruptType
    {
        /// <summary>
        ///
        /// </summary>
        Interrupt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2InterruptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2InterruptType value)
        {
            return value switch
            {
                SpeakV2SpeakV2InterruptType.Interrupt => "Interrupt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2InterruptType? ToEnum(string value)
        {
            return value switch
            {
                "Interrupt" => SpeakV2SpeakV2InterruptType.Interrupt,
                _ => null,
            };
        }
    }
}