
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2ConnectedType
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2ConnectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2ConnectedType value)
        {
            return value switch
            {
                SpeakV2SpeakV2ConnectedType.Connected => "Connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2ConnectedType? ToEnum(string value)
        {
            return value switch
            {
                "Connected" => SpeakV2SpeakV2ConnectedType.Connected,
                _ => null,
            };
        }
    }
}