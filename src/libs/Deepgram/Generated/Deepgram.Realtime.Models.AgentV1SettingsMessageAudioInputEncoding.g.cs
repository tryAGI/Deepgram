
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio encoding format<br/>
    /// Default Value: linear16
    /// </summary>
    public enum AgentV1SettingsMessageAudioInputEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Linear32,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        AmrNb,
        /// <summary>
        /// 
        /// </summary>
        AmrWb,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
        /// <summary>
        /// 
        /// </summary>
        Speex,
        /// <summary>
        /// 
        /// </summary>
        G729,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1SettingsMessageAudioInputEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1SettingsMessageAudioInputEncoding value)
        {
            return value switch
            {
                AgentV1SettingsMessageAudioInputEncoding.Linear16 => "linear16",
                AgentV1SettingsMessageAudioInputEncoding.Linear32 => "linear32",
                AgentV1SettingsMessageAudioInputEncoding.Flac => "flac",
                AgentV1SettingsMessageAudioInputEncoding.Alaw => "alaw",
                AgentV1SettingsMessageAudioInputEncoding.Mulaw => "mulaw",
                AgentV1SettingsMessageAudioInputEncoding.AmrNb => "amr-nb",
                AgentV1SettingsMessageAudioInputEncoding.AmrWb => "amr-wb",
                AgentV1SettingsMessageAudioInputEncoding.Opus => "opus",
                AgentV1SettingsMessageAudioInputEncoding.OggOpus => "ogg-opus",
                AgentV1SettingsMessageAudioInputEncoding.Speex => "speex",
                AgentV1SettingsMessageAudioInputEncoding.G729 => "g729",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1SettingsMessageAudioInputEncoding? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => AgentV1SettingsMessageAudioInputEncoding.Linear16,
                "linear32" => AgentV1SettingsMessageAudioInputEncoding.Linear32,
                "flac" => AgentV1SettingsMessageAudioInputEncoding.Flac,
                "alaw" => AgentV1SettingsMessageAudioInputEncoding.Alaw,
                "mulaw" => AgentV1SettingsMessageAudioInputEncoding.Mulaw,
                "amr-nb" => AgentV1SettingsMessageAudioInputEncoding.AmrNb,
                "amr-wb" => AgentV1SettingsMessageAudioInputEncoding.AmrWb,
                "opus" => AgentV1SettingsMessageAudioInputEncoding.Opus,
                "ogg-opus" => AgentV1SettingsMessageAudioInputEncoding.OggOpus,
                "speex" => AgentV1SettingsMessageAudioInputEncoding.Speex,
                "g729" => AgentV1SettingsMessageAudioInputEncoding.G729,
                _ => null,
            };
        }
    }
}