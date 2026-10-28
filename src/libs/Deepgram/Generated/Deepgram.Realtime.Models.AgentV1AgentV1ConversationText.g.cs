
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1ConversationText
    {
        /// <summary>
        /// Message type identifier for conversation text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ConversationTextTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationTextType Type { get; set; }

        /// <summary>
        /// Identifies who spoke the statement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ConversationTextRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ConversationTextRole Role { get; set; }

        /// <summary>
        /// The actual statement that was spoken
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Annotates what kind of utterance the message represents: `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior ConversationalBehavior { get; set; }

        /// <summary>
        /// The language hints that were active at the time of the turn. Only present on user-role messages when the listen model is flux-general-multi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_hinted")]
        public global::System.Collections.Generic.IList<string>? LanguagesHinted { get; set; }

        /// <summary>
        /// Languages detected in the user's speech, sorted by word count (descending). Only present on user-role messages when the listen model is flux-general-multi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1ConversationText" /> class.
        /// </summary>
        /// <param name="role">
        /// Identifies who spoke the statement
        /// </param>
        /// <param name="content">
        /// The actual statement that was spoken
        /// </param>
        /// <param name="conversationalBehavior">
        /// Annotates what kind of utterance the message represents: `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
        /// </param>
        /// <param name="type">
        /// Message type identifier for conversation text
        /// </param>
        /// <param name="languagesHinted">
        /// The language hints that were active at the time of the turn. Only present on user-role messages when the listen model is flux-general-multi.
        /// </param>
        /// <param name="languages">
        /// Languages detected in the user's speech, sorted by word count (descending). Only present on user-role messages when the listen model is flux-general-multi.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1ConversationText(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ConversationTextRole role,
            string content,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior conversationalBehavior,
            global::Deepgram.Realtime.AgentV1AgentV1ConversationTextType type,
            global::System.Collections.Generic.IList<string>? languagesHinted,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ConversationalBehavior = conversationalBehavior;
            this.LanguagesHinted = languagesHinted;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1ConversationText" /> class.
        /// </summary>
        public AgentV1AgentV1ConversationText()
        {
        }

    }
}