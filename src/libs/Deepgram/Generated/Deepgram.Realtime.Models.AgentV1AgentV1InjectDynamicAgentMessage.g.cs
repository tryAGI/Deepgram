
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentV1AgentV1InjectDynamicAgentMessage
    {
        /// <summary>
        /// Message type identifier for injecting an agent message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectDynamicAgentMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1InjectDynamicAgentMessageType Type { get; set; }

        /// <summary>
        /// Must be `true`. The Think Live model generates the line, so no `message` is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dynamic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDynamic { get; set; }

        /// <summary>
        /// Controls how the injection interacts with any in-progress user or agent turn.<br/>
        /// * `default` — The agent speaks only if neither the user nor the agent is mid-turn. If a turn is in progress, the server replies with `InjectionRefused`.<br/>
        /// * `queue` — The message is appended after any already-queued `ConversationText` without interrupting the current agent turn or think response. If nothing is queued, the message plays immediately.<br/>
        /// * `interrupt` — The agent immediately speaks. If the agent was already speaking, it interrupts the current speech and replaces it with the new message. If the user is speaking, the agent interrupts with the new message, but the user's continued speech triggers `UserStartedSpeaking`, which quickly interrupts the agent.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1InjectDynamicAgentMessageBehaviorJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1InjectDynamicAgentMessageBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectDynamicAgentMessage" /> class.
        /// </summary>
        /// <param name="isDynamic">
        /// Must be `true`. The Think Live model generates the line, so no `message` is sent
        /// </param>
        /// <param name="type">
        /// Message type identifier for injecting an agent message
        /// </param>
        /// <param name="behavior">
        /// Controls how the injection interacts with any in-progress user or agent turn.<br/>
        /// * `default` — The agent speaks only if neither the user nor the agent is mid-turn. If a turn is in progress, the server replies with `InjectionRefused`.<br/>
        /// * `queue` — The message is appended after any already-queued `ConversationText` without interrupting the current agent turn or think response. If nothing is queued, the message plays immediately.<br/>
        /// * `interrupt` — The agent immediately speaks. If the agent was already speaking, it interrupts the current speech and replaces it with the new message. If the user is speaking, the agent interrupts with the new message, but the user's continued speech triggers `UserStartedSpeaking`, which quickly interrupts the agent.<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1InjectDynamicAgentMessage(
            bool isDynamic,
            global::Deepgram.Realtime.AgentV1AgentV1InjectDynamicAgentMessageType type,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1InjectDynamicAgentMessageBehavior? behavior)
        {
            this.Type = type;
            this.IsDynamic = isDynamic;
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectDynamicAgentMessage" /> class.
        /// </summary>
        public AgentV1AgentV1InjectDynamicAgentMessage()
        {
        }

    }
}