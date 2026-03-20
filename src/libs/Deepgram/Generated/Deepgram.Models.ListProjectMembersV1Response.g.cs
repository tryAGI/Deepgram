
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectMembersV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectMembersV1ResponseMember>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectMembersV1Response" /> class.
        /// </summary>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectMembersV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectMembersV1ResponseMember>? members)
        {
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectMembersV1Response" /> class.
        /// </summary>
        public ListProjectMembersV1Response()
        {
        }
    }
}