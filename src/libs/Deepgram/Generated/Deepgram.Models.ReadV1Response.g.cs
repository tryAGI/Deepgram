
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// The standard text response
    /// </summary>
    public sealed partial class ReadV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ReadV1ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ReadV1ResponseResults Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1Response" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1Response(
            global::Deepgram.ReadV1ResponseMetadata metadata,
            global::Deepgram.ReadV1ResponseResults results)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1Response" /> class.
        /// </summary>
        public ReadV1Response()
        {
        }

    }
}