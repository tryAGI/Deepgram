
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadV1ResponseResultsSummaryResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Deepgram.ReadV1ResponseResultsSummaryResultsSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseResultsSummaryResults" /> class.
        /// </summary>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1ResponseResultsSummaryResults(
            global::Deepgram.ReadV1ResponseResultsSummaryResultsSummary? summary)
        {
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseResultsSummaryResults" /> class.
        /// </summary>
        public ReadV1ResponseResultsSummaryResults()
        {
        }

    }
}