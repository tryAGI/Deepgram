
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1ListenV1CloseStream
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1CloseStreamTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1CloseStreamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1CloseStream" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1CloseStream(
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1CloseStreamType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1CloseStream" /> class.
        /// </summary>
        public ListenV1ListenV1CloseStream()
        {
        }

    }
}