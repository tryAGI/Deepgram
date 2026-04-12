
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for updating agent configuration metadata
    /// </summary>
    public sealed partial class UpdateAgentMetadataV1Request
    {
        /// <summary>
        /// A map of string key-value pairs to associate with this agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentMetadataV1Request" /> class.
        /// </summary>
        /// <param name="metadata">
        /// A map of string key-value pairs to associate with this agent configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentMetadataV1Request(
            global::System.Collections.Generic.Dictionary<string, string> metadata)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentMetadataV1Request" /> class.
        /// </summary>
        public UpdateAgentMetadataV1Request()
        {
        }
    }
}