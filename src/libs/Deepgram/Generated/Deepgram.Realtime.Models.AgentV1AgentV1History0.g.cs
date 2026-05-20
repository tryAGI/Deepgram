
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Conversation text as part of the conversation history
    /// </summary>
    public sealed partial class AgentV1AgentV1History0
    {
        /// <summary>
        /// Message type identifier for conversation text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1History0TypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1History0Type Type { get; set; }

        /// <summary>
        /// Identifies who spoke the statement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1HistoryOneOf0RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role Role { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentV1AgentV1History0" /> class.
        /// </summary>
        /// <param name="role">
        /// Identifies who spoke the statement
        /// </param>
        /// <param name="content">
        /// The actual statement that was spoken
        /// </param>
        /// <param name="type">
        /// Message type identifier for conversation text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1History0(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1HistoryOneOf0Role role,
            string content,
            global::Deepgram.Realtime.AgentV1AgentV1History0Type type)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1History0" /> class.
        /// </summary>
        public AgentV1AgentV1History0()
        {
        }

    }
}