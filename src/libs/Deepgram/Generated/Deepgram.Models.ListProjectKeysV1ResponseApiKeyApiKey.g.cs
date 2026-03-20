
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectKeysV1ResponseApiKeyApiKey
    {
        /// <summary>
        /// Example: 1234567890abcdef1234567890abcdef
        /// </summary>
        /// <example>1234567890abcdef1234567890abcdef</example>
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
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeyApiKey" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// Example: 1234567890abcdef1234567890abcdef
        /// </param>
        /// <param name="comment">
        /// Example: A comment
        /// </param>
        /// <param name="scopes">
        /// Example: [admin]
        /// </param>
        /// <param name="created">
        /// Example: 2021-01-01T00:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectKeysV1ResponseApiKeyApiKey(
            string? apiKeyId,
            string? comment,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.DateTime? created)
        {
            this.ApiKeyId = apiKeyId;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeyApiKey" /> class.
        /// </summary>
        public ListProjectKeysV1ResponseApiKeyApiKey()
        {
        }
    }
}