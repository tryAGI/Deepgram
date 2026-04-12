
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedTopicsResultsTopicsSegmentsItemsTopicsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        public string? Topic { get; set; }

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
        /// Initializes a new instance of the <see cref="SharedTopicsResultsTopicsSegmentsItemsTopicsItems" /> class.
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="confidenceScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedTopicsResultsTopicsSegmentsItemsTopicsItems(
            string? topic,
            double? confidenceScore)
        {
            this.Topic = topic;
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResultsTopicsSegmentsItemsTopicsItems" /> class.
        /// </summary>
        public SharedTopicsResultsTopicsSegmentsItemsTopicsItems()
        {
        }
    }
}