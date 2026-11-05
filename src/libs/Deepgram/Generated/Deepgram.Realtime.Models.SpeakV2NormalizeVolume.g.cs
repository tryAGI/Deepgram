
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Normalizes the loudness of the generated speech to a consistent level across voices and turns. On by default; set to `false` to opt out. Peak  limiting is applied either way.<br/>
    /// Default Value: true
    /// </summary>
    public enum SpeakV2NormalizeVolume
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV2NormalizeVolumeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV2NormalizeVolume value)
        {
            return value switch
            {
                SpeakV2NormalizeVolume.False => "false",
                SpeakV2NormalizeVolume.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV2NormalizeVolume? ToEnum(string value)
        {
            return value switch
            {
                "false" => SpeakV2NormalizeVolume.False,
                "true" => SpeakV2NormalizeVolume.True,
                _ => null,
            };
        }
    }
}