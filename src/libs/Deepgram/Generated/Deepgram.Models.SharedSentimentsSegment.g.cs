
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedSentimentsSegment
    {
        /// <summary>
        /// Example: Yeah. As as much as, um, it's worth celebrating, uh, the first, uh, spacewalk, um, with an all-female team, I think many of us are looking forward to it just being normal. And, um, I think if it signifies anything, it is, uh, to honor the the women who came before us who, um, were skilled and qualified, um, and didn't get the the same opportunities that we have today.
        /// </summary>
        /// <example>Yeah. As as much as, um, it's worth celebrating, uh, the first, uh, spacewalk, um, with an all-female team, I think many of us are looking forward to it just being normal. And, um, I think if it signifies anything, it is, uh, to honor the the women who came before us who, um, were skilled and qualified, um, and didn't get the the same opportunities that we have today.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_word")]
        public double? StartWord { get; set; }

        /// <summary>
        /// Example: 69
        /// </summary>
        /// <example>69</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_word")]
        public double? EndWord { get; set; }

        /// <summary>
        /// Example: positive
        /// </summary>
        /// <example>positive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public string? Sentiment { get; set; }

        /// <summary>
        /// Example: 0.5810546875
        /// </summary>
        /// <example>0.5810546875</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_score")]
        public double? SentimentScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentimentsSegment" /> class.
        /// </summary>
        /// <param name="text">
        /// Example: Yeah. As as much as, um, it's worth celebrating, uh, the first, uh, spacewalk, um, with an all-female team, I think many of us are looking forward to it just being normal. And, um, I think if it signifies anything, it is, uh, to honor the the women who came before us who, um, were skilled and qualified, um, and didn't get the the same opportunities that we have today.
        /// </param>
        /// <param name="startWord">
        /// Example: 0
        /// </param>
        /// <param name="endWord">
        /// Example: 69
        /// </param>
        /// <param name="sentiment">
        /// Example: positive
        /// </param>
        /// <param name="sentimentScore">
        /// Example: 0.5810546875
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSentimentsSegment(
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
        /// Initializes a new instance of the <see cref="SharedSentimentsSegment" /> class.
        /// </summary>
        public SharedSentimentsSegment()
        {
        }
    }
}