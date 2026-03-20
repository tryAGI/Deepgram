
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectKeyV1ResponseItemMemberApiKey
    {
        /// <summary>
        /// Example: 1000-2000-3000-4000
        /// </summary>
        /// <example>1000-2000-3000-4000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// Example: A comment
        /// </summary>
        /// <example>A comment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Example: [admin]
        /// </summary>
        /// <example>[admin]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Example: [prod, west-region]
        /// </summary>
        /// <example>[prod, west-region]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Example: 2021-01-01T00:00:00Z
        /// </summary>
        /// <example>2021-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Example: 2021-01-01T00:00:00Z
        /// </summary>
        /// <example>2021-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectKeyV1ResponseItemMemberApiKey" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// Example: 1000-2000-3000-4000
        /// </param>
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
        /// Example: 2021-01-01T00:00:00Z
        /// </param>
        /// <param name="created">
        /// Example: 2021-01-01T00:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectKeyV1ResponseItemMemberApiKey(
            string? apiKeyId,
            string? comment,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? expirationDate,
            global::System.DateTime? created)
        {
            this.ApiKeyId = apiKeyId;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Tags = tags;
            this.ExpirationDate = expirationDate;
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectKeyV1ResponseItemMemberApiKey" /> class.
        /// </summary>
        public GetProjectKeyV1ResponseItemMemberApiKey()
        {
        }
    }
}