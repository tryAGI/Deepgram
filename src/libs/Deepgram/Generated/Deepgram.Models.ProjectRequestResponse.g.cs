
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// A single request
    /// </summary>
    public sealed partial class ProjectRequestResponse
    {
        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The unique identifier of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_uuid")]
        public string? ProjectUuid { get; set; }

        /// <summary>
        /// The date and time the request was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The API path of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The unique identifier of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// The response of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Deepgram.ProjectRequestResponseResponse? Response { get; set; }

        /// <summary>
        /// The response code of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public double? Code { get; set; }

        /// <summary>
        /// The deployment type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        /// <summary>
        /// The callback URL for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRequestResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="projectUuid">
        /// The unique identifier of the project
        /// </param>
        /// <param name="created">
        /// The date and time the request was created
        /// </param>
        /// <param name="path">
        /// The API path of the request
        /// </param>
        /// <param name="apiKeyId">
        /// The unique identifier of the API key
        /// </param>
        /// <param name="response">
        /// The response of the request
        /// </param>
        /// <param name="code">
        /// The response code of the request
        /// </param>
        /// <param name="deployment">
        /// The deployment type
        /// </param>
        /// <param name="callback">
        /// The callback URL for the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRequestResponse(
            string? requestId,
            string? projectUuid,
            global::System.DateTime? created,
            string? path,
            string? apiKeyId,
            global::Deepgram.ProjectRequestResponseResponse? response,
            double? code,
            string? deployment,
            string? callback)
        {
            this.RequestId = requestId;
            this.ProjectUuid = projectUuid;
            this.Created = created;
            this.Path = path;
            this.ApiKeyId = apiKeyId;
            this.Response = response;
            this.Code = code;
            this.Deployment = deployment;
            this.Callback = callback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRequestResponse" /> class.
        /// </summary>
        public ProjectRequestResponse()
        {
        }
    }
}