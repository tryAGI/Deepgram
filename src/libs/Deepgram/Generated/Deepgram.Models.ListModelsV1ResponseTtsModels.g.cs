
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsV1ResponseTtsModels
    {
        /// <summary>
        /// Example: zeus
        /// </summary>
        /// <example>zeus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: aura-2-zeus-en
        /// </summary>
        /// <example>aura-2-zeus-en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// Example: aura-2
        /// </summary>
        /// <example>aura-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        /// Example: [en, en-US]
        /// </summary>
        /// <example>[en, en-US]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Example: 2025-04-07.0
        /// </summary>
        /// <example>2025-04-07.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Example: 2baf189d-91ac-481d-b6d1-750888667b31
        /// </summary>
        /// <example>2baf189d-91ac-481d-b6d1-750888667b31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Deepgram.ListModelsV1ResponseTtsModelsMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1ResponseTtsModels" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: zeus
        /// </param>
        /// <param name="canonicalName">
        /// Example: aura-2-zeus-en
        /// </param>
        /// <param name="architecture">
        /// Example: aura-2
        /// </param>
        /// <param name="languages">
        /// Example: [en, en-US]
        /// </param>
        /// <param name="version">
        /// Example: 2025-04-07.0
        /// </param>
        /// <param name="uuid">
        /// Example: 2baf189d-91ac-481d-b6d1-750888667b31
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsV1ResponseTtsModels(
            string? name,
            string? canonicalName,
            string? architecture,
            global::System.Collections.Generic.IList<string>? languages,
            string? version,
            global::System.Guid? uuid,
            global::Deepgram.ListModelsV1ResponseTtsModelsMetadata? metadata)
        {
            this.Name = name;
            this.CanonicalName = canonicalName;
            this.Architecture = architecture;
            this.Languages = languages;
            this.Version = version;
            this.Uuid = uuid;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1ResponseTtsModels" /> class.
        /// </summary>
        public ListModelsV1ResponseTtsModels()
        {
        }
    }
}