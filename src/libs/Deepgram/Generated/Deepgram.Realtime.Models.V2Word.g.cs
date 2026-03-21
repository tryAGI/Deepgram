
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2Word
    {
        /// <summary>
        /// The individual punctuated, properly-cased word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Confidence that this word was transcribed correctly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2Word" /> class.
        /// </summary>
        /// <param name="word">
        /// The individual punctuated, properly-cased word
        /// </param>
        /// <param name="confidence">
        /// Confidence that this word was transcribed correctly
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2Word(
            string word,
            double confidence)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2Word" /> class.
        /// </summary>
        public V2Word()
        {
        }
    }
}