
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ListenV1UtteranceEnd
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1UtteranceEndTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1UtteranceEndType Type { get; set; }

        /// <summary>
        /// The channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Channel { get; set; }

        /// <summary>
        /// The last word end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_word_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastWordEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1UtteranceEnd" /> class.
        /// </summary>
        /// <param name="channel">
        /// The channel
        /// </param>
        /// <param name="lastWordEnd">
        /// The last word end
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1UtteranceEnd(
            global::System.Collections.Generic.IList<int> channel,
            double lastWordEnd,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1UtteranceEndType type)
        {
            this.Type = type;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.LastWordEnd = lastWordEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1UtteranceEnd" /> class.
        /// </summary>
        public ListenV1ListenV1UtteranceEnd()
        {
        }
    }
}