
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponseModernError
    {
        /// <summary>
        /// The category of the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// A message about the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// A description of the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseModernError" /> class.
        /// </summary>
        /// <param name="category">
        /// The category of the error
        /// </param>
        /// <param name="message">
        /// A message about the error
        /// </param>
        /// <param name="details">
        /// A description of the error
        /// </param>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponseModernError(
            string? category,
            string? message,
            string? details,
            string? requestId)
        {
            this.Category = category;
            this.Message = message;
            this.Details = details;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseModernError" /> class.
        /// </summary>
        public ErrorResponseModernError()
        {
        }

    }
}