
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectKeysV1ResponseApiKeysItemsApiKey
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeysItemsApiKey" /> class.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="comment"></param>
        /// <param name="scopes"></param>
        /// <param name="created"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectKeysV1ResponseApiKeysItemsApiKey(
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
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeysItemsApiKey" /> class.
        /// </summary>
        public ListProjectKeysV1ResponseApiKeysItemsApiKey()
        {
        }

    }
}