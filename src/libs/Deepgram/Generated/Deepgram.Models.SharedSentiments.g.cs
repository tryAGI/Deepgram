
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Output whenever `sentiment=true` is used
    /// </summary>
    public sealed partial class SharedSentiments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Deepgram.SharedSentimentsSegmentsItems>? Segments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        public global::Deepgram.SharedSentimentsAverage? Average { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentiments" /> class.
        /// </summary>
        /// <param name="segments"></param>
        /// <param name="average"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSentiments(
            global::System.Collections.Generic.IList<global::Deepgram.SharedSentimentsSegmentsItems>? segments,
            global::Deepgram.SharedSentimentsAverage? average)
        {
            this.Segments = segments;
            this.Average = average;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSentiments" /> class.
        /// </summary>
        public SharedSentiments()
        {
        }

    }
}