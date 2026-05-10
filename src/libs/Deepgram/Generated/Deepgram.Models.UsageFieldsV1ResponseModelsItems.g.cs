
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageFieldsV1ResponseModelsItems
    {
        /// <summary>
        /// Name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The language supported by the model (IETF language tag).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Version identifier of the model, typically with a date and a revision number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Unique identifier for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFieldsV1ResponseModelsItems" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the model.
        /// </param>
        /// <param name="language">
        /// The language supported by the model (IETF language tag).
        /// </param>
        /// <param name="version">
        /// Version identifier of the model, typically with a date and a revision number.
        /// </param>
        /// <param name="modelId">
        /// Unique identifier for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageFieldsV1ResponseModelsItems(
            string? name,
            string? language,
            string? version,
            string? modelId)
        {
            this.Name = name;
            this.Language = language;
            this.Version = version;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFieldsV1ResponseModelsItems" /> class.
        /// </summary>
        public UsageFieldsV1ResponseModelsItems()
        {
        }

    }
}