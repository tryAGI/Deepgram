
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Anthropic models
    /// </summary>
    public sealed partial class AgentThinkModelsV1ResponseModelVariant2
    {
        /// <summary>
        /// The unique identifier of the Anthropic model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant2IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id Id { get; set; }

        /// <summary>
        /// The display name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The provider of the model
        /// </summary>
        /// <default>"anthropic"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "anthropic";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the Anthropic model
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
        public AgentThinkModelsV1ResponseModelVariant2(
            global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id id,
            string name,
            string provider = "anthropic")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelVariant2" /> class.
        /// </summary>
        public AgentThinkModelsV1ResponseModelVariant2()
        {
        }
    }
}