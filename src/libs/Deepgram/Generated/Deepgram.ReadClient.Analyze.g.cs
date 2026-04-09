
#nullable enable

namespace Deepgram
{
    public partial class ReadClient
    {


        private static readonly global::Deepgram.EndPointSecurityRequirement s_AnalyzeSecurityRequirement0 =
            new global::Deepgram.EndPointSecurityRequirement
            {
                Authorizations = new global::Deepgram.EndPointAuthorizationRequirement[]
                {                    new global::Deepgram.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Deepgram.EndPointSecurityRequirement[] s_AnalyzeSecurityRequirements =
            new global::Deepgram.EndPointSecurityRequirement[]
            {                s_AnalyzeSecurityRequirement0,
            };
        partial void PrepareAnalyzeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? callback,
            ref global::Deepgram.ReadV1TextAnalyzeCallbackMethod? callbackMethod,
            ref bool? sentiment,
            ref global::Deepgram.OneOf<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>? summarize,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag,
            ref bool? topics,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic,
            ref global::Deepgram.ReadV1TextAnalyzeCustomTopicMode? customTopicMode,
            ref bool? intents,
            ref global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent,
            ref global::Deepgram.ReadV1TextAnalyzeCustomIntentMode? customIntentMode,
            ref string? language,
            global::Deepgram.ReadV1Request request);
        partial void PrepareAnalyzeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? callback,
            global::Deepgram.ReadV1TextAnalyzeCallbackMethod? callbackMethod,
            bool? sentiment,
            global::Deepgram.OneOf<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>? summarize,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? tag,
            bool? topics,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customTopic,
            global::Deepgram.ReadV1TextAnalyzeCustomTopicMode? customTopicMode,
            bool? intents,
            global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>? customIntent,
            global::Deepgram.ReadV1TextAnalyzeCustomIntentMode? customIntentMode,
            string? language,
            global::Deepgram.ReadV1Request request);
        partial void ProcessAnalyzeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAnalyzeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.ReadV1Response> AnalyzeAsync(

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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAnalyzeArguments(
                httpClient: HttpClient,
                callback: ref callback,
                callbackMethod: ref callbackMethod,
                sentiment: ref sentiment,
                summarize: ref summarize,
                tag: ref tag,
                topics: ref topics,
                customTopic: ref customTopic,
                customTopicMode: ref customTopicMode,
                intents: ref intents,
                customIntent: ref customIntent,
                customIntentMode: ref customIntentMode,
                language: ref language,
                request: request);


            var __authorizations = global::Deepgram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AnalyzeSecurityRequirements,
                operationName: "AnalyzeAsync");

            var __pathBuilder = new global::Deepgram.PathBuilder(
                path: "/v1/read",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("callback", callback)
                .AddOptionalParameter("callback_method", callbackMethod?.ToValueString())
                .AddOptionalParameter("sentiment", sentiment?.ToString().ToLowerInvariant())
                .AddOptionalParameter("summarize", summarize?.ToString())
                .AddOptionalParameter("tag", tag?.ToString())
                .AddOptionalParameter("topics", topics?.ToString().ToLowerInvariant())
                .AddOptionalParameter("custom_topic", customTopic?.ToString())
                .AddOptionalParameter("custom_topic_mode", customTopicMode?.ToValueString())
                .AddOptionalParameter("intents", intents?.ToString().ToLowerInvariant())
                .AddOptionalParameter("custom_intent", customIntent?.ToString())
                .AddOptionalParameter("custom_intent_mode", customIntentMode?.ToValueString())
                .AddOptionalParameter("language", language) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAnalyzeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                callback: callback,
                callbackMethod: callbackMethod,
                sentiment: sentiment,
                summarize: summarize,
                tag: tag,
                topics: topics,
                customTopic: customTopic,
                customTopicMode: customTopicMode,
                intents: intents,
                customIntent: customIntent,
                customIntentMode: customIntentMode,
                language: language,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAnalyzeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Deepgram.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Deepgram.ApiException<global::Deepgram.ErrorResponse?>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAnalyzeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Deepgram.ReadV1Response.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Deepgram.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Deepgram.ReadV1Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Deepgram.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.ReadV1Response> AnalyzeAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Deepgram.ReadV1Request
            {
            };

            return await AnalyzeAsync(
                callback: callback,
                callbackMethod: callbackMethod,
                sentiment: sentiment,
                summarize: summarize,
                tag: tag,
                topics: topics,
                customTopic: customTopic,
                customTopicMode: customTopicMode,
                intents: intents,
                customIntent: customIntent,
                customIntentMode: customIntentMode,
                language: language,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}