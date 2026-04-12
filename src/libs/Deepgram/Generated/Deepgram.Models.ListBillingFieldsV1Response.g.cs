
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBillingFieldsV1Response
    {
        /// <summary>
        /// List of accessor UUIDs for the time period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessors")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Accessors { get; set; }

        /// <summary>
        /// List of deployment types for the time period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListBillingFieldsV1ResponseDeploymentsItems>? Deployments { get; set; }

        /// <summary>
        /// List of tags for the time period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Map of line item names to human-readable descriptions for the time period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        public global::System.Collections.Generic.Dictionary<string, string>? LineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBillingFieldsV1Response" /> class.
        /// </summary>
        /// <param name="accessors">
        /// List of accessor UUIDs for the time period
        /// </param>
        /// <param name="deployments">
        /// List of deployment types for the time period
        /// </param>
        /// <param name="tags">
        /// List of tags for the time period
        /// </param>
        /// <param name="lineItems">
        /// Map of line item names to human-readable descriptions for the time period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBillingFieldsV1Response(
            global::System.Collections.Generic.IList<global::System.Guid>? accessors,
            global::System.Collections.Generic.IList<global::Deepgram.ListBillingFieldsV1ResponseDeploymentsItems>? deployments,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, string>? lineItems)
        {
            this.Accessors = accessors;
            this.Deployments = deployments;
            this.Tags = tags;
            this.LineItems = lineItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBillingFieldsV1Response" /> class.
        /// </summary>
        public ListBillingFieldsV1Response()
        {
        }
    }
}