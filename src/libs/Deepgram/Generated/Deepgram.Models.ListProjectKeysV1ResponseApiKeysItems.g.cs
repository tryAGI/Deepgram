
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectKeysV1ResponseApiKeysItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        public global::Deepgram.ListProjectKeysV1ResponseApiKeysItemsMember? Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Deepgram.ListProjectKeysV1ResponseApiKeysItemsApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeysItems" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="apiKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectKeysV1ResponseApiKeysItems(
            global::Deepgram.ListProjectKeysV1ResponseApiKeysItemsMember? member,
            global::Deepgram.ListProjectKeysV1ResponseApiKeysItemsApiKey? apiKey)
        {
            this.Member = member;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1ResponseApiKeysItems" /> class.
        /// </summary>
        public ListProjectKeysV1ResponseApiKeysItems()
        {
        }

    }
}