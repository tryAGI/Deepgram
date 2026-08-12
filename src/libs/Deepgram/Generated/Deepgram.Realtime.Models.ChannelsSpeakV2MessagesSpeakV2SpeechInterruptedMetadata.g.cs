
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Billing and timing for a single turn.
    /// </summary>
    public sealed partial class ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata
    {
        /// <summary>
        /// Server-assigned turn identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechId { get; set; }

        /// <summary>
        /// Audio duration produced for this turn, in milliseconds
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
        /// Counts of the inline controls the server acted on during the turn. Inline pause and pronunciation controls are not applied at launch — support is coming soon — so every count is currently `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied ControlsApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata" /> class.
        /// </summary>
        /// <param name="speechId">
        /// Server-assigned turn identifier
        /// </param>
        /// <param name="audioDurationMs">
        /// Audio duration produced for this turn, in milliseconds
        /// </param>
        /// <param name="inputCharacterCount">
        /// Raw input character count for this turn, before text normalization
        /// </param>
        /// <param name="billableCharacterCount">
        /// Billable character count for this turn — the input character count with stripped control characters removed. Always less than or equal to `input_character_count`.
        /// </param>
        /// <param name="controlsApplied">
        /// Counts of the inline controls the server acted on during the turn. Inline pause and pronunciation controls are not applied at launch — support is coming soon — so every count is currently `0`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata(
            string speechId,
            int audioDurationMs,
            int inputCharacterCount,
            int billableCharacterCount,
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied controlsApplied)
        {
            this.SpeechId = speechId ?? throw new global::System.ArgumentNullException(nameof(speechId));
            this.AudioDurationMs = audioDurationMs;
            this.InputCharacterCount = inputCharacterCount;
            this.BillableCharacterCount = billableCharacterCount;
            this.ControlsApplied = controlsApplied ?? throw new global::System.ArgumentNullException(nameof(controlsApplied));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata" /> class.
        /// </summary>
        public ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata()
        {
        }

    }
}