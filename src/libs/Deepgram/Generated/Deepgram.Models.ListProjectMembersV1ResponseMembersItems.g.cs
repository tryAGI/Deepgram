
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectMembersV1ResponseMembersItems
    {
        /// <summary>
        /// The unique identifier of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_id")]
        public string? MemberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectMembersV1ResponseMembersItems" /> class.
        /// </summary>
        /// <param name="memberId">
        /// The unique identifier of the member
        /// </param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectMembersV1ResponseMembersItems(
            string? memberId,
            string? email)
        {
            this.MemberId = memberId;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectMembersV1ResponseMembersItems" /> class.
        /// </summary>
        public ListProjectMembersV1ResponseMembersItems()
        {
        }
    }
}