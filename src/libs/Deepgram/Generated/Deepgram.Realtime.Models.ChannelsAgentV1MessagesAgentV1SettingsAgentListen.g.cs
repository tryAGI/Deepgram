
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAgentListen
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProviderJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentListen" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAgentListen(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentListen" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentListen()
        {
        }
    }
}