
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingBreakdownV1ResponseResultGrouping
    {
        /// <summary>
        /// Start date for this group<br/>
        /// Example: 2025-01-16
        /// </summary>
        /// <example>2025-01-16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// End date for this group<br/>
        /// Example: 2025-01-16
        /// </summary>
        /// <example>2025-01-16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Optional accessor identifier, null unless grouped by accessor.<br/>
        /// Example: 123456789012345678901234
        /// </summary>
        /// <example>123456789012345678901234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessor")]
        public string? Accessor { get; set; }

        /// <summary>
        /// Optional deployment identifier, null unless grouped by deployment.<br/>
        /// Example: hosted
        /// </summary>
        /// <example>hosted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        /// <summary>
        /// Optional line item identifier, null unless grouped by line item.<br/>
        /// Example: streaming::nova-3
        /// </summary>
        /// <example>streaming::nova-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_item")]
        public string? LineItem { get; set; }

        /// <summary>
        /// Optional list of tags, null unless grouped by tags.<br/>
        /// Example: [tag1, tag2]
        /// </summary>
        /// <example>[tag1, tag2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResultGrouping" /> class.
        /// </summary>
        /// <param name="start">
        /// Start date for this group<br/>
        /// Example: 2025-01-16
        /// </param>
        /// <param name="end">
        /// End date for this group<br/>
        /// Example: 2025-01-16
        /// </param>
        /// <param name="accessor">
        /// Optional accessor identifier, null unless grouped by accessor.<br/>
        /// Example: 123456789012345678901234
        /// </param>
        /// <param name="deployment">
        /// Optional deployment identifier, null unless grouped by deployment.<br/>
        /// Example: hosted
        /// </param>
        /// <param name="lineItem">
        /// Optional line item identifier, null unless grouped by line item.<br/>
        /// Example: streaming::nova-3
        /// </param>
        /// <param name="tags">
        /// Optional list of tags, null unless grouped by tags.<br/>
        /// Example: [tag1, tag2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingBreakdownV1ResponseResultGrouping(
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
        /// Initializes a new instance of the <see cref="BillingBreakdownV1ResponseResultGrouping" /> class.
        /// </summary>
        public BillingBreakdownV1ResponseResultGrouping()
        {
        }
    }
}