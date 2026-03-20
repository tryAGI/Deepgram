
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadV1ResponseMetadataMetadataSentimentInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuid")]
        public global::System.Guid? ModelUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public double? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseMetadataMetadataSentimentInfo" /> class.
        /// </summary>
        /// <param name="modelUuid"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1ResponseMetadataMetadataSentimentInfo(
            global::System.Guid? modelUuid,
            double? inputTokens,
            double? outputTokens)
        {
            this.ModelUuid = modelUuid;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseMetadataMetadataSentimentInfo" /> class.
        /// </summary>
        public ReadV1ResponseMetadataMetadataSentimentInfo()
        {
        }
    }
}