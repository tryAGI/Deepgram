
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBreakdownV1ResponseResultsItemsGrouping
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
        /// Optional accessor identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessor")]
        public string? Accessor { get; set; }

        /// <summary>
        /// Optional endpoint identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Optional feature set identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_set")]
        public string? FeatureSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Optional method identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Optional list of tags, null unless grouped by tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Optional deployment identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResultsItemsGrouping" /> class.
        /// </summary>
        /// <param name="start">
        /// Start date for this group
        /// </param>
        /// <param name="end">
        /// End date for this group
        /// </param>
        /// <param name="accessor">
        /// Optional accessor identifier
        /// </param>
        /// <param name="endpoint">
        /// Optional endpoint identifier
        /// </param>
        /// <param name="featureSet">
        /// Optional feature set identifier
        /// </param>
        /// <param name="models"></param>
        /// <param name="method">
        /// Optional method identifier
        /// </param>
        /// <param name="tags">
        /// Optional list of tags, null unless grouped by tags.
        /// </param>
        /// <param name="deployment">
        /// Optional deployment identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageBreakdownV1ResponseResultsItemsGrouping(
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? accessor,
            string? endpoint,
            string? featureSet,
            global::System.Collections.Generic.IList<string>? models,
            string? method,
            global::System.Collections.Generic.IList<string>? tags,
            string? deployment)
        {
            this.Start = start;
            this.End = end;
            this.Accessor = accessor;
            this.Endpoint = endpoint;
            this.FeatureSet = featureSet;
            this.Models = models;
            this.Method = method;
            this.Tags = tags;
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResultsItemsGrouping" /> class.
        /// </summary>
        public UsageBreakdownV1ResponseResultsItemsGrouping()
        {
        }
    }
}