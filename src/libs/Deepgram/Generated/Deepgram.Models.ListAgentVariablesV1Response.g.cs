
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentVariablesV1Response
    {
        /// <summary>
        /// A list of agent variables for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Deepgram.AgentVariableV1>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentVariablesV1Response" /> class.
        /// </summary>
        /// <param name="variables">
        /// A list of agent variables for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentVariablesV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.AgentVariableV1>? variables)
        {
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentVariablesV1Response" /> class.
        /// </summary>
        public ListAgentVariablesV1Response()
        {
        }

    }
}