
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectKeyV1ResponseItemMemberApiKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="apiKeyId"></param>
        /// <param name="comment"></param>
        /// <param name="scopes"></param>
        /// <param name="tags"></param>
        /// <param name="expirationDate"></param>
        /// <param name="created"></param>
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