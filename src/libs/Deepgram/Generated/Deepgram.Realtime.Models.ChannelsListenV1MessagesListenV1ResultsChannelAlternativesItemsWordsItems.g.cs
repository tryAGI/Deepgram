
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems
    {
        /// <summary>
        /// The word of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// The start time of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The end time of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// The confidence of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The language of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The punctuated word of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuated_word")]
        public string? PunctuatedWord { get; set; }

        /// <summary>
        /// The speaker of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public double? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems" /> class.
        /// </summary>
        /// <param name="word">
        /// The word of the transcription
        /// </param>
        /// <param name="start">
        /// The start time of the word
        /// </param>
        /// <param name="end">
        /// The end time of the word
        /// </param>
        /// <param name="confidence">
        /// The confidence of the word
        /// </param>
        /// <param name="language">
        /// The language of the word
        /// </param>
        /// <param name="punctuatedWord">
        /// The punctuated word of the word
        /// </param>
        /// <param name="speaker">
        /// The speaker of the word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems(
            string word,
            double start,
            double end,
            double confidence,
            string? language,
            string? punctuatedWord,
            double? speaker)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Language = language;
            this.PunctuatedWord = punctuatedWord;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems" /> class.
        /// </summary>
        public ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems()
        {
        }
    }
}