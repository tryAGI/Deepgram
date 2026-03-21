
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the ElevenLabs text-to-speech API
    /// </summary>
    public enum ElevenLabsSpeakProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsSpeakProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsSpeakProviderVersion value)
        {
            return value switch
            {
                ElevenLabsSpeakProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsSpeakProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => ElevenLabsSpeakProviderVersion.V1,
                _ => null,
            };
        }
    }
}