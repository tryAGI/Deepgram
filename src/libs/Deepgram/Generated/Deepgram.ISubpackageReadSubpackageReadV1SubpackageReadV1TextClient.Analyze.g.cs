#nullable enable

namespace Deepgram
{
    public partial interface ISubpackageReadSubpackageReadV1SubpackageReadV1TextClient
    {
        /// <summary>
        /// Analyze text content<br/>
        /// Analyze text content using Deepgrams text analysis API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="sentiment">
        /// Default Value: false
        /// </param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics">
        /// Default Value: false
        /// </param>
        /// <param name="customTopic"></param>
        /// <param name="customTopicMode">
        /// Default Value: extended
        /// </param>
        /// <param name="intents">
        /// Default Value: false
        /// </param>
        /// <param name="customIntent"></param>
        /// <param name="customIntentMode">
        /// Default Value: extended
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ReadV1Response> AnalyzeAsync(

            global::Deepgram.ReadV1Request request,
            string? callback = default,
            global::Deepgram.V1ReadPostParametersCallbackMethod? callbackMethod = default,
            bool? sentiment = default,
            global::Deepgram.V1ReadPostParametersSummarize? summarize = default,
            global::Deepgram.V1ReadPostParametersTag? tag = default,
            bool? topics = default,
            global::Deepgram.V1ReadPostParametersCustomTopic? customTopic = default,
            global::Deepgram.V1ReadPostParametersCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.V1ReadPostParametersCustomIntent? customIntent = default,
            global::Deepgram.V1ReadPostParametersCustomIntentMode? customIntentMode = default,
            string? language = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyze text content<br/>
        /// Analyze text content using Deepgrams text analysis API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="sentiment">
        /// Default Value: false
        /// </param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics">
        /// Default Value: false
        /// </param>
        /// <param name="customTopic"></param>
        /// <param name="customTopicMode">
        /// Default Value: extended
        /// </param>
        /// <param name="intents">
        /// Default Value: false
        /// </param>
        /// <param name="customIntent"></param>
        /// <param name="customIntentMode">
        /// Default Value: extended
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.ReadV1Response>> AnalyzeAsResponseAsync(

            global::Deepgram.ReadV1Request request,
            string? callback = default,
            global::Deepgram.V1ReadPostParametersCallbackMethod? callbackMethod = default,
            bool? sentiment = default,
            global::Deepgram.V1ReadPostParametersSummarize? summarize = default,
            global::Deepgram.V1ReadPostParametersTag? tag = default,
            bool? topics = default,
            global::Deepgram.V1ReadPostParametersCustomTopic? customTopic = default,
            global::Deepgram.V1ReadPostParametersCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.V1ReadPostParametersCustomIntent? customIntent = default,
            global::Deepgram.V1ReadPostParametersCustomIntentMode? customIntentMode = default,
            string? language = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyze text content<br/>
        /// Analyze text content using Deepgrams text analysis API
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="sentiment">
        /// Default Value: false
        /// </param>
        /// <param name="summarize"></param>
        /// <param name="tag"></param>
        /// <param name="topics">
        /// Default Value: false
        /// </param>
        /// <param name="customTopic"></param>
        /// <param name="customTopicMode">
        /// Default Value: extended
        /// </param>
        /// <param name="intents">
        /// Default Value: false
        /// </param>
        /// <param name="customIntent"></param>
        /// <param name="customIntentMode">
        /// Default Value: extended
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Deepgram.ReadV1Response> AnalyzeAsync(
            string? callback = default,
            global::Deepgram.V1ReadPostParametersCallbackMethod? callbackMethod = default,
            bool? sentiment = default,
            global::Deepgram.V1ReadPostParametersSummarize? summarize = default,
            global::Deepgram.V1ReadPostParametersTag? tag = default,
            bool? topics = default,
            global::Deepgram.V1ReadPostParametersCustomTopic? customTopic = default,
            global::Deepgram.V1ReadPostParametersCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.V1ReadPostParametersCustomIntent? customIntent = default,
            global::Deepgram.V1ReadPostParametersCustomIntentMode? customIntentMode = default,
            string? language = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}