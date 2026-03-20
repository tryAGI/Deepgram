
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// AWS Bedrock models (custom models accepted)
    /// </summary>
    public sealed partial class AgentThinkModelsV1ResponseModelVariant5
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
        /// <default>"aws_bedrock"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "aws_bedrock";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelVariant5" /> class.
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
        public AgentThinkModelsV1ResponseModelVariant5(
            string id,
            string name,
            string provider = "aws_bedrock")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelVariant5" /> class.
        /// </summary>
        public AgentThinkModelsV1ResponseModelVariant5()
        {
        }
    }
}