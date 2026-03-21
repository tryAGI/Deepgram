
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Sent when a Configure message was successfully applied.
    /// </summary>
    public sealed partial class V2ConfigureSuccessPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        /// <default>"ConfigureSuccess"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ConfigureSuccess";

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Incremental server message counter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SequenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConfigureSuccessPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="sequenceId">
        /// Incremental server message counter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2ConfigureSuccessPayload(
            global::System.Guid requestId,
            double sequenceId,
            string type = "ConfigureSuccess")
        {
            this.RequestId = requestId;
            this.SequenceId = sequenceId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConfigureSuccessPayload" /> class.
        /// </summary>
        public V2ConfigureSuccessPayload()
        {
        }
    }
}