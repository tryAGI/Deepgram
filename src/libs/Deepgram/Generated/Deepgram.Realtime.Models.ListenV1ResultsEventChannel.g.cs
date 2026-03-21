
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ResultsEventChannel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternatives")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternatives> Alternatives { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsEventChannel" /> class.
        /// </summary>
        /// <param name="alternatives"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResultsEventChannel(
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternatives> alternatives)
        {
            this.Alternatives = alternatives ?? throw new global::System.ArgumentNullException(nameof(alternatives));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsEventChannel" /> class.
        /// </summary>
        public ListenV1ResultsEventChannel()
        {
        }
    }
}