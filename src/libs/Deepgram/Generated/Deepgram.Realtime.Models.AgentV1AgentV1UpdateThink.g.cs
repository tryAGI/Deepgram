
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1UpdateThink
    {
        /// <summary>
        /// Message type identifier for updating the think model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateThinkTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1UpdateThinkType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("think")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1UpdateThinkThinkJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateThinkThink Think { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateThink" /> class.
        /// </summary>
        /// <param name="think"></param>
        /// <param name="type">
        /// Message type identifier for updating the think model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1UpdateThink(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateThinkThink think,
            global::Deepgram.Realtime.AgentV1AgentV1UpdateThinkType type)
        {
            this.Type = type;
            this.Think = think;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateThink" /> class.
        /// </summary>
        public AgentV1AgentV1UpdateThink()
        {
        }

    }
}