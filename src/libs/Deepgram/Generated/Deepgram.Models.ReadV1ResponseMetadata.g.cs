
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadV1ResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Deepgram.ReadV1ResponseMetadataMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseMetadata" /> class.
        /// </summary>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1ResponseMetadata(
            global::Deepgram.ReadV1ResponseMetadataMetadata? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseMetadata" /> class.
        /// </summary>
        public ReadV1ResponseMetadata()
        {
        }

    }
}