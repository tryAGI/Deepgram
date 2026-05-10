
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_value")]
        public string? RawValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="rawValue"></param>
        /// <param name="confidence"></param>
        /// <param name="startWord"></param>
        /// <param name="endWord"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems(
            string? label,
            string? value,
            string? rawValue,
            double? confidence,
            double? startWord,
            double? endWord)
        {
            this.Label = label;
            this.Value = value;
            this.RawValue = rawValue;
            this.Confidence = confidence;
            this.StartWord = startWord;
            this.EndWord = endWord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems" /> class.
        /// </summary>
        public ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems()
        {
        }

    }
}