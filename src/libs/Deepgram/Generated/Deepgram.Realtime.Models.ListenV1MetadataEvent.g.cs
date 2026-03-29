
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListenV1MetadataEvent
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV1MetadataEventTypeJsonConverter))]
        public global::Deepgram.Realtime.ListenV1MetadataEventType Type { get; set; }

        /// <summary>
        /// The transaction key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionKey { get; set; }

        /// <summary>
        /// The request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// The sha256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// The created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Created { get; set; }

        /// <summary>
        /// The duration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The channels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1MetadataEvent" /> class.
        /// </summary>
        /// <param name="transactionKey">
        /// The transaction key
        /// </param>
        /// <param name="requestId">
        /// The request ID
        /// </param>
        /// <param name="sha256">
        /// The sha256
        /// </param>
        /// <param name="created">
        /// The created
        /// </param>
        /// <param name="duration">
        /// The duration
        /// </param>
        /// <param name="channels">
        /// The channels
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1MetadataEvent(
            string transactionKey,
            global::System.Guid requestId,
            string sha256,
            string created,
            double duration,
            double channels,
            global::Deepgram.Realtime.ListenV1MetadataEventType type)
        {
            this.Type = type;
            this.TransactionKey = transactionKey ?? throw new global::System.ArgumentNullException(nameof(transactionKey));
            this.RequestId = requestId;
            this.Sha256 = sha256 ?? throw new global::System.ArgumentNullException(nameof(sha256));
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Duration = duration;
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1MetadataEvent" /> class.
        /// </summary>
        public ListenV1MetadataEvent()
        {
        }
    }
}