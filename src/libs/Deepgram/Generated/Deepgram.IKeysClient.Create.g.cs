#nullable enable

namespace Deepgram
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Create a Project Key<br/>
        /// Creates a new API key with specified settings for the project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateKeyV1Response> CreateAsync(
            string projectId,

            global::Deepgram.CreateKeyV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Project Key<br/>
        /// Creates a new API key with specified settings for the project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.CreateKeyV1Response>> CreateAsResponseAsync(
            string projectId,

            global::Deepgram.CreateKeyV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Project Key<br/>
        /// Creates a new API key with specified settings for the project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="comment"></param>
        /// <param name="scopes"></param>
        /// <param name="tags"></param>
        /// <param name="expirationDate"></param>
        /// <param name="timeToLiveInSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.CreateKeyV1Response> CreateAsync(
            string projectId,
            string comment,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.DateTime? expirationDate = default,
            double? timeToLiveInSeconds = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}