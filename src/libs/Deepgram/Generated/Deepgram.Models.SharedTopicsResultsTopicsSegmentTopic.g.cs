
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedTopicsResultsTopicsSegmentTopic
    {
        /// <summary>
        /// Example: Spacewalk
        /// </summary>
        /// <example>Spacewalk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// Example: 0.91581345
        /// </summary>
        /// <example>0.91581345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        public float? ConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResultsTopicsSegmentTopic" /> class.
        /// </summary>
        /// <param name="topic">
        /// Example: Spacewalk
        /// </param>
        /// <param name="confidenceScore">
        /// Example: 0.91581345
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedTopicsResultsTopicsSegmentTopic(
            string? topic,
            float? confidenceScore)
        {
            this.Topic = topic;
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResultsTopicsSegmentTopic" /> class.
        /// </summary>
        public SharedTopicsResultsTopicsSegmentTopic()
        {
        }
    }
}