
#nullable enable

namespace Deepgram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelsItemsAlternativesItems
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
        public double? Confidence { get; set; }

        /// <summary>
        /// [BCP-47](https://tools.ietf.org/html/bcp47) language tags of the languages detected in the transcript, sorted by word count in descending order. Only present when `language=multi`. Can be absent on audio that switches languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// The `language_hint` values for the request, normalized: codes are returned in canonical form (`ES` → `es`, `zh-hk` → `zh-HK`), and a regional code the model has no tag for is returned as its base language (`en-GB` → `en`). Returned on every Nova-3 multilingual response (`model=nova-3&amp;language=multi`); an empty array when no `language_hint` was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_hinted")]
        public global::System.Collections.Generic.IList<string>? LanguagesHinted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems>? Words { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs")]
        public global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs? Paragraphs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems>? Entities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaries")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems>? Summaries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItems" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="confidence"></param>
        /// <param name="languages">
        /// [BCP-47](https://tools.ietf.org/html/bcp47) language tags of the languages detected in the transcript, sorted by word count in descending order. Only present when `language=multi`. Can be absent on audio that switches languages.
        /// </param>
        /// <param name="languagesHinted">
        /// The `language_hint` values for the request, normalized: codes are returned in canonical form (`ES` → `es`, `zh-hk` → `zh-HK`), and a regional code the model has no tag for is returned as its base language (`en-GB` → `en`). Returned on every Nova-3 multilingual response (`model=nova-3&amp;language=multi`); an empty array when no `language_hint` was sent.
        /// </param>
        /// <param name="words"></param>
        /// <param name="paragraphs"></param>
        /// <param name="entities"></param>
        /// <param name="summaries"></param>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelsItemsAlternativesItems(
            string? transcript,
            double? confidence,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Collections.Generic.IList<string>? languagesHinted,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems>? words,
            global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs? paragraphs,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems>? entities,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems>? summaries,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems>? topics)
        {
            this.Transcript = transcript;
            this.Confidence = confidence;
            this.Languages = languages;
            this.LanguagesHinted = languagesHinted;
            this.Words = words;
            this.Paragraphs = paragraphs;
            this.Entities = entities;
            this.Summaries = summaries;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItems" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelsItemsAlternativesItems()
        {
        }

    }
}