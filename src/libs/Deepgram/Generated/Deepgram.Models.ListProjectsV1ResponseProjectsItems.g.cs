
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectsV1ResponseProjectsItems
    {
        /// <summary>
        /// The unique identifier of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

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
        /// Initializes a new instance of the <see cref="ListProjectsV1ResponseProjectsItems" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The unique identifier of the project
        /// </param>
        /// <param name="name">
        /// The name of the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectsV1ResponseProjectsItems(
            string? projectId,
            string? name)
        {
            this.ProjectId = projectId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectsV1ResponseProjectsItems" /> class.
        /// </summary>
        public ListProjectsV1ResponseProjectsItems()
        {
        }

    }
}