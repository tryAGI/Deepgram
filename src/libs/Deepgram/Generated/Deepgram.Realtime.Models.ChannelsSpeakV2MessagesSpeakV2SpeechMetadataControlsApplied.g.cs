
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Controls applied during the turn. Inline pronunciation and pause controls are not available during Early Access, so every count is currently `0`.
    /// </summary>
    public sealed partial class ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied
    {
        /// <summary>
        /// Pronunciation overrides successfully applied. Mirrors the Aura-2 `dg-pronunciations-applied` REST header. Always `0` during Early Access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciations_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PronunciationsApplied { get; set; }

        /// <summary>
        /// Pronunciation entries that triggered a warning (invalid IPA, word too long). Mirrors the Aura-2 `dg-pronunciation-warnings` REST header. Always `0` during Early Access.
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
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied" /> class.
        /// </summary>
        /// <param name="pronunciationsApplied">
        /// Pronunciation overrides successfully applied. Mirrors the Aura-2 `dg-pronunciations-applied` REST header. Always `0` during Early Access.
        /// </param>
        /// <param name="pronunciationWarnings">
        /// Pronunciation entries that triggered a warning (invalid IPA, word too long). Mirrors the Aura-2 `dg-pronunciation-warnings` REST header. Always `0` during Early Access.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied(
            int pronunciationsApplied,
            int pronunciationWarnings)
        {
            this.PronunciationsApplied = pronunciationsApplied;
            this.PronunciationWarnings = pronunciationWarnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied" /> class.
        /// </summary>
        public ChannelsSpeakV2MessagesSpeakV2SpeechMetadataControlsApplied()
        {
        }

    }
}