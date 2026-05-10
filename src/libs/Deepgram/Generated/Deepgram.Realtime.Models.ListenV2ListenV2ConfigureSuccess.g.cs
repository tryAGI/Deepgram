
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV2ListenV2ConfigureSuccess
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureSuccessTypeJsonConverter))]
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccessType Type { get; set; }

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Updates each parameter, if it is supplied. If a particular threshold parameter<br/>
        /// is not supplied, the configuration continues using the currently configured value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds Thresholds { get; set; }

        /// <summary>
        /// Keyterm prompting can improve recognition of specialized terminology.<br/>
        /// Pass multiple keyterm query parameters to boost multiple keyterms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV2KeytermJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ListenV2Keyterm Keyterms { get; set; }

        /// <summary>
        /// The currently active language hints. Only applicable to the flux-general-multi model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// Starts at `0` and increments for each message the server sends<br/>
        /// to the client.  This includes messages of other types, like<br/>
        /// `TurnInfo` messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2ConfigureSuccess" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="thresholds">
        /// Updates each parameter, if it is supplied. If a particular threshold parameter<br/>
        /// is not supplied, the configuration continues using the currently configured value.
        /// </param>
        /// <param name="keyterms">
        /// Keyterm prompting can improve recognition of specialized terminology.<br/>
        /// Pass multiple keyterm query parameters to boost multiple keyterms.
        /// </param>
        /// <param name="sequenceId">
        /// Starts at `0` and increments for each message the server sends<br/>
        /// to the client.  This includes messages of other types, like<br/>
        /// `TurnInfo` messages.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="languageHints">
        /// The currently active language hints. Only applicable to the flux-general-multi model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ListenV2ConfigureSuccess(
            global::System.Guid requestId,
            global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds thresholds,
            global::Deepgram.Realtime.ListenV2Keyterm keyterms,
            int sequenceId,
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccessType type,
            global::System.Collections.Generic.IList<string>? languageHints)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.Thresholds = thresholds ?? throw new global::System.ArgumentNullException(nameof(thresholds));
            this.Keyterms = keyterms;
            this.LanguageHints = languageHints;
            this.SequenceId = sequenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2ConfigureSuccess" /> class.
        /// </summary>
        public ListenV2ListenV2ConfigureSuccess()
        {
        }

    }
}