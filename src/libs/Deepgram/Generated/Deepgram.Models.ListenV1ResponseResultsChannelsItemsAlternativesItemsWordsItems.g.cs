
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public string? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public string? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public string? Confidence { get; set; }

        /// <summary>
        /// The speaker of the word, present when diarization is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Confidence in the speaker assignment. Returned only for pre-recorded diarization; not available for streaming
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_confidence")]
        public string? SpeakerConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="confidence"></param>
        /// <param name="speaker">
        /// The speaker of the word, present when diarization is enabled
        /// </param>
        /// <param name="speakerConfidence">
        /// Confidence in the speaker assignment. Returned only for pre-recorded diarization; not available for streaming
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems(
            string? word,
            string? start,
            string? end,
            string? confidence,
            int? speaker,
            string? speakerConfidence)
        {
            this.Word = word;
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Speaker = speaker;
            this.SpeakerConfidence = speakerConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems()
        {
        }

    }
}