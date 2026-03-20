
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Request body for creating a project invite
    /// </summary>
    public sealed partial class CreateProjectInviteV1Request
    {
        /// <summary>
        /// The email address of the invitee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The scope of the invitee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectInviteV1Request" /> class.
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
        public CreateProjectInviteV1Request(
            string email,
            string scope)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectInviteV1Request" /> class.
        /// </summary>
        public CreateProjectInviteV1Request()
        {
        }
    }
}