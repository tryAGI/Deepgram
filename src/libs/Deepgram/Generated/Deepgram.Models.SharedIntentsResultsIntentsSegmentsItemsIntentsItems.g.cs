
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedIntentsResultsIntentsSegmentsItemsIntentsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent")]
        public string? Intent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        public double? ConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResultsIntentsSegmentsItemsIntentsItems" /> class.
        /// </summary>
        /// <param name="intent"></param>
        /// <param name="confidenceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedIntentsResultsIntentsSegmentsItemsIntentsItems(
            string? intent,
            double? confidenceScore)
        {
            this.Intent = intent;
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResultsIntentsSegmentsItemsIntentsItems" /> class.
        /// </summary>
        public SharedIntentsResultsIntentsSegmentsItemsIntentsItems()
        {
        }

    }
}