
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

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
        /// <param name="languages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems(
            string transcript,
            double confidence,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems> words,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Confidence = confidence;
            this.Languages = languages;
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