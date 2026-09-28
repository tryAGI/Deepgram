
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
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsSegmentsItems>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopics" /> class.
        /// </summary>
        /// <param name="segments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedTopics(
            global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsSegmentsItems>? segments)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedTopics" /> class.
        /// </summary>
        public SharedTopics()
        {
        }

    }
}