
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for Flux TTS batch (REST) text-to-speech conversion. The full block of text is synthesized in a single request and returned as one audio response.
    /// </summary>
    public sealed partial class SpeakV2Request
    {
        /// <summary>
        /// The text content to be converted to speech. The server normalizes and preprocesses the text before synthesis. May contain inline pause controls (`\{pause:500ms\}`, 500-3000 ms in 100 ms steps, at most 8 per request) and inline pronunciation controls (`\{"word": "...", "pronounce": "&lt;IPA&gt;"\}`, Early Access). Pronunciation cannot be combined with pause or with a `speed` other than `1.0`, and `speed` is capped at `1.15` when a pause is present. See [Speed, Pause, Pronunciation](/docs/tts-voice-controls).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2Request" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content to be converted to speech. The server normalizes and preprocesses the text before synthesis. May contain inline pause controls (`\{pause:500ms\}`, 500-3000 ms in 100 ms steps, at most 8 per request) and inline pronunciation controls (`\{"word": "...", "pronounce": "&lt;IPA&gt;"\}`, Early Access). Pronunciation cannot be combined with pause or with a `speed` other than `1.0`, and `speed` is capped at `1.15` when a pause is present. See [Speed, Pause, Pronunciation](/docs/tts-voice-controls).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2Request(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2Request" /> class.
        /// </summary>
        public SpeakV2Request()
        {
        }

    }
}