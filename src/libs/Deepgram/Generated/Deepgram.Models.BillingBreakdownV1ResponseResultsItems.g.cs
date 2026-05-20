
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingBreakdownV1ResponseResultsItems
    {
        /// <summary>
        /// USD cost of the billing for this grouping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Dollars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.BillingBreakdownV1ResponseResultsItemsGrouping Grouping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResultsItems" /> class.
        /// </summary>
        /// <param name="dollars">
        /// USD cost of the billing for this grouping
        /// </param>
        /// <param name="grouping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingBreakdownV1ResponseResultsItems(
            double dollars,
            global::Deepgram.BillingBreakdownV1ResponseResultsItemsGrouping grouping)
        {
            this.Dollars = dollars;
            this.Grouping = grouping ?? throw new global::System.ArgumentNullException(nameof(grouping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResultsItems" /> class.
        /// </summary>
        public BillingBreakdownV1ResponseResultsItems()
        {
        }

    }
}