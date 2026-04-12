
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - opus. Sample rate is fixed at 48000 Hz.
    /// </summary>
    public enum V1SpeakPostParametersSampleRate4
    {
        /// <summary>
        /// 
        /// </summary>
        x48000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1SpeakPostParametersSampleRate4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1SpeakPostParametersSampleRate4 value)
        {
            return value switch
            {
                V1SpeakPostParametersSampleRate4.x48000 => "48000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1SpeakPostParametersSampleRate4? ToEnum(string value)
        {
            return value switch
            {
                "48000" => V1SpeakPostParametersSampleRate4.x48000,
                _ => null,
            };
        }
    }
}