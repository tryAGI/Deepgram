
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ListenV1Results
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ResultsTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsType Type { get; set; }

        /// <summary>
        /// The index of the channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> ChannelIndex { get; set; }

        /// <summary>
        /// The duration of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The start time of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Whether the transcription is final
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Whether the transcription is speech final
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_final")]
        public bool? SpeechFinal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannel Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsMetadata Metadata { get; set; }

        /// <summary>
        /// Whether the transcription is from a finalize message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_finalize")]
        public bool? FromFinalize { get; set; }

        /// <summary>
        /// Extracted entities from the audio when detect_entities is enabled. Only present in is_final messages. Returns an empty array if no entities are detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsEntitiesItems>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1Results" /> class.
        /// </summary>
        /// <param name="channelIndex">
        /// The index of the channel
        /// </param>
        /// <param name="duration">
        /// The duration of the transcription
        /// </param>
        /// <param name="start">
        /// The start time of the transcription
        /// </param>
        /// <param name="channel"></param>
        /// <param name="metadata"></param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="isFinal">
        /// Whether the transcription is final
        /// </param>
        /// <param name="speechFinal">
        /// Whether the transcription is speech final
        /// </param>
        /// <param name="fromFinalize">
        /// Whether the transcription is from a finalize message
        /// </param>
        /// <param name="entities">
        /// Extracted entities from the audio when detect_entities is enabled. Only present in is_final messages. Returns an empty array if no entities are detected
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1Results(
            global::System.Collections.Generic.IList<double> channelIndex,
            double duration,
            double start,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannel channel,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsMetadata metadata,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsType type,
            bool? isFinal,
            bool? speechFinal,
            bool? fromFinalize,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsEntitiesItems>? entities)
        {
            this.Type = type;
            this.ChannelIndex = channelIndex ?? throw new global::System.ArgumentNullException(nameof(channelIndex));
            this.Duration = duration;
            this.Start = start;
            this.IsFinal = isFinal;
            this.SpeechFinal = speechFinal;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.FromFinalize = fromFinalize;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1Results" /> class.
        /// </summary>
        public ListenV1ListenV1Results()
        {
        }
    }
}