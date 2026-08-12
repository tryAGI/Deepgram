
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Interrupt
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2InterruptTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2InterruptType Type { get; set; }

        /// <summary>
        /// How much audio the client had played when the user barged in. Optional: without it the server cannot split the turn's text, so `SpeechInterrupted` omits `text_spoken` and `text_remaining`.<br/>
        /// The offset is cumulative from the start of the *session*, not from the start of the current turn. Each `Interrupt` must advance past the position the previous one established.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playback_offset")]
        public global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset? PlaybackOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Interrupt" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="playbackOffset">
        /// How much audio the client had played when the user barged in. Optional: without it the server cannot split the turn's text, so `SpeechInterrupted` omits `text_spoken` and `text_remaining`.<br/>
        /// The offset is cumulative from the start of the *session*, not from the start of the current turn. Each `Interrupt` must advance past the position the previous one established.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Interrupt(
            global::Deepgram.Realtime.SpeakV2SpeakV2InterruptType type,
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset? playbackOffset)
        {
            this.Type = type;
            this.PlaybackOffset = playbackOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Interrupt" /> class.
        /// </summary>
        public SpeakV2SpeakV2Interrupt()
        {
        }

    }
}