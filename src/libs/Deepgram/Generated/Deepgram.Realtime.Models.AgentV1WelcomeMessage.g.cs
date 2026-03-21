
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1WelcomeMessage
    {
        /// <summary>
        /// Message type identifier for welcome message
        /// </summary>
        /// <default>"Welcome"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "Welcome";

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
        /// Initializes a new instance of the <see cref="AgentV1WelcomeMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier for welcome message
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1WelcomeMessage(
            string requestId,
            string type = "Welcome")
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1WelcomeMessage" /> class.
        /// </summary>
        public AgentV1WelcomeMessage()
        {
        }
    }
}