#nullable enable

namespace Deepgram
{
    public partial interface ISelfHostedClient
    {

        /// <summary>
        /// Create a Project Self-Hosted Distribution Credential<br/>
        /// Creates a set of distribution credentials for the specified project
        /// </summary>
        /// <param name="scopes">
        /// Default Value: [self-hosted:products]
        /// </param>
        /// <param name="provider">
        /// Default Value: quay
        /// </param>
        /// <param name="projectId"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateProjectDistributionCredentialsV1Response> SelfHostedV1DistributionCredentialsCreateAsync(
            string projectId,

            global::Deepgram.CreateProjectDistributionCredentialsV1Request request,
            global::System.Collections.Generic.IList<global::Deepgram.SelfHostedV1DistributionCredentialsCreateScope>? scopes = default,
            global::Deepgram.SelfHostedV1DistributionCredentialsCreateProvider? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Project Self-Hosted Distribution Credential<br/>
        /// Creates a set of distribution credentials for the specified project
        /// </summary>
        /// <param name="scopes">
        /// Default Value: [self-hosted:products]
        /// </param>
        /// <param name="provider">
        /// Default Value: quay
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="comment">
        /// Optional comment about the credentials
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateProjectDistributionCredentialsV1Response> SelfHostedV1DistributionCredentialsCreateAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::Deepgram.SelfHostedV1DistributionCredentialsCreateScope>? scopes = default,
            global::Deepgram.SelfHostedV1DistributionCredentialsCreateProvider? provider = default,
            string? comment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}