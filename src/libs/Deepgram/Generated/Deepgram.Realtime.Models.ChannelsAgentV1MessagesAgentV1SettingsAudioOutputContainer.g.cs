
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Audio container format.<br/>
    /// Default Value: none
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer.None => "none",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer.Ogg => "ogg",
                ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer? ToEnum(string value)
        {
            return value switch
            {
                "none" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer.None,
                "ogg" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer.Ogg,
                "wav" => ChannelsAgentV1MessagesAgentV1SettingsAudioOutputContainer.Wav,
                _ => null,
            };
        }
    }
}