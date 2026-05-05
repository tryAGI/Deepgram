#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentVariablesClient
    {
        /// <summary>
        /// Update an Agent Variable<br/>
        /// Updates the value of an existing template variable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="variableId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentVariableV1> UpdateAsync(
            string projectId,
            string variableId,

            global::Deepgram.UpdateAgentVariableV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent Variable<br/>
        /// Updates the value of an existing template variable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="variableId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.AgentVariableV1>> UpdateAsResponseAsync(
            string projectId,
            string variableId,

            global::Deepgram.UpdateAgentVariableV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent Variable<br/>
        /// Updates the value of an existing template variable
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="variableId"></param>
        /// <param name="value">
        /// The new value to substitute
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentVariableV1> UpdateAsync(
            string projectId,
            string variableId,
            object value,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}