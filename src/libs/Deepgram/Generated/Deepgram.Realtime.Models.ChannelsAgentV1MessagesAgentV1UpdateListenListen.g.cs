
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Listen configuration to update. Contains a provider object with the same schema as Settings. The model and language can be changed mid-session. Keyterms can only be updated mid-session for Flux models.
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1UpdateListenListen
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1UpdateListenListenProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateListenListenProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1UpdateListenListen" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1UpdateListenListen(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateListenListenProvider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1UpdateListenListen" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1UpdateListenListen()
        {
        }

    }
}