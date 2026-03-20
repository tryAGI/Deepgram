
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseMetadataSummaryInfo
    {
        /// <summary>
        /// Example: 67875a7f-c9c4-48a0-aa55-5bdb8a91c34a
        /// </summary>
        /// <example>67875a7f-c9c4-48a0-aa55-5bdb8a91c34a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuid")]
        public string? ModelUuid { get; set; }

        /// <summary>
        /// Example: 95
        /// </summary>
        /// <example>95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public double? InputTokens { get; set; }

        /// <summary>
        /// Example: 63
        /// </summary>
        /// <example>63</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseMetadataSummaryInfo" /> class.
        /// </summary>
        /// <param name="modelUuid">
        /// Example: 67875a7f-c9c4-48a0-aa55-5bdb8a91c34a
        /// </param>
        /// <param name="inputTokens">
        /// Example: 95
        /// </param>
        /// <param name="outputTokens">
        /// Example: 63
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseMetadataSummaryInfo(
            string? modelUuid,
            double? inputTokens,
            double? outputTokens)
        {
            this.ModelUuid = modelUuid;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseMetadataSummaryInfo" /> class.
        /// </summary>
        public ListenV1ResponseMetadataSummaryInfo()
        {
        }
    }
}