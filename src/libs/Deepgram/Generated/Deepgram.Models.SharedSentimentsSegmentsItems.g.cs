
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedSentimentsSegmentsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_word")]
        public double? StartWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_word")]
        public double? EndWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public string? Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_score")]
        public double? SentimentScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentimentsSegmentsItems" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startWord"></param>
        /// <param name="endWord"></param>
        /// <param name="sentiment"></param>
        /// <param name="sentimentScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSentimentsSegmentsItems(
            string? text,
            double? startWord,
            double? endWord,
            string? sentiment,
            double? sentimentScore)
        {
            this.Text = text;
            this.StartWord = startWord;
            this.EndWord = endWord;
            this.Sentiment = sentiment;
            this.SentimentScore = sentimentScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentimentsSegmentsItems" /> class.
        /// </summary>
        public SharedSentimentsSegmentsItems()
        {
        }

    }
}