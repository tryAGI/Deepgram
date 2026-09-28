
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenV2ListenV2ConfigureFailure
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureFailureTypeJsonConverter))]
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailureType Type { get; set; }

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Starts at `0` and increments for each message the server sends<br/>
        /// to the client.  This includes messages of other types, like<br/>
        /// `TurnInfo` messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceId { get; set; }

        /// <summary>
        /// Failure code identifying the rejected configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable description of the configuration failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2ConfigureFailure" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="sequenceId">
        /// Starts at `0` and increments for each message the server sends<br/>
        /// to the client.  This includes messages of other types, like<br/>
        /// `TurnInfo` messages.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="code">
        /// Failure code identifying the rejected configuration
        /// </param>
        /// <param name="description">
        /// A human-readable description of the configuration failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ListenV2ConfigureFailure(
            global::System.Guid requestId,
            int sequenceId,
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailureType type,
            string? code,
            string? description)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.SequenceId = sequenceId;
            this.Code = code;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2ConfigureFailure" /> class.
        /// </summary>
        public ListenV2ListenV2ConfigureFailure()
        {
        }

    }
}