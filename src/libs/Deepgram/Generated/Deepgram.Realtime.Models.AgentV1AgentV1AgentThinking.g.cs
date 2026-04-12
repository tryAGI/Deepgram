
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1AgentThinking
    {
        /// <summary>
        /// Message type identifier for agent thinking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentThinkingTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinkingType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentV1AgentV1AgentThinking" /> class.
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
        public AgentV1AgentV1AgentThinking(
            string content,
            global::Deepgram.Realtime.AgentV1AgentV1AgentThinkingType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1AgentThinking" /> class.
        /// </summary>
        public AgentV1AgentV1AgentThinking()
        {
        }
    }
}