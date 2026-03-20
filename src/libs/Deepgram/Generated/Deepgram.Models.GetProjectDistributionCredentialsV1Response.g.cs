
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDistributionCredentialsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.GetProjectDistributionCredentialsV1ResponseMember Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.GetProjectDistributionCredentialsV1ResponseDistributionCredentials DistributionCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDistributionCredentialsV1Response" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="distributionCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDistributionCredentialsV1Response(
            global::Deepgram.GetProjectDistributionCredentialsV1ResponseMember member,
            global::Deepgram.GetProjectDistributionCredentialsV1ResponseDistributionCredentials distributionCredentials)
        {
            this.Member = member ?? throw new global::System.ArgumentNullException(nameof(member));
            this.DistributionCredentials = distributionCredentials ?? throw new global::System.ArgumentNullException(nameof(distributionCredentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDistributionCredentialsV1Response" /> class.
        /// </summary>
        public GetProjectDistributionCredentialsV1Response()
        {
        }
    }
}