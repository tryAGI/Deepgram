
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Provider type for text-to-speech
    /// </summary>
    public enum SpeakSettingsV1Provider1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakSettingsV1Provider1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakSettingsV1Provider1Type value)
        {
            return value switch
            {
                SpeakSettingsV1Provider1Type.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakSettingsV1Provider1Type? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => SpeakSettingsV1Provider1Type.Deepgram,
                _ => null,
            };
        }
    }
}