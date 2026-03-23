
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Eleven Labs model ID
    /// </summary>
    public enum ElevenLabsSpeakProviderModelId
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenMonolingualV1,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenTurboV25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsSpeakProviderModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsSpeakProviderModelId value)
        {
            return value switch
            {
                ElevenLabsSpeakProviderModelId.ElevenMonolingualV1 => "eleven_monolingual_v1",
                ElevenLabsSpeakProviderModelId.ElevenMultilingualV2 => "eleven_multilingual_v2",
                ElevenLabsSpeakProviderModelId.ElevenTurboV25 => "eleven_turbo_v2_5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsSpeakProviderModelId? ToEnum(string value)
        {
            return value switch
            {
                "eleven_monolingual_v1" => ElevenLabsSpeakProviderModelId.ElevenMonolingualV1,
                "eleven_multilingual_v2" => ElevenLabsSpeakProviderModelId.ElevenMultilingualV2,
                "eleven_turbo_v2_5" => ElevenLabsSpeakProviderModelId.ElevenTurboV25,
                _ => null,
            };
        }
    }
}