
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>? Paragraphs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="paragraphs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs(
            string? transcript,
            global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>? paragraphs)
        {
            this.Transcript = transcript;
            this.Paragraphs = paragraphs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs()
        {
        }
    }
}