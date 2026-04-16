
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ListenV1SpeechStarted
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1SpeechStartedTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1SpeechStartedType Type { get; set; }

        /// <summary>
        /// The channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Channel { get; set; }

        /// <summary>
        /// The timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1SpeechStarted" /> class.
        /// </summary>
        /// <param name="channel">
        /// The channel
        /// </param>
        /// <param name="timestamp">
        /// The timestamp
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1SpeechStarted(
            global::System.Collections.Generic.IList<int> channel,
            double timestamp,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1SpeechStartedType type)
        {
            this.Type = type;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1SpeechStarted" /> class.
        /// </summary>
        public ListenV1ListenV1SpeechStarted()
        {
        }
    }
}