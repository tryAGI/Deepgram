
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio encoding format<br/>
    /// Default Value: linear16
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Alaw,
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
        Flac,
        /// <summary>
        /// 
        /// </summary>
        G729,
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
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Speex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Alaw => "alaw",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.AmrNb => "amr-nb",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.AmrWb => "amr-wb",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Flac => "flac",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.G729 => "g729",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Linear16 => "linear16",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Linear32 => "linear32",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Mulaw => "mulaw",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.OggOpus => "ogg-opus",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Opus => "opus",
                ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Speex => "speex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding? ToEnum(string value)
        {
            return value switch
            {
                "alaw" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Alaw,
                "amr-nb" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.AmrNb,
                "amr-wb" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.AmrWb,
                "flac" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Flac,
                "g729" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.G729,
                "linear16" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Linear16,
                "linear32" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Linear32,
                "mulaw" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Mulaw,
                "ogg-opus" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.OggOpus,
                "opus" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Opus,
                "speex" => ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding.Speex,
                _ => null,
            };
        }
    }
}