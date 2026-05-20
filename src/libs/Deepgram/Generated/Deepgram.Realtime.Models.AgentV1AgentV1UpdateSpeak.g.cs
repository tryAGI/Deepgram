
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1UpdateSpeak
    {
        /// <summary>
        /// Message type identifier for updating the speak model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateSpeakTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1UpdateSpeakType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeakJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak Speak { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateSpeak" /> class.
        /// </summary>
        /// <param name="speak"></param>
        /// <param name="type">
        /// Message type identifier for updating the speak model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1UpdateSpeak(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak speak,
            global::Deepgram.Realtime.AgentV1AgentV1UpdateSpeakType type)
        {
            this.Type = type;
            this.Speak = speak;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdateSpeak" /> class.
        /// </summary>
        public AgentV1AgentV1UpdateSpeak()
        {
        }

    }
}