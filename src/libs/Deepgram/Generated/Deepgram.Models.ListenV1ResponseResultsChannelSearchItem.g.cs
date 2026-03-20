
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelSearchItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelSearchItemHit>? Hits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelSearchItem" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="hits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelSearchItem(
            string? query,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelSearchItemHit>? hits)
        {
            this.Query = query;
            this.Hits = hits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelSearchItem" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelSearchItem()
        {
        }
    }
}