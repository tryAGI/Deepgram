
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum SpeakV2SpeakV2ConfigureSuccessType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigureSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2SpeakV2ConfigureSuccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2SpeakV2ConfigureSuccessType value)
        {
            return value switch
            {
                SpeakV2SpeakV2ConfigureSuccessType.ConfigureSuccess => "ConfigureSuccess",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2SpeakV2ConfigureSuccessType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureSuccess" => SpeakV2SpeakV2ConfigureSuccessType.ConfigureSuccess,
                _ => null,
            };
        }
    }
}