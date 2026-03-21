
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Word
    {
        /// <summary>
        /// The word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word1 { get; set; }

        /// <summary>
        /// Start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Confidence score
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
        /// The punctuated word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuated_word")]
        public string? PunctuatedWord { get; set; }

        /// <summary>
        /// The speaker index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public double? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        /// <param name="word1">
        /// The word
        /// </param>
        /// <param name="start">
        /// Start time in seconds
        /// </param>
        /// <param name="end">
        /// End time in seconds
        /// </param>
        /// <param name="confidence">
        /// Confidence score
        /// </param>
        /// <param name="language">
        /// The language of the word
        /// </param>
        /// <param name="punctuatedWord">
        /// The punctuated word
        /// </param>
        /// <param name="speaker">
        /// The speaker index
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Word(
            string word1,
            double start,
            double end,
            double confidence,
            string? language,
            string? punctuatedWord,
            double? speaker)
        {
            this.Word1 = word1 ?? throw new global::System.ArgumentNullException(nameof(word1));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Language = language;
            this.PunctuatedWord = punctuatedWord;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        public Word()
        {
        }
    }
}