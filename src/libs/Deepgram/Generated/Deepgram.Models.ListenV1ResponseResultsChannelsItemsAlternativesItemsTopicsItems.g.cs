
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_word")]
        public double? StartWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_word")]
        public double? EndWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startWord"></param>
        /// <param name="endWord"></param>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems(
            string? text,
            double? startWord,
            double? endWord,
            global::System.Collections.Generic.IList<string>? topics)
        {
            this.Text = text;
            this.StartWord = startWord;
            this.EndWord = endWord;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems()
        {
        }

    }
}