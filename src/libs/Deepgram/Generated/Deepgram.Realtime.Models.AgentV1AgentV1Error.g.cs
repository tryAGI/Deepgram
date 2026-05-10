
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1Error
    {
        /// <summary>
        /// Message type identifier for error responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ErrorTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ErrorType Type { get; set; }

        /// <summary>
        /// A description of what went wrong
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Error code identifying the type of error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Error" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of what went wrong
        /// </param>
        /// <param name="code">
        /// Error code identifying the type of error
        /// </param>
        /// <param name="type">
        /// Message type identifier for error responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1Error(
            string description,
            string code,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ErrorType type)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Error" /> class.
        /// </summary>
        public AgentV1AgentV1Error()
        {
        }

    }
}