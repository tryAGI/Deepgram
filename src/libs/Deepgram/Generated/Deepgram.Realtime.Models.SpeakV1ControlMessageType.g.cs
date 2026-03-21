
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV1ControlMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Flush,
        /// <summary>
        /// 
        /// </summary>
        Clear,
        /// <summary>
        /// 
        /// </summary>
        Close,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1ControlMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1ControlMessageType value)
        {
            return value switch
            {
                SpeakV1ControlMessageType.Flush => "Flush",
                SpeakV1ControlMessageType.Clear => "Clear",
                SpeakV1ControlMessageType.Close => "Close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1ControlMessageType? ToEnum(string value)
        {
            return value switch
            {
                "Flush" => SpeakV1ControlMessageType.Flush,
                "Clear" => SpeakV1ControlMessageType.Clear,
                "Close" => SpeakV1ControlMessageType.Close,
                _ => null,
            };
        }
    }
}