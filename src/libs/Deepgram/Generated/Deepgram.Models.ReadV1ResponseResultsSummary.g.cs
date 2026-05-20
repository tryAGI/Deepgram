
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Output whenever `summary=true` is used
    /// </summary>
    public sealed partial class ReadV1ResponseResultsSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::Deepgram.ReadV1ResponseResultsSummaryResults? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseResultsSummary" /> class.
        /// </summary>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadV1ResponseResultsSummary(
            global::Deepgram.ReadV1ResponseResultsSummaryResults? results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadV1ResponseResultsSummary" /> class.
        /// </summary>
        public ReadV1ResponseResultsSummary()
        {
        }

    }
}