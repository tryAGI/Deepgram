
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Conversation context including the history of messages and function calls
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAgentContext
    {
        /// <summary>
        /// Conversation history as a list of messages and function calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2>>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentContext" /> class.
        /// </summary>
        /// <param name="messages">
        /// Conversation history as a list of messages and function calls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAgentContext(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2>>? messages)
        {
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentContext" /> class.
        /// </summary>
        public AgentV1SettingsMessageAgentContext()
        {
        }
    }
}