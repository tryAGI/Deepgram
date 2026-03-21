
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Send a control message to the agent
    /// </summary>
    public sealed partial class AgentV1ControlMessage
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ControlMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1ControlMessageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1ControlMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1ControlMessage(
            global::Deepgram.Realtime.AgentV1ControlMessageType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1ControlMessage" /> class.
        /// </summary>
        public AgentV1ControlMessage()
        {
        }
    }
}