
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1InjectAgentMessage
    {
        /// <summary>
        /// Message type identifier for injecting an agent message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectAgentMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessageType Type { get; set; }

        /// <summary>
        /// The statement that the agent should say
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectAgentMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// The statement that the agent should say
        /// </param>
        /// <param name="type">
        /// Message type identifier for injecting an agent message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1InjectAgentMessage(
            string message,
            global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessageType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectAgentMessage" /> class.
        /// </summary>
        public AgentV1AgentV1InjectAgentMessage()
        {
        }
    }
}