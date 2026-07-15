
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2SpeechMetadata
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2SpeechMetadataTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadataType Type { get; set; }

        /// <summary>
        /// Server-assigned turn identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechId { get; set; }

        /// <summary>
        /// Total audio duration produced for this turn, in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioDurationMs { get; set; }

        /// <summary>
        /// Raw input character count for this turn, before text normalization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputCharacterCount { get; set; }

        /// <summary>
        /// Billable character count for this turn — the input character count with stripped control characters removed. Always less than or equal to `input_character_count`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BillableCharacterCount { get; set; }

        /// <summary>
        /// Controls applied during the turn. Inline pronunciation and pause controls are not available during Early Access, so every count is currently `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied ControlsApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SpeechMetadata" /> class.
        /// </summary>
        /// <param name="speechId">
        /// Server-assigned turn identifier
        /// </param>
        /// <param name="audioDurationMs">
        /// Total audio duration produced for this turn, in milliseconds
        /// </param>
        /// <param name="inputCharacterCount">
        /// Raw input character count for this turn, before text normalization
        /// </param>
        /// <param name="billableCharacterCount">
        /// Billable character count for this turn — the input character count with stripped control characters removed. Always less than or equal to `input_character_count`.
        /// </param>
        /// <param name="controlsApplied">
        /// Controls applied during the turn. Inline pronunciation and pause controls are not available during Early Access, so every count is currently `0`.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2SpeechMetadata(
            string speechId,
            int audioDurationMs,
            int inputCharacterCount,
            int billableCharacterCount,
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied controlsApplied,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadataType type)
        {
            this.Type = type;
            this.SpeechId = speechId ?? throw new global::System.ArgumentNullException(nameof(speechId));
            this.AudioDurationMs = audioDurationMs;
            this.InputCharacterCount = inputCharacterCount;
            this.BillableCharacterCount = billableCharacterCount;
            this.ControlsApplied = controlsApplied ?? throw new global::System.ArgumentNullException(nameof(controlsApplied));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SpeechMetadata" /> class.
        /// </summary>
        public SpeakV2SpeakV2SpeechMetadata()
        {
        }

    }
}