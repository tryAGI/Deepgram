
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1UpdatePrompt
    {
        /// <summary>
        /// Message type identifier for prompt update request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdatePromptTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1UpdatePromptType Type { get; set; }

        /// <summary>
        /// The new system prompt to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdatePrompt" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The new system prompt to be used by the agent
        /// </param>
        /// <param name="type">
        /// Message type identifier for prompt update request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1UpdatePrompt(
            string prompt,
            global::Deepgram.Realtime.AgentV1AgentV1UpdatePromptType type)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1UpdatePrompt" /> class.
        /// </summary>
        public AgentV1AgentV1UpdatePrompt()
        {
        }
    }
}