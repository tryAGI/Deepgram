
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1PromptUpdatedEvent
    {
        /// <summary>
        /// Message type identifier for prompt update confirmation
        /// </summary>
        /// <default>"PromptUpdated"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "PromptUpdated";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1PromptUpdatedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for prompt update confirmation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1PromptUpdatedEvent(
            string type = "PromptUpdated")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1PromptUpdatedEvent" /> class.
        /// </summary>
        public AgentV1PromptUpdatedEvent()
        {
        }
    }
}