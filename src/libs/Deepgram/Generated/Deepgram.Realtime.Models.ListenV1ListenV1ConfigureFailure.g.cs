
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV1ListenV1ConfigureFailure
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ConfigureFailureTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureFailureType Type { get; set; }

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Identifies why the `Configure` was rejected.<br/>
        /// - `CONFIGURE_KEYTERMS_NOT_SUPPORTED`: the stream's model does not support mid-stream keyterm updates. Only<br/>
        ///   Nova-3 models do.<br/>
        /// - `CONFIGURE_KEYTERM_LIMIT_EXCEEDED`: the keyterms exceed the 500-token keyterm limit.<br/>
        /// - `CONFIGURE_ALREADY_PENDING`: another `Configure` is still awaiting its response.<br/>
        /// - `CONFIGURE_INTERNAL_ERROR`: the server failed to apply the configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ConfigureFailureCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureFailureCode Code { get; set; }

        /// <summary>
        /// A human-readable explanation of the rejection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1ConfigureFailure" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="code">
        /// Identifies why the `Configure` was rejected.<br/>
        /// - `CONFIGURE_KEYTERMS_NOT_SUPPORTED`: the stream's model does not support mid-stream keyterm updates. Only<br/>
        ///   Nova-3 models do.<br/>
        /// - `CONFIGURE_KEYTERM_LIMIT_EXCEEDED`: the keyterms exceed the 500-token keyterm limit.<br/>
        /// - `CONFIGURE_ALREADY_PENDING`: another `Configure` is still awaiting its response.<br/>
        /// - `CONFIGURE_INTERNAL_ERROR`: the server failed to apply the configuration.
        /// </param>
        /// <param name="description">
        /// A human-readable explanation of the rejection
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ListenV1ConfigureFailure(
            global::System.Guid requestId,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureFailureCode code,
            string description,
            global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ConfigureFailureType type)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.Code = code;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ListenV1ConfigureFailure" /> class.
        /// </summary>
        public ListenV1ListenV1ConfigureFailure()
        {
        }

    }
}