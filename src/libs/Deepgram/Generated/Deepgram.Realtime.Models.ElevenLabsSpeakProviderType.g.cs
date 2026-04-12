
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElevenLabsSpeakProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenLabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsSpeakProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsSpeakProviderType value)
        {
            return value switch
            {
                ElevenLabsSpeakProviderType.ElevenLabs => "eleven_labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsSpeakProviderType? ToEnum(string value)
        {
            return value switch
            {
                "eleven_labs" => ElevenLabsSpeakProviderType.ElevenLabs,
                _ => null,
            };
        }
    }
}