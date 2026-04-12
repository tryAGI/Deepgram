
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Notifies the client of non-fatal errors or warnings
    /// </summary>
    public sealed partial class AgentV1AgentV1Warning
    {
        /// <summary>
        /// Message type identifier for warnings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1WarningTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1WarningType Type { get; set; }

        /// <summary>
        /// Description of the warning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Warning code identifier
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
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Warning" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of the warning
        /// </param>
        /// <param name="code">
        /// Warning code identifier
        /// </param>
        /// <param name="type">
        /// Message type identifier for warnings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1Warning(
            string description,
            string code,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1WarningType type)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Warning" /> class.
        /// </summary>
        public AgentV1AgentV1Warning()
        {
        }
    }
}