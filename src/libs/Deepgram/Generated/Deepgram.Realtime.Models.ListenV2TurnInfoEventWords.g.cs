
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV2TurnInfoEventWords
    {
        /// <summary>
        /// The individual punctuated, properly-cased word from the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Confidence that this word was transcribed correctly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2TurnInfoEventWords" /> class.
        /// </summary>
        /// <param name="word">
        /// The individual punctuated, properly-cased word from the transcript
        /// </param>
        /// <param name="confidence">
        /// Confidence that this word was transcribed correctly
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2TurnInfoEventWords(
            string word,
            float confidence)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2TurnInfoEventWords" /> class.
        /// </summary>
        public ListenV2TurnInfoEventWords()
        {
        }
    }
}