
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1ServerEventDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ServerEventDiscriminatorMessageTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1ServerEventDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1ServerEventDiscriminator(
            global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1ServerEventDiscriminator" /> class.
        /// </summary>
        public AgentV1ServerEventDiscriminator()
        {
        }

    }
}