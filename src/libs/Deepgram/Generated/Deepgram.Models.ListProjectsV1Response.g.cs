
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectsV1ResponseProject>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsV1Response" /> class.
        /// </summary>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectsV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectsV1ResponseProject>? projects)
        {
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsV1Response" /> class.
        /// </summary>
        public ListProjectsV1Response()
        {
        }
    }
}