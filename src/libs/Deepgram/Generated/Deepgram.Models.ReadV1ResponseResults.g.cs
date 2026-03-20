
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadV1ResponseResults
    {
        /// <summary>
        /// Output whenever `summary=true` is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Deepgram.ReadV1ResponseResultsSummary? Summary { get; set; }

        /// <summary>
        /// Output whenever `topics=true` is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::Deepgram.SharedTopics? Topics { get; set; }

        /// <summary>
        /// Output whenever `intents=true` is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intents")]
        public global::Deepgram.SharedIntents? Intents { get; set; }

        /// <summary>
        /// Output whenever `sentiment=true` is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiments")]
        public global::Deepgram.SharedSentiments? Sentiments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseResults" /> class.
        /// </summary>
        /// <param name="summary">
        /// Output whenever `summary=true` is used
        /// </param>
        /// <param name="topics">
        /// Output whenever `topics=true` is used
        /// </param>
        /// <param name="intents">
        /// Output whenever `intents=true` is used
        /// </param>
        /// <param name="sentiments">
        /// Output whenever `sentiment=true` is used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1ResponseResults(
            global::Deepgram.ReadV1ResponseResultsSummary? summary,
            global::Deepgram.SharedTopics? topics,
            global::Deepgram.SharedIntents? intents,
            global::Deepgram.SharedSentiments? sentiments)
        {
            this.Summary = summary;
            this.Topics = topics;
            this.Intents = intents;
            this.Sentiments = sentiments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseResults" /> class.
        /// </summary>
        public ReadV1ResponseResults()
        {
        }
    }
}