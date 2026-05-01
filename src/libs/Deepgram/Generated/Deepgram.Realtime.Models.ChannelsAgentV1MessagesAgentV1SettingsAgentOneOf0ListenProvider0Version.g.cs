
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specifies usage of the V1 Deepgram speech-to-text API
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version? ToEnum(string value)
        {
            return value switch
            {
                "v1" => ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0Version.V1,
                _ => null,
            };
        }
    }
}