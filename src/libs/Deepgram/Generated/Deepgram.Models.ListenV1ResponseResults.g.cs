
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItems> Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItems>? Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Deepgram.ListenV1ResponseResultsSummary? Summary { get; set; }

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
        /// Initializes a new instance of the <see cref="ListenV1ResponseResults" /> class.
        /// </summary>
        /// <param name="channels"></param>
        /// <param name="utterances"></param>
        /// <param name="summary"></param>
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
        public ListenV1ResponseResults(
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItems> channels,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItems>? utterances,
            global::Deepgram.ListenV1ResponseResultsSummary? summary,
            global::Deepgram.SharedTopics? topics,
            global::Deepgram.SharedIntents? intents,
            global::Deepgram.SharedSentiments? sentiments)
        {
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.Utterances = utterances;
            this.Summary = summary;
            this.Topics = topics;
            this.Intents = intents;
            this.Sentiments = sentiments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResults" /> class.
        /// </summary>
        public ListenV1ResponseResults()
        {
        }
    }
}