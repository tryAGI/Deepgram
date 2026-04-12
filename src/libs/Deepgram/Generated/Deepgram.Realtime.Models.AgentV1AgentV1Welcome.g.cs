
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1AgentV1Welcome
    {
        /// <summary>
        /// Message type identifier for welcome message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1WelcomeTypeJsonConverter))]
        public global::Deepgram.Realtime.AgentV1AgentV1WelcomeType Type { get; set; }

        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Welcome" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="type">
        /// Message type identifier for welcome message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1AgentV1Welcome(
            string requestId,
            global::Deepgram.Realtime.AgentV1AgentV1WelcomeType type)
        {
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1AgentV1Welcome" /> class.
        /// </summary>
        public AgentV1AgentV1Welcome()
        {
        }
    }
}