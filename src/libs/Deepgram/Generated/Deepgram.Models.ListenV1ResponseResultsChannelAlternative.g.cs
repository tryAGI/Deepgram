
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelAlternative
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeWord>? Words { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs")]
        public global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphs? Paragraphs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeEntitie>? Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaries")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeSummarie>? Summaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeTopic>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelAlternative" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="confidence"></param>
        /// <param name="words"></param>
        /// <param name="paragraphs"></param>
        /// <param name="entities"></param>
        /// <param name="summaries"></param>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelAlternative(
            string? transcript,
            float? confidence,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeWord>? words,
            global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphs? paragraphs,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeEntitie>? entities,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeSummarie>? summaries,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeTopic>? topics)
        {
            this.Transcript = transcript;
            this.Confidence = confidence;
            this.Words = words;
            this.Paragraphs = paragraphs;
            this.Entities = entities;
            this.Summaries = summaries;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelAlternative" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelAlternative()
        {
        }
    }
}