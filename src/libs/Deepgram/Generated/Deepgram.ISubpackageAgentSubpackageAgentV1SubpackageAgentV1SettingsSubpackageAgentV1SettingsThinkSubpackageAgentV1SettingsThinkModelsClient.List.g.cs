#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageAgentSubpackageAgentV1SubpackageAgentV1SettingsSubpackageAgentV1SettingsThinkSubpackageAgentV1SettingsThinkModelsClient
    {
        /// <summary>
        /// List Agent Think Models<br/>
        /// Retrieves the available think models that can be used for AI agent processing
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentThinkModelsV1Response> ListAsync(
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Think Models<br/>
        /// Retrieves the available think models that can be used for AI agent processing
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.AgentThinkModelsV1Response>> ListAsResponseAsync(
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}