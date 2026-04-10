#nullable enable

namespace Deepgram
{
    public partial interface IReadClient
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
            global::Deepgram.ReadV1TextAnalyzeCallbackMethod? callbackMethod = default,
            bool? sentiment = default,
            global::Deepgram.OneOf<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>? summarize = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            bool? topics = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic = default,
            global::Deepgram.ReadV1TextAnalyzeCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent = default,
            global::Deepgram.ReadV1TextAnalyzeCustomIntentMode? customIntentMode = default,
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
            global::Deepgram.ReadV1TextAnalyzeCallbackMethod? callbackMethod = default,
            bool? sentiment = default,
            global::Deepgram.OneOf<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>? summarize = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            bool? topics = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic = default,
            global::Deepgram.ReadV1TextAnalyzeCustomTopicMode? customTopicMode = default,
            bool? intents = default,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent = default,
            global::Deepgram.ReadV1TextAnalyzeCustomIntentMode? customIntentMode = default,
            string? language = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}