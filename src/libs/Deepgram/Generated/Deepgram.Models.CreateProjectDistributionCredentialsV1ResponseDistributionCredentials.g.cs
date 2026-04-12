
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectDistributionCredentialsV1ResponseDistributionCredentials
    {
        /// <summary>
        /// Unique identifier for the distribution credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DistributionCredentialsId { get; set; }

        /// <summary>
        /// The provider of the distribution service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Optional comment about the credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// List of permission scopes for the credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Timestamp when the credentials were created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectDistributionCredentialsV1ResponseDistributionCredentials" /> class.
        /// </summary>
        /// <param name="distributionCredentialsId">
        /// Unique identifier for the distribution credentials
        /// </param>
        /// <param name="provider">
        /// The provider of the distribution service
        /// </param>
        /// <param name="scopes">
        /// List of permission scopes for the credentials
        /// </param>
        /// <param name="created">
        /// Timestamp when the credentials were created
        /// </param>
        /// <param name="comment">
        /// Optional comment about the credentials
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectDistributionCredentialsV1ResponseDistributionCredentials(
            global::System.Guid distributionCredentialsId,
            string provider,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.DateTime created,
            string? comment)
        {
            this.DistributionCredentialsId = distributionCredentialsId;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Comment = comment;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectDistributionCredentialsV1ResponseDistributionCredentials" /> class.
        /// </summary>
        public CreateProjectDistributionCredentialsV1ResponseDistributionCredentials()
        {
        }
    }
}