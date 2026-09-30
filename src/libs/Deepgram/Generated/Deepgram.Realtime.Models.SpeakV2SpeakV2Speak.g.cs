
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Speak
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2SpeakTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeakType Type { get; set; }

        /// <summary>
        /// The input text to synthesize. May contain inline pronunciation controls (`\{"word": "...", "pronounce": "&lt;IPA&gt;"\}`), which are in Early Access. Inline pause controls are supported on the batch (REST) transport only; a pause marker sent over the WebSocket fails the connection with `DATA-0002`. Pronunciation cannot be combined with a `speed` other than `1.0`: text carrying a pronunciation control on a session opened with `speed`, or after a `Configure` that set it, also fails the connection with `DATA-0002`. See [Speed, Pause, Pronunciation](/docs/tts-voice-controls).
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
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Speak" /> class.
        /// </summary>
        /// <param name="text">
        /// The input text to synthesize. May contain inline pronunciation controls (`\{"word": "...", "pronounce": "&lt;IPA&gt;"\}`), which are in Early Access. Inline pause controls are supported on the batch (REST) transport only; a pause marker sent over the WebSocket fails the connection with `DATA-0002`. Pronunciation cannot be combined with a `speed` other than `1.0`: text carrying a pronunciation control on a session opened with `speed`, or after a `Configure` that set it, also fails the connection with `DATA-0002`. See [Speed, Pause, Pronunciation](/docs/tts-voice-controls).
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Speak(
            string text,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeakType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Speak" /> class.
        /// </summary>
        public SpeakV2SpeakV2Speak()
        {
        }

    }
}