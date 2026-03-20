
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseMetadataSentimentInfo
    {
        /// <summary>
        /// Example: 80ab3179-d113-4254-bd6b-4a2f96498695
        /// </summary>
        /// <example>80ab3179-d113-4254-bd6b-4a2f96498695</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuid")]
        public string? ModelUuid { get; set; }

        /// <summary>
        /// Example: 105
        /// </summary>
        /// <example>105</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public double? InputTokens { get; set; }

        /// <summary>
        /// Example: 105
        /// </summary>
        /// <example>105</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseMetadataSentimentInfo" /> class.
        /// </summary>
        /// <param name="modelUuid">
        /// Example: 80ab3179-d113-4254-bd6b-4a2f96498695
        /// </param>
        /// <param name="inputTokens">
        /// Example: 105
        /// </param>
        /// <param name="outputTokens">
        /// Example: 105
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseMetadataSentimentInfo(
            string? modelUuid,
            double? inputTokens,
            double? outputTokens)
        {
            this.ModelUuid = modelUuid;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseMetadataSentimentInfo" /> class.
        /// </summary>
        public ListenV1ResponseMetadataSentimentInfo()
        {
        }
    }
}