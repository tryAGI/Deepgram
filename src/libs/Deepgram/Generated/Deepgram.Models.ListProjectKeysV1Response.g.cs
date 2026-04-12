
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectKeysV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectKeysV1ResponseApiKeysItems>? ApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1Response" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectKeysV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectKeysV1ResponseApiKeysItems>? apiKeys)
        {
            this.ApiKeys = apiKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectKeysV1Response" /> class.
        /// </summary>
        public ListProjectKeysV1Response()
        {
        }
    }
}