
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeakV2SpeakV2SpeechInterrupted
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2SpeechInterruptedTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterruptedType Type { get; set; }

        /// <summary>
        /// How much audio the client had played when the interrupt landed, in milliseconds from the start of the session. Echoes the `Interrupt`'s `playback_offset` when one was supplied. Otherwise it is the server's own total, representing the audio that has been generated so far. A client that sends its first `Interrupt` without an offset can use this value as the baseline the next one must advance past.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_played_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioPlayedMs { get; set; }

        /// <summary>
        /// The portion of the turn's text the user heard. Omitted when the `Interrupt` carried no `playback_offset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_spoken")]
        public string? TextSpoken { get; set; }

        /// <summary>
        /// The portion of the turn's text the user did not hear. Omitted when the `Interrupt` carried no `playback_offset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_remaining")]
        public string? TextRemaining { get; set; }

        /// <summary>
        /// Billing and timing for a single turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SpeechInterrupted" /> class.
        /// </summary>
        /// <param name="audioPlayedMs">
        /// How much audio the client had played when the interrupt landed, in milliseconds from the start of the session. Echoes the `Interrupt`'s `playback_offset` when one was supplied. Otherwise it is the server's own total, representing the audio that has been generated so far. A client that sends its first `Interrupt` without an offset can use this value as the baseline the next one must advance past.
        /// </param>
        /// <param name="metadata">
        /// Billing and timing for a single turn.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="textSpoken">
        /// The portion of the turn's text the user heard. Omitted when the `Interrupt` carried no `playback_offset`.
        /// </param>
        /// <param name="textRemaining">
        /// The portion of the turn's text the user did not hear. Omitted when the `Interrupt` carried no `playback_offset`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2SpeechInterrupted(
            int audioPlayedMs,
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2SpeechInterruptedMetadata metadata,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterruptedType type,
            string? textSpoken,
            string? textRemaining)
        {
            this.Type = type;
            this.AudioPlayedMs = audioPlayedMs;
            this.TextSpoken = textSpoken;
            this.TextRemaining = textRemaining;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2SpeechInterrupted" /> class.
        /// </summary>
        public SpeakV2SpeakV2SpeechInterrupted()
        {
        }

    }
}