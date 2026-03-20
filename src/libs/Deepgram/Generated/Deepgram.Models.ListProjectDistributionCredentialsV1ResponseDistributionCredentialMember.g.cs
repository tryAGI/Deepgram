
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember
    {
        /// <summary>
        /// Unique identifier for the member<br/>
        /// Example: 3376abcd-8e5e-49d3-92d4-876d3a4f0363
        /// </summary>
        /// <example>3376abcd-8e5e-49d3-92d4-876d3a4f0363</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemberId { get; set; }

        /// <summary>
        /// Email address of the member<br/>
        /// Example: email@example.com
        /// </summary>
        /// <example>email@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember" /> class.
        /// </summary>
        /// <param name="memberId">
        /// Unique identifier for the member<br/>
        /// Example: 3376abcd-8e5e-49d3-92d4-876d3a4f0363
        /// </param>
        /// <param name="email">
        /// Email address of the member<br/>
        /// Example: email@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember(
            global::System.Guid memberId,
            string email)
        {
            this.MemberId = memberId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember" /> class.
        /// </summary>
        public ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember()
        {
        }
    }
}