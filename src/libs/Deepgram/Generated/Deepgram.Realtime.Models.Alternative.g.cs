
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Alternative
    {
        /// <summary>
        /// The transcript text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// The confidence score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Detected languages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.Word> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Alternative" /> class.
        /// </summary>
        /// <param name="transcript">
        /// The transcript text
        /// </param>
        /// <param name="confidence">
        /// The confidence score
        /// </param>
        /// <param name="languages">
        /// Detected languages
        /// </param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Alternative(
            string transcript,
            double confidence,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.Word> words,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Confidence = confidence;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alternative" /> class.
        /// </summary>
        public Alternative()
        {
        }
    }
}