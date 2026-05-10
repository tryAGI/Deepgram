
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Output whenever `topics=true` is used
    /// </summary>
    public sealed partial class SharedTopics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::Deepgram.SharedTopicsResults? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopics" /> class.
        /// </summary>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedTopics(
            global::Deepgram.SharedTopicsResults? results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopics" /> class.
        /// </summary>
        public SharedTopics()
        {
        }

    }
}