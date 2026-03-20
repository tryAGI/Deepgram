
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponseLegacyError
    {
        /// <summary>
        /// The error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public string? ErrCode { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrMsg { get; set; }

        /// <summary>
        /// The request ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseLegacyError" /> class.
        /// </summary>
        /// <param name="errCode">
        /// The error code
        /// </param>
        /// <param name="errMsg">
        /// The error message
        /// </param>
        /// <param name="requestId">
        /// The request ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponseLegacyError(
            string? errCode,
            string? errMsg,
            string? requestId)
        {
            this.ErrCode = errCode;
            this.ErrMsg = errMsg;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseLegacyError" /> class.
        /// </summary>
        public ErrorResponseLegacyError()
        {
        }
    }
}