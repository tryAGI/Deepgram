
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectKeysV1ResponseApiKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        public global::Deepgram.ListProjectKeysV1ResponseApiKeyMember? Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Deepgram.ListProjectKeysV1ResponseApiKeyApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKey" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="apiKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectKeysV1ResponseApiKey(
            global::Deepgram.ListProjectKeysV1ResponseApiKeyMember? member,
            global::Deepgram.ListProjectKeysV1ResponseApiKeyApiKey? apiKey)
        {
            this.Member = member;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKey" /> class.
        /// </summary>
        public ListProjectKeysV1ResponseApiKey()
        {
        }
    }
}