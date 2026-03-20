
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectDistributionCredentialsV1ResponseDistributionCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialDistributionCredentials DistributionCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredential" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="distributionCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectDistributionCredentialsV1ResponseDistributionCredential(
            global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember member,
            global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialDistributionCredentials distributionCredentials)
        {
            this.Member = member ?? throw new global::System.ArgumentNullException(nameof(member));
            this.DistributionCredentials = distributionCredentials ?? throw new global::System.ArgumentNullException(nameof(distributionCredentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredential" /> class.
        /// </summary>
        public ListProjectDistributionCredentialsV1ResponseDistributionCredential()
        {
        }
    }
}