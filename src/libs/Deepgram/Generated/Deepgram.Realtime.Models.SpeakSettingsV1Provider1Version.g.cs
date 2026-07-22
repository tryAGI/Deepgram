
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Selects the Deepgram Flux TTS model family
    /// </summary>
    public enum SpeakSettingsV1Provider1Version
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakSettingsV1Provider1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakSettingsV1Provider1Version value)
        {
            return value switch
            {
                SpeakSettingsV1Provider1Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakSettingsV1Provider1Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => SpeakSettingsV1Provider1Version.V2,
                _ => null,
            };
        }
    }
}