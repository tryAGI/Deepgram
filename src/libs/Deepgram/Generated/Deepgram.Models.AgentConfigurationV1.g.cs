
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// A reusable agent configuration
    /// </summary>
    public sealed partial class AgentConfigurationV1
    {
        /// <summary>
        /// The unique identifier of the agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The agent configuration object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.AgentConfigurationV1Config Config { get; set; }

        /// <summary>
        /// A map of arbitrary key-value pairs for labeling or organizing the agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Timestamp when the configuration was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the configuration was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigurationV1" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The unique identifier of the agent configuration
        /// </param>
        /// <param name="config">
        /// The agent configuration object
        /// </param>
        /// <param name="metadata">
        /// A map of arbitrary key-value pairs for labeling or organizing the agent configuration
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the configuration was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the configuration was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigurationV1(
            string agentId,
            global::Deepgram.AgentConfigurationV1Config config,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigurationV1" /> class.
        /// </summary>
        public AgentConfigurationV1()
        {
        }

    }
}