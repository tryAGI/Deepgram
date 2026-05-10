
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentConfigurationsV1Response
    {
        /// <summary>
        /// A list of agent configurations for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Deepgram.AgentConfigurationV1>? Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentConfigurationsV1Response" /> class.
        /// </summary>
        /// <param name="agents">
        /// A list of agent configurations for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentConfigurationsV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.AgentConfigurationV1>? agents)
        {
            this.Agents = agents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentConfigurationsV1Response" /> class.
        /// </summary>
        public ListAgentConfigurationsV1Response()
        {
        }

    }
}