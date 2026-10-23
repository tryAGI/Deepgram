
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems
    {
        /// <summary>
        /// The transcript of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// The confidence of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// [BCP-47](https://tools.ietf.org/html/bcp47) language tags of the languages detected in the transcript, sorted by word count in descending order. Only present when `language=multi`. Can be absent on audio that switches languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// The `language_hint` values set at connection time, normalized: codes are returned in canonical form (`ES` → `es`, `zh-hk` → `zh-HK`), and a regional code the model has no tag for is returned as its base language (`en-GB` → `en`). Present on interim and final results of every Nova-3 multilingual stream (`model=nova-3&amp;language=multi`); an empty array when no `language_hint` was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_hinted")]
        public global::System.Collections.Generic.IList<string>? LanguagesHinted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems" /> class.
        /// </summary>
        /// <param name="transcript">
        /// The transcript of the transcription
        /// </param>
        /// <param name="confidence">
        /// The confidence of the transcription
        /// </param>
        /// <param name="words"></param>
        /// <param name="languages">
        /// [BCP-47](https://tools.ietf.org/html/bcp47) language tags of the languages detected in the transcript, sorted by word count in descending order. Only present when `language=multi`. Can be absent on audio that switches languages.
        /// </param>
        /// <param name="languagesHinted">
        /// The `language_hint` values set at connection time, normalized: codes are returned in canonical form (`ES` → `es`, `zh-hk` → `zh-HK`), and a regional code the model has no tag for is returned as its base language (`en-GB` → `en`). Present on interim and final results of every Nova-3 multilingual stream (`model=nova-3&amp;language=multi`); an empty array when no `language_hint` was sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems(
            string transcript,
            double confidence,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems> words,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Collections.Generic.IList<string>? languagesHinted)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Confidence = confidence;
            this.Languages = languages;
            this.LanguagesHinted = languagesHinted;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems" /> class.
        /// </summary>
        public ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems()
        {
        }

    }
}