
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDistributionCredentialsV1ResponseDistributionCredentials
    {
        /// <summary>
        /// Unique identifier for the distribution credentials<br/>
        /// Example: 82c32c10-53b2-4d23-993f-864b3d44502a
        /// </summary>
        /// <example>82c32c10-53b2-4d23-993f-864b3d44502a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_credentials_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DistributionCredentialsId { get; set; }

        /// <summary>
        /// The provider of the distribution service<br/>
        /// Example: quay
        /// </summary>
        /// <example>quay</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Optional comment about the credentials<br/>
        /// Example: My Self-Hosted Distribution Credentials
        /// </summary>
        /// <example>My Self-Hosted Distribution Credentials</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// List of permission scopes for the credentials<br/>
        /// Example: [self-hosted:product:api, self-hosted:product:engine]
        /// </summary>
        /// <example>[self-hosted:product:api, self-hosted:product:engine]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Timestamp when the credentials were created<br/>
        /// Example: 2023-06-28T15:36:59.609841Z
        /// </summary>
        /// <example>2023-06-28T15:36:59.609841Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDistributionCredentialsV1ResponseDistributionCredentials" /> class.
        /// </summary>
        /// <param name="distributionCredentialsId">
        /// Unique identifier for the distribution credentials<br/>
        /// Example: 82c32c10-53b2-4d23-993f-864b3d44502a
        /// </param>
        /// <param name="provider">
        /// The provider of the distribution service<br/>
        /// Example: quay
        /// </param>
        /// <param name="comment">
        /// Optional comment about the credentials<br/>
        /// Example: My Self-Hosted Distribution Credentials
        /// </param>
        /// <param name="scopes">
        /// List of permission scopes for the credentials<br/>
        /// Example: [self-hosted:product:api, self-hosted:product:engine]
        /// </param>
        /// <param name="created">
        /// Timestamp when the credentials were created<br/>
        /// Example: 2023-06-28T15:36:59.609841Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDistributionCredentialsV1ResponseDistributionCredentials(
            global::System.Guid distributionCredentialsId,
            string provider,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.DateTime created,
            string? comment)
        {
            this.DistributionCredentialsId = distributionCredentialsId;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Created = created;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDistributionCredentialsV1ResponseDistributionCredentials" /> class.
        /// </summary>
        public GetProjectDistributionCredentialsV1ResponseDistributionCredentials()
        {
        }
    }
}