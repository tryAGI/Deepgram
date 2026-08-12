
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2ConfigureFailureType
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigureFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2ConfigureFailureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2ConfigureFailureType value)
        {
            return value switch
            {
                SpeakV2SpeakV2ConfigureFailureType.ConfigureFailure => "ConfigureFailure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2ConfigureFailureType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureFailure" => SpeakV2SpeakV2ConfigureFailureType.ConfigureFailure,
                _ => null,
            };
        }
    }
}