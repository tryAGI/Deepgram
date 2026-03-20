
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedSentimentsAverage
    {
        /// <summary>
        /// Example: positive
        /// </summary>
        /// <example>positive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public string? Sentiment { get; set; }

        /// <summary>
        /// Example: 0.5810185185185185
        /// </summary>
        /// <example>0.5810185185185185</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_score")]
        public double? SentimentScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentimentsAverage" /> class.
        /// </summary>
        /// <param name="sentiment">
        /// Example: positive
        /// </param>
        /// <param name="sentimentScore">
        /// Example: 0.5810185185185185
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSentimentsAverage(
            string? sentiment,
            double? sentimentScore)
        {
            this.Sentiment = sentiment;
            this.SentimentScore = sentimentScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentimentsAverage" /> class.
        /// </summary>
        public SharedSentimentsAverage()
        {
        }
    }
}