#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsClient
    {
        /// <summary>
        /// Create a Project Self-Hosted Distribution Credential<br/>
        /// Creates a set of distribution credentials for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="scopes"></param>
        /// <param name="provider">
        /// Default Value: quay
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateProjectDistributionCredentialsV1Response> CreateAsync(
            string projectId,

            global::Deepgram.CreateProjectDistributionCredentialsV1Request request,
            global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>? scopes = default,
            global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider? provider = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Project Self-Hosted Distribution Credential<br/>
        /// Creates a set of distribution credentials for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="scopes"></param>
        /// <param name="provider">
        /// Default Value: quay
        /// </param>
        /// <param name="comment">
        /// Optional comment about the credentials
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateProjectDistributionCredentialsV1Response> CreateAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>? scopes = default,
            global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider? provider = default,
            string? comment = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}