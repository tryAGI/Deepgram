
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedTopicsResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::Deepgram.SharedTopicsResultsTopics? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResults" /> class.
        /// </summary>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedTopicsResults(
            global::Deepgram.SharedTopicsResultsTopics? topics)
        {
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopicsResults" /> class.
        /// </summary>
        public SharedTopicsResults()
        {
        }

    }
}