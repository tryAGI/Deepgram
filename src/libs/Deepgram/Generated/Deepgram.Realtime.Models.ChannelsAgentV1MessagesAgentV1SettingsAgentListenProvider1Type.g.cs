
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Provider type for speech-to-text
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type.Deepgram,
                _ => null,
            };
        }
    }
}