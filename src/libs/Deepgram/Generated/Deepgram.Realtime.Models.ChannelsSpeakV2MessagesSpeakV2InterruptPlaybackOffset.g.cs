
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// How much audio the client had played when the user barged in. Optional: without it the server cannot split the turn's text, so `SpeechInterrupted` omits `text_spoken` and `text_remaining`.<br/>
    /// The offset is cumulative from the start of the *session*, not from the start of the current turn. Each `Interrupt` must advance past the position the previous one established.
    /// </summary>
    public sealed partial class ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset
    {
        /// <summary>
        /// Offset unit. `time_ms` is the only supported form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType Type { get; set; }

        /// <summary>
        /// Milliseconds of session audio the client played before barging in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset" /> class.
        /// </summary>
        /// <param name="value">
        /// Milliseconds of session audio the client played before barging in.
        /// </param>
        /// <param name="type">
        /// Offset unit. `time_ms` is the only supported form.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset(
            int value,
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffsetType type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset" /> class.
        /// </summary>
        public ChannelsSpeakV2MessagesSpeakV2InterruptPlaybackOffset()
        {
        }

    }
}