
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2ConfigureType
    {
        /// <summary>
        /// 
        /// </summary>
        Configure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2ConfigureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2ConfigureType value)
        {
            return value switch
            {
                SpeakV2SpeakV2ConfigureType.Configure => "Configure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2ConfigureType? ToEnum(string value)
        {
            return value switch
            {
                "Configure" => SpeakV2SpeakV2ConfigureType.Configure,
                _ => null,
            };
        }
    }
}