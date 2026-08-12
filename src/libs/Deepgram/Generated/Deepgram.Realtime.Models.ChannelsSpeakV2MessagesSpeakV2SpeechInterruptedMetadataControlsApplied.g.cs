
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Counts of the inline controls the server acted on during the turn. Inline pause and pronunciation controls are not applied at launch — support is coming soon — so every count is currently `0`.
    /// </summary>
    public sealed partial class ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied
    {
        /// <summary>
        /// Pronunciation overrides successfully applied. Mirrors the Aura-2 `dg-pronunciations-applied` REST header. Currently always `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciations_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PronunciationsApplied { get; set; }

        /// <summary>
        /// Pause (break) controls successfully applied. Mirrors the Aura-2 `dg-breaks-applied` REST header. Currently always `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breaks_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BreaksApplied { get; set; }

        /// <summary>
        /// Pronunciation entries that triggered a warning (invalid IPA, word too long). Mirrors the Aura-2 `dg-pronunciation-warnings` REST header. Currently always `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PronunciationWarnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied" /> class.
        /// </summary>
        /// <param name="pronunciationsApplied">
        /// Pronunciation overrides successfully applied. Mirrors the Aura-2 `dg-pronunciations-applied` REST header. Currently always `0`.
        /// </param>
        /// <param name="breaksApplied">
        /// Pause (break) controls successfully applied. Mirrors the Aura-2 `dg-breaks-applied` REST header. Currently always `0`.
        /// </param>
        /// <param name="pronunciationWarnings">
        /// Pronunciation entries that triggered a warning (invalid IPA, word too long). Mirrors the Aura-2 `dg-pronunciation-warnings` REST header. Currently always `0`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied(
            int pronunciationsApplied,
            int breaksApplied,
            int pronunciationWarnings)
        {
            this.PronunciationsApplied = pronunciationsApplied;
            this.BreaksApplied = breaksApplied;
            this.PronunciationWarnings = pronunciationWarnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied" /> class.
        /// </summary>
        public ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied()
        {
        }

    }
}