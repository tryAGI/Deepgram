
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Counts of the inline controls the server acted on during the turn. A pronunciation override that triggers an IPA warning is still applied best-effort and counted in `pronunciations_applied`; the warning is reported separately through a `Warning` and `pronunciation_warnings`.
    /// </summary>
    public sealed partial class ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadataControlsApplied
    {
        /// <summary>
        /// Pronunciation overrides successfully applied. Mirrors the Aura-2 `dg-pronunciations-applied` REST header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciations_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PronunciationsApplied { get; set; }

        /// <summary>
        /// Pause (break) controls successfully applied. Mirrors the Aura-2 `dg-breaks-applied` REST header. Always `0` on the WebSocket, where inline pause controls are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breaks_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BreaksApplied { get; set; }

        /// <summary>
        /// Pronunciation entries that triggered a warning (invalid IPA, word too long). On batch requests the corresponding `PRON-NNN` codes are returned in the `dg-warnings` response header.
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
        /// Pronunciation overrides successfully applied. Mirrors the Aura-2 `dg-pronunciations-applied` REST header.
        /// </param>
        /// <param name="breaksApplied">
        /// Pause (break) controls successfully applied. Mirrors the Aura-2 `dg-breaks-applied` REST header. Always `0` on the WebSocket, where inline pause controls are not supported.
        /// </param>
        /// <param name="pronunciationWarnings">
        /// Pronunciation entries that triggered a warning (invalid IPA, word too long). On batch requests the corresponding `PRON-NNN` codes are returned in the `dg-warnings` response header.
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