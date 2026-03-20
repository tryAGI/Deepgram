
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelV1ResponseVariant1
    {
        /// <summary>
        /// Example: general
        /// </summary>
        /// <example>general</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: enhanced-general
        /// </summary>
        /// <example>enhanced-general</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// Example: polaris
        /// </summary>
        /// <example>polaris</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        /// Example: [en, en-us]
        /// </summary>
        /// <example>[en, en-us]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Example: 2022-05-18.1
        /// </summary>
        /// <example>2022-05-18.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Example: c7226e9e-ae1c-4057-ae2a-a71a6b0dc588
        /// </summary>
        /// <example>c7226e9e-ae1c-4057-ae2a-a71a6b0dc588</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

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
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_output")]
        public bool? FormattedOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelV1ResponseVariant1" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: general
        /// </param>
        /// <param name="canonicalName">
        /// Example: enhanced-general
        /// </param>
        /// <param name="architecture">
        /// Example: polaris
        /// </param>
        /// <param name="languages">
        /// Example: [en, en-us]
        /// </param>
        /// <param name="version">
        /// Example: 2022-05-18.1
        /// </param>
        /// <param name="uuid">
        /// Example: c7226e9e-ae1c-4057-ae2a-a71a6b0dc588
        /// </param>
        /// <param name="batch">
        /// Example: true
        /// </param>
        /// <param name="streaming">
        /// Example: true
        /// </param>
        /// <param name="formattedOutput">
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelV1ResponseVariant1(
            string? name,
            string? canonicalName,
            string? architecture,
            global::System.Collections.Generic.IList<string>? languages,
            string? version,
            global::System.Guid? uuid,
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
        /// Initializes a new instance of the <see cref="GetModelV1ResponseVariant1" /> class.
        /// </summary>
        public GetModelV1ResponseVariant1()
        {
        }
    }
}