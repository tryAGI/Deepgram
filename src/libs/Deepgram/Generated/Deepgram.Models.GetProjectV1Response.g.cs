
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectV1Response
    {
        /// <summary>
        /// The unique identifier of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Model Improvement Program opt-out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mip_opt_out")]
        public bool? MipOptOut { get; set; }

        /// <summary>
        /// The name of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectV1Response" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The unique identifier of the project
        /// </param>
        /// <param name="mipOptOut">
        /// Model Improvement Program opt-out
        /// </param>
        /// <param name="name">
        /// The name of the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectV1Response(
            string? projectId,
            bool? mipOptOut,
            string? name)
        {
            this.ProjectId = projectId;
            this.MipOptOut = mipOptOut;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectV1Response" /> class.
        /// </summary>
        public GetProjectV1Response()
        {
        }

    }
}