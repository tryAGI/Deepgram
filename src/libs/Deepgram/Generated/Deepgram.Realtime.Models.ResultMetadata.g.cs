
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultMetadata
    {
        /// <summary>
        /// The request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ModelInfo ModelInfo { get; set; }

        /// <summary>
        /// The model UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultMetadata" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The request ID
        /// </param>
        /// <param name="modelInfo"></param>
        /// <param name="modelUuid">
        /// The model UUID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultMetadata(
            string requestId,
            global::Deepgram.Realtime.ModelInfo modelInfo,
            string modelUuid)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ModelInfo = modelInfo ?? throw new global::System.ArgumentNullException(nameof(modelInfo));
            this.ModelUuid = modelUuid ?? throw new global::System.ArgumentNullException(nameof(modelUuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultMetadata" /> class.
        /// </summary>
        public ResultMetadata()
        {
        }
    }
}