
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1InjectAgentMessage
    {
        /// <summary>
        /// Message type identifier for injecting an agent message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectAgentMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessageType Type { get; set; }

        /// <summary>
        /// The statement that the agent should say
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Controls how the injection interacts with any in-progress user or agent turn.<br/>
        /// * `default` — The agent speaks only if neither the user nor the agent is mid-turn. If a turn is in progress, the server replies with `InjectionRefused`.<br/>
        /// * `queue` — The message is appended after any already-queued `ConversationText` without interrupting the current agent turn or think response. If nothing is queued, the message plays immediately.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehaviorJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectAgentMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// The statement that the agent should say
        /// </param>
        /// <param name="type">
        /// Message type identifier for injecting an agent message
        /// </param>
        /// <param name="behavior">
        /// Controls how the injection interacts with any in-progress user or agent turn.<br/>
        /// * `default` — The agent speaks only if neither the user nor the agent is mid-turn. If a turn is in progress, the server replies with `InjectionRefused`.<br/>
        /// * `queue` — The message is appended after any already-queued `ConversationText` without interrupting the current agent turn or think response. If nothing is queued, the message plays immediately.<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1InjectAgentMessage(
            string message,
            global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessageType type,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior? behavior)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1InjectAgentMessage" /> class.
        /// </summary>
        public AgentV1AgentV1InjectAgentMessage()
        {
        }

    }
}