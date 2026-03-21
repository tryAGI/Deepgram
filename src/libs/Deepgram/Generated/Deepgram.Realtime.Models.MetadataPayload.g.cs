
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.MetadataPayloadTypeJsonConverter))]
        public global::Deepgram.Realtime.MetadataPayloadType Type { get; set; }

        /// <summary>
        /// The request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// SHA256 hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Created { get; set; }

        /// <summary>
        /// Audio duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Number of audio channels
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
        /// Initializes a new instance of the <see cref="MetadataPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="requestId">
        /// The request ID
        /// </param>
        /// <param name="sha256">
        /// SHA256 hash
        /// </param>
        /// <param name="created">
        /// Creation timestamp
        /// </param>
        /// <param name="duration">
        /// Audio duration in seconds
        /// </param>
        /// <param name="channels">
        /// Number of audio channels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataPayload(
            global::System.Guid requestId,
            string sha256,
            string created,
            double duration,
            double channels,
            global::Deepgram.Realtime.MetadataPayloadType type)
        {
            this.RequestId = requestId;
            this.Sha256 = sha256 ?? throw new global::System.ArgumentNullException(nameof(sha256));
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Duration = duration;
            this.Channels = channels;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataPayload" /> class.
        /// </summary>
        public MetadataPayload()
        {
        }
    }
}