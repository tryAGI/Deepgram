
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// AWS Bedrock models (custom models accepted)
    /// </summary>
    public sealed partial class AgentThinkModelsV1ResponseModelsItems4
    {
        /// <summary>
        /// The unique identifier of the AWS Bedrock model (any model string accepted for BYO LLMs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The display name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The provider of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelsItems4" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the AWS Bedrock model (any model string accepted for BYO LLMs)
        /// </param>
        /// <param name="name">
        /// The display name of the model
        /// </param>
        /// <param name="provider">
        /// The provider of the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentThinkModelsV1ResponseModelsItems4(
            string id,
            string name,
            object provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelsItems4" /> class.
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems4()
        {
        }
    }
}