
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2SessionMetadata
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2SessionMetadataTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadataType Type { get; set; }

        /// <summary>
        /// Cumulative audio duration produced across the session, in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAudioDurationMs { get; set; }

        /// <summary>
        /// Cumulative raw input character count across the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputCharacterCount { get; set; }

        /// <summary>
        /// Cumulative billable character count across the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_billable_character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalBillableCharacterCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SessionMetadata" /> class.
        /// </summary>
        /// <param name="totalAudioDurationMs">
        /// Cumulative audio duration produced across the session, in milliseconds
        /// </param>
        /// <param name="totalInputCharacterCount">
        /// Cumulative raw input character count across the session
        /// </param>
        /// <param name="totalBillableCharacterCount">
        /// Cumulative billable character count across the session
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2SessionMetadata(
            int totalAudioDurationMs,
            int totalInputCharacterCount,
            int totalBillableCharacterCount,
            global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadataType type)
        {
            this.Type = type;
            this.TotalAudioDurationMs = totalAudioDurationMs;
            this.TotalInputCharacterCount = totalInputCharacterCount;
            this.TotalBillableCharacterCount = totalBillableCharacterCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SessionMetadata" /> class.
        /// </summary>
        public SpeakV2SpeakV2SessionMetadata()
        {
        }

    }
}