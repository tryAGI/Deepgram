
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBreakdownV1Response
    {
        /// <summary>
        /// Start date of the usage period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// End date of the usage period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.UsageBreakdownV1ResponseResolution Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.UsageBreakdownV1ResponseResultsItems> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1Response" /> class.
        /// </summary>
        /// <param name="start">
        /// Start date of the usage period
        /// </param>
        /// <param name="end">
        /// End date of the usage period
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageBreakdownV1Response(
            global::System.DateTime start,
            global::System.DateTime end,
            global::Deepgram.UsageBreakdownV1ResponseResolution resolution,
            global::System.Collections.Generic.IList<global::Deepgram.UsageBreakdownV1ResponseResultsItems> results)
        {
            this.Start = start;
            this.End = end;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1Response" /> class.
        /// </summary>
        public UsageBreakdownV1Response()
        {
        }
    }
}