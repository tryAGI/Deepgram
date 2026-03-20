
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// OpenAI models
    /// </summary>
    public sealed partial class AgentThinkModelsV1ResponseModelVariant1
    {
        /// <summary>
        /// The unique identifier of the OpenAI model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant1IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.AgentThinkModelsV1ResponseModelVariant1Id Id { get; set; }

        /// <summary>
        /// The display name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The provider of the model
        /// </summary>
        /// <default>"open_ai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "open_ai";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the OpenAI model
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
        public AgentThinkModelsV1ResponseModelVariant1(
            global::Deepgram.AgentThinkModelsV1ResponseModelVariant1Id id,
            string name,
            string provider = "open_ai")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1ResponseModelVariant1" /> class.
        /// </summary>
        public AgentThinkModelsV1ResponseModelVariant1()
        {
        }
    }
}