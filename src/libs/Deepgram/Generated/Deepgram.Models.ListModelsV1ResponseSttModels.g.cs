
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsV1ResponseSttModels
    {
        /// <summary>
        /// Example: nova-3
        /// </summary>
        /// <example>nova-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: nova-3
        /// </summary>
        /// <example>nova-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// Example: base
        /// </summary>
        /// <example>base</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        /// Example: [en, en-us]
        /// </summary>
        /// <example>[en, en-us]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Example: 2021-11-10.1
        /// </summary>
        /// <example>2021-11-10.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Example: 6b28e919-8427-4f32-9847-492e2efd7daf
        /// </summary>
        /// <example>6b28e919-8427-4f32-9847-492e2efd7daf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public bool? Batch { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_output")]
        public bool? FormattedOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1ResponseSttModels" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: nova-3
        /// </param>
        /// <param name="canonicalName">
        /// Example: nova-3
        /// </param>
        /// <param name="architecture">
        /// Example: base
        /// </param>
        /// <param name="languages">
        /// Example: [en, en-us]
        /// </param>
        /// <param name="version">
        /// Example: 2021-11-10.1
        /// </param>
        /// <param name="uuid">
        /// Example: 6b28e919-8427-4f32-9847-492e2efd7daf
        /// </param>
        /// <param name="batch">
        /// Example: true
        /// </param>
        /// <param name="streaming">
        /// Example: true
        /// </param>
        /// <param name="formattedOutput">
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsV1ResponseSttModels(
            string? name,
            string? canonicalName,
            string? architecture,
            global::System.Collections.Generic.IList<string>? languages,
            string? version,
            string? uuid,
            bool? batch,
            bool? streaming,
            bool? formattedOutput)
        {
            this.Name = name;
            this.CanonicalName = canonicalName;
            this.Architecture = architecture;
            this.Languages = languages;
            this.Version = version;
            this.Uuid = uuid;
            this.Batch = batch;
            this.Streaming = streaming;
            this.FormattedOutput = formattedOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsV1ResponseSttModels" /> class.
        /// </summary>
        public ListModelsV1ResponseSttModels()
        {
        }
    }
}