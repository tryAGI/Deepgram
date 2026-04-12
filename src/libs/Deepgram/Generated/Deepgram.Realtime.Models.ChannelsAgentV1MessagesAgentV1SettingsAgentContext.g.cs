
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Conversation context including the history of messages and function calls
    /// </summary>
    public sealed partial class ChannelsAgentV1MessagesAgentV1SettingsAgentContext
    {
        /// <summary>
        /// Conversation history as a list of messages and function calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentContext" /> class.
        /// </summary>
        /// <param name="messages">
        /// Conversation history as a list of messages and function calls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContext(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems>? messages)
        {
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsAgentV1MessagesAgentV1SettingsAgentContext" /> class.
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContext()
        {
        }
    }
}