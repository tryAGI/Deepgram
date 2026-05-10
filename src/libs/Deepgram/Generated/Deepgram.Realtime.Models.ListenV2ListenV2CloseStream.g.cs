
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV2ListenV2CloseStream
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2CloseStreamTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2CloseStreamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2CloseStream" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ListenV2CloseStream(
            global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2CloseStreamType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2CloseStream" /> class.
        /// </summary>
        public ListenV2ListenV2CloseStream()
        {
        }

    }
}