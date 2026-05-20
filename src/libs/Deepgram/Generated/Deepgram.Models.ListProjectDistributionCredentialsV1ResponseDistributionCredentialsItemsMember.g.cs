
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember
    {
        /// <summary>
        /// Unique identifier for the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemberId { get; set; }

        /// <summary>
        /// Email address of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember" /> class.
        /// </summary>
        /// <param name="memberId">
        /// Unique identifier for the member
        /// </param>
        /// <param name="email">
        /// Email address of the member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember(
            global::System.Guid memberId,
            string email)
        {
            this.MemberId = memberId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember" /> class.
        /// </summary>
        public ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember()
        {
        }

    }
}