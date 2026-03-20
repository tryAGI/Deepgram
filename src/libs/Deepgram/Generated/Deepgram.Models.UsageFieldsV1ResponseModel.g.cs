
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageFieldsV1ResponseModel
    {
        /// <summary>
        /// Name of the model.<br/>
        /// Example: 2-medical-nova
        /// </summary>
        /// <example>2-medical-nova</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The language supported by the model (IETF language tag).<br/>
        /// Example: en-MY
        /// </summary>
        /// <example>en-MY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Version identifier of the model, typically with a date and a revision number.<br/>
        /// Example: 2024-05-31.13574
        /// </summary>
        /// <example>2024-05-31.13574</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Unique identifier for the model.<br/>
        /// Example: 1234567890-12345-67890
        /// </summary>
        /// <example>1234567890-12345-67890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFieldsV1ResponseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the model.<br/>
        /// Example: 2-medical-nova
        /// </param>
        /// <param name="language">
        /// The language supported by the model (IETF language tag).<br/>
        /// Example: en-MY
        /// </param>
        /// <param name="version">
        /// Version identifier of the model, typically with a date and a revision number.<br/>
        /// Example: 2024-05-31.13574
        /// </param>
        /// <param name="modelId">
        /// Unique identifier for the model.<br/>
        /// Example: 1234567890-12345-67890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageFieldsV1ResponseModel(
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
        /// Initializes a new instance of the <see cref="UsageFieldsV1ResponseModel" /> class.
        /// </summary>
        public UsageFieldsV1ResponseModel()
        {
        }
    }
}