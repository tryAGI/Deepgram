
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageFieldsV1Response
    {
        /// <summary>
        /// List of tags associated with the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// List of models available for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Deepgram.UsageFieldsV1ResponseModelsItems>? Models { get; set; }

        /// <summary>
        /// Processing methods supported by the API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_methods")]
        public global::System.Collections.Generic.IList<string>? ProcessingMethods { get; set; }

        /// <summary>
        /// API features available to the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.IList<string>? Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFieldsV1Response" /> class.
        /// </summary>
        /// <param name="tags">
        /// List of tags associated with the project
        /// </param>
        /// <param name="models">
        /// List of models available for the project.
        /// </param>
        /// <param name="processingMethods">
        /// Processing methods supported by the API
        /// </param>
        /// <param name="features">
        /// API features available to the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageFieldsV1Response(
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::Deepgram.UsageFieldsV1ResponseModelsItems>? models,
            global::System.Collections.Generic.IList<string>? processingMethods,
            global::System.Collections.Generic.IList<string>? features)
        {
            this.Tags = tags;
            this.Models = models;
            this.ProcessingMethods = processingMethods;
            this.Features = features;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFieldsV1Response" /> class.
        /// </summary>
        public UsageFieldsV1Response()
        {
        }

    }
}