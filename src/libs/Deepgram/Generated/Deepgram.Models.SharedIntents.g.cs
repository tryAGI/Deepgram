
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Output whenever `intents=true` is used
    /// </summary>
    public sealed partial class SharedIntents
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsSegmentsItems>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntents" /> class.
        /// </summary>
        /// <param name="segments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedIntents(
            global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsSegmentsItems>? segments)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntents" /> class.
        /// </summary>
        public SharedIntents()
        {
        }

    }
}