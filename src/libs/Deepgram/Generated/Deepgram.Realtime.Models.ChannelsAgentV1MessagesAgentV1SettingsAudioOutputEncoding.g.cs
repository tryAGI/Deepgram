
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
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
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
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Alaw => "alaw",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Linear16 => "linear16",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Mulaw => "mulaw",
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
                "alaw" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Alaw,
                "linear16" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Linear16,
                "mulaw" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding.Mulaw,
                _ => null,
            };
        }
    }
}