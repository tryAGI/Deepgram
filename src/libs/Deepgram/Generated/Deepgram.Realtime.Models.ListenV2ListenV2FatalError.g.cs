
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV2ListenV2FatalError
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2FatalErrorTypeJsonConverter))]
        public global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2FatalErrorType Type { get; set; }

        /// <summary>
        /// Starts at `0` and increments for each message the server sends<br/>
        /// to the client.  This includes messages of other types, like<br/>
        /// `Connected` messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SequenceId { get; set; }

        /// <summary>
        /// A string code describing the error, e.g. `INTERNAL_SERVER_ERROR`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Prose description of the error
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
        /// Initializes a new instance of the <see cref="ListenV2ListenV2FatalError" /> class.
        /// </summary>
        /// <param name="sequenceId">
        /// Starts at `0` and increments for each message the server sends<br/>
        /// to the client.  This includes messages of other types, like<br/>
        /// `Connected` messages.
        /// </param>
        /// <param name="code">
        /// A string code describing the error, e.g. `INTERNAL_SERVER_ERROR`
        /// </param>
        /// <param name="description">
        /// Prose description of the error
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ListenV2FatalError(
            double sequenceId,
            string code,
            string description,
            global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2FatalErrorType type)
        {
            this.Type = type;
            this.SequenceId = sequenceId;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2FatalError" /> class.
        /// </summary>
        public ListenV2ListenV2FatalError()
        {
        }
    }
}