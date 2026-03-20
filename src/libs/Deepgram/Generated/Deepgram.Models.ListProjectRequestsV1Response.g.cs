
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectRequestsV1Response
    {
        /// <summary>
        /// The page number of the paginated response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public double? Page { get; set; }

        /// <summary>
        /// The number of results per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::System.Collections.Generic.IList<global::Deepgram.ProjectRequestResponse>? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectRequestsV1Response" /> class.
        /// </summary>
        /// <param name="page">
        /// The page number of the paginated response
        /// </param>
        /// <param name="limit">
        /// The number of results per page
        /// </param>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectRequestsV1Response(
            double? page,
            double? limit,
            global::System.Collections.Generic.IList<global::Deepgram.ProjectRequestResponse>? requests)
        {
            this.Page = page;
            this.Limit = limit;
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectRequestsV1Response" /> class.
        /// </summary>
        public ListProjectRequestsV1Response()
        {
        }
    }
}