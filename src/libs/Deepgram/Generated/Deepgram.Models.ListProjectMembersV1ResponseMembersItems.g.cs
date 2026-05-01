
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
        /// The API scopes of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

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
        /// <param name="scopes">
        /// The API scopes of the member
        /// </param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectMembersV1ResponseMembersItems(
            string? memberId,
            global::System.Collections.Generic.IList<string>? scopes,
            string? email,
            string? firstName,
            string? lastName)
        {
            this.MemberId = memberId;
            this.Scopes = scopes;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectMembersV1ResponseMembersItems" /> class.
        /// </summary>
        public ListProjectMembersV1ResponseMembersItems()
        {
        }
    }
}