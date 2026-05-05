#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageVoiceAgentSubpackageVoiceAgentVariablesClient
    {
        /// <summary>
        /// Create an Agent Variable<br/>
        /// Creates a new template variable. Variables follow the `DG_&lt;VARIABLE_NAME&gt;` naming format and can substitute any JSON value in an agent configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentVariableV1> CreateAsync(
            string projectId,

            global::Deepgram.CreateAgentVariableV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent Variable<br/>
        /// Creates a new template variable. Variables follow the `DG_&lt;VARIABLE_NAME&gt;` naming format and can substitute any JSON value in an agent configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.AgentVariableV1>> CreateAsResponseAsync(
            string projectId,

            global::Deepgram.CreateAgentVariableV1Request request,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent Variable<br/>
        /// Creates a new template variable. Variables follow the `DG_&lt;VARIABLE_NAME&gt;` naming format and can substitute any JSON value in an agent configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="key">
        /// The variable name, following the DG_&lt;VARIABLE_NAME&gt; format
        /// </param>
        /// <param name="value">
        /// The value to substitute. Can be any valid JSON type (string, number, boolean, object, or array)
        /// </param>
        /// <param name="apiVersion">
        /// API version. Defaults to 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AgentVariableV1> CreateAsync(
            string projectId,
            string key,
            object value,
            int? apiVersion = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}