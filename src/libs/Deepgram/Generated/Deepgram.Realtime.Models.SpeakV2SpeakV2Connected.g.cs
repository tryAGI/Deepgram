
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Connected
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2ConnectedTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConnectedType Type { get; set; }

        /// <summary>
        /// The unique identifier of the `/v2/speak` request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Resolved model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Resolved model version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelVersion { get; set; }

        /// <summary>
        /// Resolved model UUIDs. A list, because a resolved model may be backed by more than one underlying model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ModelUuids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Connected" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the `/v2/speak` request
        /// </param>
        /// <param name="modelName">
        /// Resolved model name
        /// </param>
        /// <param name="modelVersion">
        /// Resolved model version
        /// </param>
        /// <param name="modelUuids">
        /// Resolved model UUIDs. A list, because a resolved model may be backed by more than one underlying model.
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Connected(
            global::System.Guid requestId,
            string modelName,
            string modelVersion,
            global::System.Collections.Generic.IList<global::System.Guid> modelUuids,
            global::Deepgram.Realtime.SpeakV2SpeakV2ConnectedType type)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ModelVersion = modelVersion ?? throw new global::System.ArgumentNullException(nameof(modelVersion));
            this.ModelUuids = modelUuids ?? throw new global::System.ArgumentNullException(nameof(modelUuids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Connected" /> class.
        /// </summary>
        public SpeakV2SpeakV2Connected()
        {
        }

    }
}