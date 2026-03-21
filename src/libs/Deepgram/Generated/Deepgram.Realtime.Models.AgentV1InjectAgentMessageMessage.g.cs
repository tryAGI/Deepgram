
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1InjectAgentMessageMessage
    {
        /// <summary>
        /// Message type identifier for injecting an agent message
        /// </summary>
        /// <default>"InjectAgentMessage"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "InjectAgentMessage";

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
        /// Initializes a new instance of the <see cref="AgentV1InjectAgentMessageMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for injecting an agent message
        /// </param>
        /// <param name="message">
        /// The statement that the agent should say
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1InjectAgentMessageMessage(
            string message,
            string type = "InjectAgentMessage")
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1InjectAgentMessageMessage" /> class.
        /// </summary>
        public AgentV1InjectAgentMessageMessage()
        {
        }
    }
}