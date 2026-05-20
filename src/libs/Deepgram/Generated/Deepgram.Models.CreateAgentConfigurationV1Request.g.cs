
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for creating an agent configuration
    /// </summary>
    public sealed partial class CreateAgentConfigurationV1Request
    {
        /// <summary>
        /// A valid JSON string representing the agent block of a Settings message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// A map of arbitrary key-value pairs for labeling or organizing the agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// API version. Defaults to 1<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public int? ApiVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConfigurationV1Request" /> class.
        /// </summary>
        /// <param name="config">
        /// A valid JSON string representing the agent block of a Settings message
        /// </param>
        /// <param name="metadata">
        /// A map of arbitrary key-value pairs for labeling or organizing the agent configuration
        /// </param>
        /// <param name="apiVersion">
        /// API version. Defaults to 1<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConfigurationV1Request(
            string config,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? apiVersion)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Metadata = metadata;
            this.ApiVersion = apiVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConfigurationV1Request" /> class.
        /// </summary>
        public CreateAgentConfigurationV1Request()
        {
        }

    }
}