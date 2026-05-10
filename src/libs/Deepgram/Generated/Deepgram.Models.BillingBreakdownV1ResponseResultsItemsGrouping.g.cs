
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingBreakdownV1ResponseResultsItemsGrouping
    {
        /// <summary>
        /// Start date for this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// End date for this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Optional accessor identifier, null unless grouped by accessor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessor")]
        public string? Accessor { get; set; }

        /// <summary>
        /// Optional deployment identifier, null unless grouped by deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        /// <summary>
        /// Optional line item identifier, null unless grouped by line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_item")]
        public string? LineItem { get; set; }

        /// <summary>
        /// Optional list of tags, null unless grouped by tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResultsItemsGrouping" /> class.
        /// </summary>
        /// <param name="start">
        /// Start date for this group
        /// </param>
        /// <param name="end">
        /// End date for this group
        /// </param>
        /// <param name="accessor">
        /// Optional accessor identifier, null unless grouped by accessor.
        /// </param>
        /// <param name="deployment">
        /// Optional deployment identifier, null unless grouped by deployment.
        /// </param>
        /// <param name="lineItem">
        /// Optional line item identifier, null unless grouped by line item.
        /// </param>
        /// <param name="tags">
        /// Optional list of tags, null unless grouped by tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingBreakdownV1ResponseResultsItemsGrouping(
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? accessor,
            string? deployment,
            string? lineItem,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Start = start;
            this.End = end;
            this.Accessor = accessor;
            this.Deployment = deployment;
            this.LineItem = lineItem;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResultsItemsGrouping" /> class.
        /// </summary>
        public BillingBreakdownV1ResponseResultsItemsGrouping()
        {
        }

    }
}