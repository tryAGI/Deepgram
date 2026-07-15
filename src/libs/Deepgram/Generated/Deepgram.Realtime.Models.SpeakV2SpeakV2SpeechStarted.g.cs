
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2SpeechStarted
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2SpeechStartedTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStartedType Type { get; set; }

        /// <summary>
        /// Server-minted identifier for this turn, of the form `dg_sp_&lt;12 hex digits&gt;`. Informational.
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
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SpeechStarted" /> class.
        /// </summary>
        /// <param name="speechId">
        /// Server-minted identifier for this turn, of the form `dg_sp_&lt;12 hex digits&gt;`. Informational.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2SpeechStarted(
            string speechId,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStartedType type)
        {
            this.Type = type;
            this.SpeechId = speechId ?? throw new global::System.ArgumentNullException(nameof(speechId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SpeechStarted" /> class.
        /// </summary>
        public SpeakV2SpeakV2SpeechStarted()
        {
        }

    }
}