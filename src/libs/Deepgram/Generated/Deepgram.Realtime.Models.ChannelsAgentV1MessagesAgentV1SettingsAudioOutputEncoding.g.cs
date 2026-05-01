
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio encoding format for streaming TTS output<br/>
    /// Default Value: linear16
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Aac => "aac",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Alaw => "alaw",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Flac => "flac",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Linear16 => "linear16",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Mp3 => "mp3",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Mulaw => "mulaw",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Opus => "opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding? ToEnum(string value)
        {
            return value switch
            {
                "aac" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Aac,
                "alaw" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Alaw,
                "flac" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Flac,
                "linear16" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Linear16,
                "mp3" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Mp3,
                "mulaw" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Mulaw,
                "opus" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Opus,
                _ => null,
            };
        }
    }
}