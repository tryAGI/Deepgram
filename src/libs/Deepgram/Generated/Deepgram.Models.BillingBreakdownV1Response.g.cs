
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingBreakdownV1Response
    {
        /// <summary>
        /// Start date of the billing summmary period<br/>
        /// Example: 2025-01-16
        /// </summary>
        /// <example>2025-01-16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// End date of the billing summary period<br/>
        /// Example: 2025-01-23
        /// </summary>
        /// <example>2025-01-23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.BillingBreakdownV1ResponseResolution Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.BillingBreakdownV1ResponseResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1Response" /> class.
        /// </summary>
        /// <param name="start">
        /// Start date of the billing summmary period<br/>
        /// Example: 2025-01-16
        /// </param>
        /// <param name="end">
        /// End date of the billing summary period<br/>
        /// Example: 2025-01-23
        /// </param>
        /// <param name="resolution"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingBreakdownV1Response(
            global::System.DateTime start,
            global::System.DateTime end,
            global::Deepgram.BillingBreakdownV1ResponseResolution resolution,
            global::System.Collections.Generic.IList<global::Deepgram.BillingBreakdownV1ResponseResult> results)
        {
            this.Start = start;
            this.End = end;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1Response" /> class.
        /// </summary>
        public BillingBreakdownV1Response()
        {
        }
    }
}