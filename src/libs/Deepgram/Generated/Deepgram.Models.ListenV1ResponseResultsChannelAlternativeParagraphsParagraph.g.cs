
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelAlternativeParagraphsParagraph
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraphSentence>? Sentences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public float? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_words")]
        public float? NumWords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public float? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public float? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelAlternativeParagraphsParagraph" /> class.
        /// </summary>
        /// <param name="sentences"></param>
        /// <param name="speaker"></param>
        /// <param name="numWords"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelAlternativeParagraphsParagraph(
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraphSentence>? sentences,
            float? speaker,
            float? numWords,
            float? start,
            float? end)
        {
            this.Sentences = sentences;
            this.Speaker = speaker;
            this.NumWords = numWords;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelAlternativeParagraphsParagraph" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelAlternativeParagraphsParagraph()
        {
        }
    }
}