
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1UpdateListen
    {
        /// <summary>
        /// Message type identifier for updating the listen configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateListenTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1UpdateListenType Type { get; set; }

        /// <summary>
        /// Listen configuration to update. Contains a provider object with the same schema as Settings. The provider identity (type, version, model) is required and must match the current session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateListenListen Listen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateListen" /> class.
        /// </summary>
        /// <param name="listen">
        /// Listen configuration to update. Contains a provider object with the same schema as Settings. The provider identity (type, version, model) is required and must match the current session.
        /// </param>
        /// <param name="type">
        /// Message type identifier for updating the listen configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1UpdateListen(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateListenListen listen,
            global::Deepgram.Realtime.AgentV1AgentV1UpdateListenType type)
        {
            this.Type = type;
            this.Listen = listen ?? throw new global::System.ArgumentNullException(nameof(listen));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateListen" /> class.
        /// </summary>
        public AgentV1AgentV1UpdateListen()
        {
        }

    }
}