
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentConfigurationV1Response
    {
        /// <summary>
        /// The unique identifier of the newly created agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The parsed agent configuration object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.CreateAgentConfigurationV1ResponseConfig Config { get; set; }

        /// <summary>
        /// Metadata associated with the agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConfigurationV1Response" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The unique identifier of the newly created agent configuration
        /// </param>
        /// <param name="config">
        /// The parsed agent configuration object
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the agent configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConfigurationV1Response(
            string agentId,
            global::Deepgram.CreateAgentConfigurationV1ResponseConfig config,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConfigurationV1Response" /> class.
        /// </summary>
        public CreateAgentConfigurationV1Response()
        {
        }

    }
}