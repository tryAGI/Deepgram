
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV1MetadataEvent
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1MetadataEventTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV1MetadataEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Name of the model being used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Version of the primary model being used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelVersion { get; set; }

        /// <summary>
        /// Unique identifier for the primary model used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ModelUuid { get; set; }

        /// <summary>
        /// List of unique identifiers for any additional models used to serve the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_model_uuids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AdditionalModelUuids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1MetadataEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="modelName">
        /// Name of the model being used
        /// </param>
        /// <param name="modelVersion">
        /// Version of the primary model being used
        /// </param>
        /// <param name="modelUuid">
        /// Unique identifier for the primary model used
        /// </param>
        /// <param name="additionalModelUuids">
        /// List of unique identifiers for any additional models used to serve the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV1MetadataEvent(
            global::System.Guid requestId,
            string modelName,
            string modelVersion,
            global::System.Guid modelUuid,
            global::Deepgram.Realtime.SpeakV1MetadataEventType type,
            global::System.Collections.Generic.IList<global::System.Guid>? additionalModelUuids)
        {
            this.RequestId = requestId;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ModelVersion = modelVersion ?? throw new global::System.ArgumentNullException(nameof(modelVersion));
            this.ModelUuid = modelUuid;
            this.Type = type;
            this.AdditionalModelUuids = additionalModelUuids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV1MetadataEvent" /> class.
        /// </summary>
        public SpeakV1MetadataEvent()
        {
        }
    }
}