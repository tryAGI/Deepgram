
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems>? Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternatives")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems>? Alternatives { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected_language")]
        public string? DetectedLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItems" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="alternatives"></param>
        /// <param name="detectedLanguage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelsItems(
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems>? search,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems>? alternatives,
            string? detectedLanguage)
        {
            this.Search = search;
            this.Alternatives = alternatives;
            this.DetectedLanguage = detectedLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItems" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelsItems()
        {
        }

    }
}