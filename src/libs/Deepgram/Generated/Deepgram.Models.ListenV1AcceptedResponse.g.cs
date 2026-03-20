
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Accepted response for asynchronous transcription requests
    /// </summary>
    public sealed partial class ListenV1AcceptedResponse
    {
        /// <summary>
        /// Unique identifier for tracking the asynchronous request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1AcceptedResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for tracking the asynchronous request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1AcceptedResponse(
            global::System.Guid requestId)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1AcceptedResponse" /> class.
        /// </summary>
        public ListenV1AcceptedResponse()
        {
        }
    }
}