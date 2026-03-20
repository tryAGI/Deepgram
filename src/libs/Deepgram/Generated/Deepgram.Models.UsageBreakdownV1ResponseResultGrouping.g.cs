
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBreakdownV1ResponseResultGrouping
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
        /// Optional accessor identifier<br/>
        /// Example: 123456789012345678901234
        /// </summary>
        /// <example>123456789012345678901234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessor")]
        public string? Accessor { get; set; }

        /// <summary>
        /// Optional endpoint identifier<br/>
        /// Example: listen
        /// </summary>
        /// <example>listen</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Optional feature set identifier<br/>
        /// Example: punctuate
        /// </summary>
        /// <example>punctuate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_set")]
        public string? FeatureSet { get; set; }

        /// <summary>
        /// Optional models identifier<br/>
        /// Example: Nova-2
        /// </summary>
        /// <example>Nova-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public string? Models { get; set; }

        /// <summary>
        /// Optional method identifier<br/>
        /// Example: async
        /// </summary>
        /// <example>async</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Optional tags<br/>
        /// Example: tag1
        /// </summary>
        /// <example>tag1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// Optional deployment identifier<br/>
        /// Example: self-hosted
        /// </summary>
        /// <example>self-hosted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResultGrouping" /> class.
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
        /// Optional accessor identifier<br/>
        /// Example: 123456789012345678901234
        /// </param>
        /// <param name="endpoint">
        /// Optional endpoint identifier<br/>
        /// Example: listen
        /// </param>
        /// <param name="featureSet">
        /// Optional feature set identifier<br/>
        /// Example: punctuate
        /// </param>
        /// <param name="models">
        /// Optional models identifier<br/>
        /// Example: Nova-2
        /// </param>
        /// <param name="method">
        /// Optional method identifier<br/>
        /// Example: async
        /// </param>
        /// <param name="tags">
        /// Optional tags<br/>
        /// Example: tag1
        /// </param>
        /// <param name="deployment">
        /// Optional deployment identifier<br/>
        /// Example: self-hosted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageBreakdownV1ResponseResultGrouping(
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? accessor,
            string? endpoint,
            string? featureSet,
            string? models,
            string? method,
            string? tags,
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
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResultGrouping" /> class.
        /// </summary>
        public UsageBreakdownV1ResponseResultGrouping()
        {
        }
    }
}