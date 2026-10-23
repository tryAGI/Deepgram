
#nullable enable

namespace Deepgram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV1ResponseResultsUtterancesItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public int? Channel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// [BCP-47](https://tools.ietf.org/html/bcp47) language tags of the languages detected in the utterance, sorted by word count in descending order. Only present when `language=multi`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems>? Words { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsUtterancesItems" /> class.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="confidence"></param>
        /// <param name="channel"></param>
        /// <param name="transcript"></param>
        /// <param name="languages">
        /// [BCP-47](https://tools.ietf.org/html/bcp47) language tags of the languages detected in the utterance, sorted by word count in descending order. Only present when `language=multi`.
        /// </param>
        /// <param name="words"></param>
        /// <param name="speaker"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsUtterancesItems(
            double? start,
            double? end,
            double? confidence,
            int? channel,
            string? transcript,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems>? words,
            int? speaker,
            global::System.Guid? id)
        {
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Channel = channel;
            this.Transcript = transcript;
            this.Languages = languages;
            this.Words = words;
            this.Speaker = speaker;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsUtterancesItems" /> class.
        /// </summary>
        public ListenV1ResponseResultsUtterancesItems()
        {
        }

    }
}