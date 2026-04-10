#nullable enable

namespace Deepgram
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Token-based Authentication<br/>
        /// Generates a temporary JSON Web Token (JWT) with a 30-second (by default) TTL and usage::write permission for core voice APIs, requiring an API key with Member or higher authorization. Tokens created with this endpoint will not work with the Manage APIs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GrantV1Response> GrantAsync(

            global::Deepgram.GrantV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Token-based Authentication<br/>
        /// Generates a temporary JSON Web Token (JWT) with a 30-second (by default) TTL and usage::write permission for core voice APIs, requiring an API key with Member or higher authorization. Tokens created with this endpoint will not work with the Manage APIs.
        /// </summary>
        /// <param name="ttlSeconds">
        /// Time to live in seconds for the token. Defaults to 30 seconds.<br/>
        /// Example: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.GrantV1Response> GrantAsync(
            double? ttlSeconds = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}