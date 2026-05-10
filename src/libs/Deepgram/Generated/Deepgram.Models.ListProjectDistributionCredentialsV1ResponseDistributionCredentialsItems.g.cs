
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsDistributionCredentials DistributionCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="distributionCredentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems(
            global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember member,
            global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsDistributionCredentials distributionCredentials)
        {
            this.Member = member ?? throw new global::System.ArgumentNullException(nameof(member));
            this.DistributionCredentials = distributionCredentials ?? throw new global::System.ArgumentNullException(nameof(distributionCredentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems" /> class.
        /// </summary>
        public ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems()
        {
        }

    }
}