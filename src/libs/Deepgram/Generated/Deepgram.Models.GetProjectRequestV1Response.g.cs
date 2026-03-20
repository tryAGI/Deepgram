
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectRequestV1Response
    {
        /// <summary>
        /// A single request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Deepgram.ProjectRequestResponse? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectRequestV1Response" /> class.
        /// </summary>
        /// <param name="request">
        /// A single request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectRequestV1Response(
            global::Deepgram.ProjectRequestResponse? request)
        {
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectRequestV1Response" /> class.
        /// </summary>
        public GetProjectRequestV1Response()
        {
        }
    }
}