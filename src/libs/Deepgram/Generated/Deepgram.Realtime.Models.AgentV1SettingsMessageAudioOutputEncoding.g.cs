
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio encoding format for streaming TTS output<br/>
    /// Default Value: linear16
    /// </summary>
    public enum AgentV1SettingsMessageAudioOutputEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1SettingsMessageAudioOutputEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1SettingsMessageAudioOutputEncoding value)
        {
            return value switch
            {
                AgentV1SettingsMessageAudioOutputEncoding.Linear16 => "linear16",
                AgentV1SettingsMessageAudioOutputEncoding.Mulaw => "mulaw",
                AgentV1SettingsMessageAudioOutputEncoding.Alaw => "alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1SettingsMessageAudioOutputEncoding? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => AgentV1SettingsMessageAudioOutputEncoding.Linear16,
                "mulaw" => AgentV1SettingsMessageAudioOutputEncoding.Mulaw,
                "alaw" => AgentV1SettingsMessageAudioOutputEncoding.Alaw,
                _ => null,
            };
        }
    }
}