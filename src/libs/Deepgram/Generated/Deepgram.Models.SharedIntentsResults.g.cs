
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedIntentsResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intents")]
        public global::Deepgram.SharedIntentsResultsIntents? Intents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResults" /> class.
        /// </summary>
        /// <param name="intents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedIntentsResults(
            global::Deepgram.SharedIntentsResultsIntents? intents)
        {
            this.Intents = intents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedIntentsResults" /> class.
        /// </summary>
        public SharedIntentsResults()
        {
        }
    }
}