
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specifies usage of the V2 Deepgram speech-to-text API (e.g. Flux)
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version.V2,
                _ => null,
            };
        }
    }
}