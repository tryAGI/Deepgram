
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingBreakdownV1ResponseResult
    {
        /// <summary>
        /// USD cost of the billing for this grouping<br/>
        /// Example: 0.25
        /// </summary>
        /// <example>0.25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Dollars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.BillingBreakdownV1ResponseResultGrouping Grouping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResult" /> class.
        /// </summary>
        /// <param name="dollars">
        /// USD cost of the billing for this grouping<br/>
        /// Example: 0.25
        /// </param>
        /// <param name="grouping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingBreakdownV1ResponseResult(
            float dollars,
            global::Deepgram.BillingBreakdownV1ResponseResultGrouping grouping)
        {
            this.Dollars = dollars;
            this.Grouping = grouping ?? throw new global::System.ArgumentNullException(nameof(grouping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResult" /> class.
        /// </summary>
        public BillingBreakdownV1ResponseResult()
        {
        }
    }
}