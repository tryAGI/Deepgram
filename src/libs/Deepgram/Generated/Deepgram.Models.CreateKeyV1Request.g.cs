
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKeyV1Request
    {
        /// <summary>
        /// Example: A comment
        /// </summary>
        /// <example>A comment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Comment { get; set; }

        /// <summary>
        /// Example: [admin]
        /// </summary>
        /// <example>[admin]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Example: [prod, west-region]
        /// </summary>
        /// <example>[prod, west-region]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Example: 2026-01-01T00:00:00Z
        /// </summary>
        /// <example>2026-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_to_live_in_seconds")]
        public double? TimeToLiveInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyV1Request" /> class.
        /// </summary>
        /// <param name="comment">
        /// Example: A comment
        /// </param>
        /// <param name="scopes">
        /// Example: [admin]
        /// </param>
        /// <param name="tags">
        /// Example: [prod, west-region]
        /// </param>
        /// <param name="expirationDate">
        /// Example: 2026-01-01T00:00:00Z
        /// </param>
        /// <param name="timeToLiveInSeconds">
        /// Example: 3600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKeyV1Request(
            string comment,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? expirationDate,
            double? timeToLiveInSeconds)
        {
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Tags = tags;
            this.ExpirationDate = expirationDate;
            this.TimeToLiveInSeconds = timeToLiveInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyV1Request" /> class.
        /// </summary>
        public CreateKeyV1Request()
        {
        }
    }
}