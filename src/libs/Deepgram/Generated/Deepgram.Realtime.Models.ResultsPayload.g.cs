
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultsPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ResultsPayloadTypeJsonConverter))]
        public global::Deepgram.Realtime.ResultsPayloadType Type { get; set; }

        /// <summary>
        /// The index of the channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> ChannelIndex { get; set; }

        /// <summary>
        /// The duration of the audio segment in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The start time of the audio segment in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Whether this is a final transcription result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Whether this is the final result for the current speech segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_final")]
        public bool? SpeechFinal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.Channel Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ResultMetadata Metadata { get; set; }

        /// <summary>
        /// Whether this result was triggered by a Finalize message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_finalize")]
        public bool? FromFinalize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="channelIndex">
        /// The index of the channel
        /// </param>
        /// <param name="duration">
        /// The duration of the audio segment in seconds
        /// </param>
        /// <param name="start">
        /// The start time of the audio segment in seconds
        /// </param>
        /// <param name="isFinal">
        /// Whether this is a final transcription result
        /// </param>
        /// <param name="speechFinal">
        /// Whether this is the final result for the current speech segment
        /// </param>
        /// <param name="channel"></param>
        /// <param name="metadata"></param>
        /// <param name="fromFinalize">
        /// Whether this result was triggered by a Finalize message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultsPayload(
            global::System.Collections.Generic.IList<double> channelIndex,
            double duration,
            double start,
            global::Deepgram.Realtime.Channel channel,
            global::Deepgram.Realtime.ResultMetadata metadata,
            global::Deepgram.Realtime.ResultsPayloadType type,
            bool? isFinal,
            bool? speechFinal,
            bool? fromFinalize)
        {
            this.ChannelIndex = channelIndex ?? throw new global::System.ArgumentNullException(nameof(channelIndex));
            this.Duration = duration;
            this.Start = start;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Type = type;
            this.IsFinal = isFinal;
            this.SpeechFinal = speechFinal;
            this.FromFinalize = fromFinalize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsPayload" /> class.
        /// </summary>
        public ResultsPayload()
        {
        }
    }
}