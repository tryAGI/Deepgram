
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Flushed
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2FlushedTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2FlushedType Type { get; set; }

        /// <summary>
        /// Server-assigned turn identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Flushed" /> class.
        /// </summary>
        /// <param name="speechId">
        /// Server-assigned turn identifier
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Flushed(
            string speechId,
            global::Deepgram.Realtime.SpeakV2SpeakV2FlushedType type)
        {
            this.Type = type;
            this.SpeechId = speechId ?? throw new global::System.ArgumentNullException(nameof(speechId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Flushed" /> class.
        /// </summary>
        public SpeakV2SpeakV2Flushed()
        {
        }

    }
}