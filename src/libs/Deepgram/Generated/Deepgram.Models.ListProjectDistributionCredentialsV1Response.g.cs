
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectDistributionCredentialsV1Response
    {
        /// <summary>
        /// Array of distribution credentials with associated member information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials")]
        public global::System.Collections.Generic.IList<global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems>? DistributionCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1Response" /> class.
        /// </summary>
        /// <param name="distributionCredentials">
        /// Array of distribution credentials with associated member information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectDistributionCredentialsV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems>? distributionCredentials)
        {
            this.DistributionCredentials = distributionCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectDistributionCredentialsV1Response" /> class.
        /// </summary>
        public ListProjectDistributionCredentialsV1Response()
        {
        }
    }
}