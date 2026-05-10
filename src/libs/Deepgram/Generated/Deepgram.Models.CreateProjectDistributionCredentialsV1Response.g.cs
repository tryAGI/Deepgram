
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectDistributionCredentialsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.CreateProjectDistributionCredentialsV1ResponseMember Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.CreateProjectDistributionCredentialsV1ResponseDistributionCredentials DistributionCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectDistributionCredentialsV1Response" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="distributionCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectDistributionCredentialsV1Response(
            global::Deepgram.CreateProjectDistributionCredentialsV1ResponseMember member,
            global::Deepgram.CreateProjectDistributionCredentialsV1ResponseDistributionCredentials distributionCredentials)
        {
            this.Member = member ?? throw new global::System.ArgumentNullException(nameof(member));
            this.DistributionCredentials = distributionCredentials ?? throw new global::System.ArgumentNullException(nameof(distributionCredentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectDistributionCredentialsV1Response" /> class.
        /// </summary>
        public CreateProjectDistributionCredentialsV1Response()
        {
        }

    }
}