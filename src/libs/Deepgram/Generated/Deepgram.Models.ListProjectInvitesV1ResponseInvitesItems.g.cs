
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectInvitesV1ResponseInvitesItems
    {
        /// <summary>
        /// The email address of the invitee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The scope of the invitee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectInvitesV1ResponseInvitesItems" /> class.
        /// </summary>
        /// <param name="email">
        /// The email address of the invitee
        /// </param>
        /// <param name="scope">
        /// The scope of the invitee
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectInvitesV1ResponseInvitesItems(
            string? email,
            string? scope)
        {
            this.Email = email;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectInvitesV1ResponseInvitesItems" /> class.
        /// </summary>
        public ListProjectInvitesV1ResponseInvitesItems()
        {
        }

    }
}