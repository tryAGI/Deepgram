
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedIntentsResultsIntentsSegment
    {
        /// <summary>
        /// Example: If you found this valuable, you can subscribe to the show on spotify or your favorite podcast app.
        /// </summary>
        /// <example>If you found this valuable, you can subscribe to the show on spotify or your favorite podcast app.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Example: 354
        /// </summary>
        /// <example>354</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_word")]
        public double? StartWord { get; set; }

        /// <summary>
        /// Example: 414
        /// </summary>
        /// <example>414</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_word")]
        public double? EndWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intents")]
        public global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentIntent>? Intents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResultsIntentsSegment" /> class.
        /// </summary>
        /// <param name="text">
        /// Example: If you found this valuable, you can subscribe to the show on spotify or your favorite podcast app.
        /// </param>
        /// <param name="startWord">
        /// Example: 354
        /// </param>
        /// <param name="endWord">
        /// Example: 414
        /// </param>
        /// <param name="intents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedIntentsResultsIntentsSegment(
            string? text,
            double? startWord,
            double? endWord,
            global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentIntent>? intents)
        {
            this.Text = text;
            this.StartWord = startWord;
            this.EndWord = endWord;
            this.Intents = intents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResultsIntentsSegment" /> class.
        /// </summary>
        public SharedIntentsResultsIntentsSegment()
        {
        }
    }
}