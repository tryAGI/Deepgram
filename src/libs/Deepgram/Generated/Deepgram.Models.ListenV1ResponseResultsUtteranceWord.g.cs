
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsUtteranceWord
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
        public float? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public float? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public float? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_confidence")]
        public float? SpeakerConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuated_word")]
        public string? PunctuatedWord { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsUtteranceWord" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="confidence"></param>
        /// <param name="speaker"></param>
        /// <param name="speakerConfidence"></param>
        /// <param name="punctuatedWord"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsUtteranceWord(
            string? word,
            float? start,
            float? end,
            float? confidence,
            float? speaker,
            float? speakerConfidence,
            string? punctuatedWord)
        {
            this.Word = word;
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Speaker = speaker;
            this.SpeakerConfidence = speakerConfidence;
            this.PunctuatedWord = punctuatedWord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsUtteranceWord" /> class.
        /// </summary>
        public ListenV1ResponseResultsUtteranceWord()
        {
        }
    }
}