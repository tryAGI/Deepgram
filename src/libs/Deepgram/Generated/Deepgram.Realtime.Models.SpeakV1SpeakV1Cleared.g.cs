
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV1SpeakV1Cleared
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1ClearedTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1ClearedType Type { get; set; }

        /// <summary>
        /// The sequence ID of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SequenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1SpeakV1Cleared" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="sequenceId">
        /// The sequence ID of the response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV1SpeakV1Cleared(
            global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1ClearedType type,
            double sequenceId)
        {
            this.Type = type;
            this.SequenceId = sequenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1SpeakV1Cleared" /> class.
        /// </summary>
        public SpeakV1SpeakV1Cleared()
        {
        }
    }
}