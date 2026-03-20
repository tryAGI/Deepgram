
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedTopicsResultsTopicsSegment
    {
        /// <summary>
        /// Example: And, um, I think if it signifies anything, it is, uh, to honor the the women who came before us who, um, were skilled and qualified, um, and didn't get the the same opportunities that we have today.
        /// </summary>
        /// <example>And, um, I think if it signifies anything, it is, uh, to honor the the women who came before us who, um, were skilled and qualified, um, and didn't get the the same opportunities that we have today.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_word")]
        public double? StartWord { get; set; }

        /// <summary>
        /// Example: 69
        /// </summary>
        /// <example>69</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_word")]
        public double? EndWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentTopic>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResultsTopicsSegment" /> class.
        /// </summary>
        /// <param name="text">
        /// Example: And, um, I think if it signifies anything, it is, uh, to honor the the women who came before us who, um, were skilled and qualified, um, and didn't get the the same opportunities that we have today.
        /// </param>
        /// <param name="startWord">
        /// Example: 32
        /// </param>
        /// <param name="endWord">
        /// Example: 69
        /// </param>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedTopicsResultsTopicsSegment(
            string? text,
            double? startWord,
            double? endWord,
            global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentTopic>? topics)
        {
            this.Text = text;
            this.StartWord = startWord;
            this.EndWord = endWord;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResultsTopicsSegment" /> class.
        /// </summary>
        public SharedTopicsResultsTopicsSegment()
        {
        }
    }
}