
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Conversation text as part of the conversation history
    /// </summary>
    public sealed partial class AgentV1SettingsMessageAgentContextMessageVariant1
    {
        /// <summary>
        /// Message type identifier for conversation text
        /// </summary>
        /// <default>"History"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "History";

        /// <summary>
        /// Identifies who spoke the statement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAgentContextMessageVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1Role Role { get; set; }

        /// <summary>
        /// The actual statement that was spoken
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
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentContextMessageVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for conversation text
        /// </param>
        /// <param name="role">
        /// Identifies who spoke the statement
        /// </param>
        /// <param name="content">
        /// The actual statement that was spoken
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1SettingsMessageAgentContextMessageVariant1(
            global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1Role role,
            string content,
            string type = "History")
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1SettingsMessageAgentContextMessageVariant1" /> class.
        /// </summary>
        public AgentV1SettingsMessageAgentContextMessageVariant1()
        {
        }
    }
}