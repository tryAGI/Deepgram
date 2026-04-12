
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1InjectUserMessage
    {
        /// <summary>
        /// Message type identifier for injecting a user message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectUserMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1InjectUserMessageType Type { get; set; }

        /// <summary>
        /// The specific phrase or statement the agent should respond to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The specific phrase or statement the agent should respond to
        /// </param>
        /// <param name="type">
        /// Message type identifier for injecting a user message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1InjectUserMessage(
            string content,
            global::Deepgram.Realtime.AgentV1AgentV1InjectUserMessageType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectUserMessage" /> class.
        /// </summary>
        public AgentV1AgentV1InjectUserMessage()
        {
        }
    }
}