
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelV1Response0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_name")]
        public string? CanonicalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public bool? Batch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_output")]
        public bool? FormattedOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelV1Response0" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="canonicalName"></param>
        /// <param name="architecture"></param>
        /// <param name="languages"></param>
        /// <param name="version"></param>
        /// <param name="uuid"></param>
        /// <param name="batch"></param>
        /// <param name="streaming"></param>
        /// <param name="formattedOutput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelV1Response0(
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
        /// Initializes a new instance of the <see cref="GetModelV1Response0" /> class.
        /// </summary>
        public GetModelV1Response0()
        {
        }

    }
}