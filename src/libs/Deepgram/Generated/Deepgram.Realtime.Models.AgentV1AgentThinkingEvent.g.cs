
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentThinkingEvent
    {
        /// <summary>
        /// Message type identifier for agent thinking
        /// </summary>
        /// <default>"AgentThinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "AgentThinking";

        /// <summary>
        /// The text of the agent's thought process
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
        /// Initializes a new instance of the <see cref="AgentV1AgentThinkingEvent" /> class.
        /// </summary>
        /// <param name="content">
        /// The text of the agent's thought process
        /// </param>
        /// <param name="type">
        /// Message type identifier for agent thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentThinkingEvent(
            string content,
            string type = "AgentThinking")
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentThinkingEvent" /> class.
        /// </summary>
        public AgentV1AgentThinkingEvent()
        {
        }
    }
}