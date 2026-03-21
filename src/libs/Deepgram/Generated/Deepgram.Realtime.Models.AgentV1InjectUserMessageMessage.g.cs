
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1InjectUserMessageMessage
    {
        /// <summary>
        /// Message type identifier for injecting a user message
        /// </summary>
        /// <default>"InjectUserMessage"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "InjectUserMessage";

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
        /// Initializes a new instance of the <see cref="AgentV1InjectUserMessageMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for injecting a user message
        /// </param>
        /// <param name="content">
        /// The specific phrase or statement the agent should respond to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1InjectUserMessageMessage(
            string content,
            string type = "InjectUserMessage")
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1InjectUserMessageMessage" /> class.
        /// </summary>
        public AgentV1InjectUserMessageMessage()
        {
        }
    }
}