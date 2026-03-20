
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedIntentsResultsIntentsSegmentIntent
    {
        /// <summary>
        /// Example: Encourage podcasting
        /// </summary>
        /// <example>Encourage podcasting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent")]
        public string? Intent { get; set; }

        /// <summary>
        /// Example: 0.0038975573
        /// </summary>
        /// <example>0.0038975573</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_score")]
        public float? ConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResultsIntentsSegmentIntent" /> class.
        /// </summary>
        /// <param name="intent">
        /// Example: Encourage podcasting
        /// </param>
        /// <param name="confidenceScore">
        /// Example: 0.0038975573
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedIntentsResultsIntentsSegmentIntent(
            string? intent,
            float? confidenceScore)
        {
            this.Intent = intent;
            this.ConfidenceScore = confidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResultsIntentsSegmentIntent" /> class.
        /// </summary>
        public SharedIntentsResultsIntentsSegmentIntent()
        {
        }
    }
}