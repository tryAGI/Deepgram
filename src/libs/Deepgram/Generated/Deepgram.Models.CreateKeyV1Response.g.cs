
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// API key created
    /// </summary>
    public sealed partial class CreateKeyV1Response
    {
        /// <summary>
        /// The unique identifier of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// The API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// A comment for the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The scopes for the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// The tags for the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The expiration date of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyV1Response" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// The unique identifier of the API key
        /// </param>
        /// <param name="key">
        /// The API key
        /// </param>
        /// <param name="comment">
        /// A comment for the API key
        /// </param>
        /// <param name="scopes">
        /// The scopes for the API key
        /// </param>
        /// <param name="tags">
        /// The tags for the API key
        /// </param>
        /// <param name="expirationDate">
        /// The expiration date of the API key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKeyV1Response(
            string? apiKeyId,
            string? key,
            string? comment,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? expirationDate)
        {
            this.ApiKeyId = apiKeyId;
            this.Key = key;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Tags = tags;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyV1Response" /> class.
        /// </summary>
        public CreateKeyV1Response()
        {
        }
    }
}