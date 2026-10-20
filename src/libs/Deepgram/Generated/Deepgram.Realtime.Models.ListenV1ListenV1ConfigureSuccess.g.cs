
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV1ListenV1ConfigureSuccess
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ConfigureSuccessTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType Type { get; set; }

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// The keyterms now in effect. Present only when the `Configure` replaced them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1ConfigureSuccess" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="keyterms">
        /// The keyterms now in effect. Present only when the `Configure` replaced them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1ConfigureSuccess(
            global::System.Guid requestId,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureSuccessType type,
            global::System.Collections.Generic.IList<string>? keyterms)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.Keyterms = keyterms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1ConfigureSuccess" /> class.
        /// </summary>
        public ListenV1ListenV1ConfigureSuccess()
        {
        }

    }
}