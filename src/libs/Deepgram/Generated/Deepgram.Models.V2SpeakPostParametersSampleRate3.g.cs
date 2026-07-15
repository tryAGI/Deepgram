
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Encoding - flac. Supported sample rates - 8000, 16000, 22050, 32000, 48000 Hz.
    /// </summary>
    public enum V2SpeakPostParametersSampleRate3
    {
        /// <summary>
        /// 
        /// </summary>
        x16000,
        /// <summary>
        /// 
        /// </summary>
        x22050,
        /// <summary>
        /// 
        /// </summary>
        x32000,
        /// <summary>
        /// 
        /// </summary>
        x48000,
        /// <summary>
        /// 
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SpeakPostParametersSampleRate3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SpeakPostParametersSampleRate3 value)
        {
            return value switch
            {
                V2SpeakPostParametersSampleRate3.x16000 => "16000",
                V2SpeakPostParametersSampleRate3.x22050 => "22050",
                V2SpeakPostParametersSampleRate3.x32000 => "32000",
                V2SpeakPostParametersSampleRate3.x48000 => "48000",
                V2SpeakPostParametersSampleRate3.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SpeakPostParametersSampleRate3? ToEnum(string value)
        {
            return value switch
            {
                "16000" => V2SpeakPostParametersSampleRate3.x16000,
                "22050" => V2SpeakPostParametersSampleRate3.x22050,
                "32000" => V2SpeakPostParametersSampleRate3.x32000,
                "48000" => V2SpeakPostParametersSampleRate3.x48000,
                "8000" => V2SpeakPostParametersSampleRate3.x8000,
                _ => null,
            };
        }
    }
}