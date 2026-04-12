
#nullable enable

namespace Deepgram
{
    public partial class SubpackageReadSubpackageReadV1SubpackageReadV1TextClient
    {

        private static readonly global::Deepgram.AutoSDKServer[] s_AnalyzeServers = new global::Deepgram.AutoSDKServer[]
        {            new global::Deepgram.AutoSDKServer(
                id: "https-api-deepgram-com",
                name: "api.deepgram.com",
                url: "https://api.deepgram.com/",
                description: ""),
            new global::Deepgram.AutoSDKServer(
                id: "https-agent-deepgram-com",
                name: "agent.deepgram.com",
                url: "https://agent.deepgram.com/",
                description: ""),
        };


        private static readonly global::Deepgram.EndPointSecurityRequirement s_AnalyzeSecurityRequirement0 =
            new global::Deepgram.EndPointSecurityRequirement
            {
                Authorizations = new global::Deepgram.EndPointAuthorizationRequirement[]
                {                    new global::Deepgram.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
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
            ref global::Deepgram.V1ReadPostParametersCallbackMethod? callbackMethod,
            ref bool? sentiment,
            ref global::Deepgram.V1ReadPostParametersSummarize? summarize,
            ref global::Deepgram.V1ReadPostParametersTag? tag,
            ref bool? topics,
            ref global::Deepgram.V1ReadPostParametersCustomTopic? customTopic,
            ref global::Deepgram.V1ReadPostParametersCustomTopicMode? customTopicMode,
            ref bool? intents,
            ref global::Deepgram.V1ReadPostParametersCustomIntent? customIntent,
            ref global::Deepgram.V1ReadPostParametersCustomIntentMode? customIntentMode,
            ref string? language,
            global::Deepgram.ReadV1Request request);
        partial void PrepareAnalyzeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? callback,
            global::Deepgram.V1ReadPostParametersCallbackMethod? callbackMethod,
            bool? sentiment,
            global::Deepgram.V1ReadPostParametersSummarize? summarize,
            global::Deepgram.V1ReadPostParametersTag? tag,
            bool? topics,
            global::Deepgram.V1ReadPostParametersCustomTopic? customTopic,
            global::Deepgram.V1ReadPostParametersCustomTopicMode? customTopicMode,
            bool? intents,
            global::Deepgram.V1ReadPostParametersCustomIntent? customIntent,
            global::Deepgram.V1ReadPostParametersCustomIntentMode? customIntentMode,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.ReadV1Response> AnalyzeAsync(

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

            using var __timeoutCancellationTokenSource = global::Deepgram.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Deepgram.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Deepgram.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Deepgram.PathBuilder(
                                path: "/v1/read",
                                baseUri: ResolveBaseUri(
                                servers: s_AnalyzeServers,
                                defaultBaseUrl: "https://api.deepgram.com/")); 
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
                __path = global::Deepgram.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Deepgram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

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

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/v1/read\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/v1/read\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Deepgram.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/v1/read\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessAnalyzeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/v1/read\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/v1/read\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Deepgram.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Deepgram.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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
                                        __effectiveCancellationToken
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
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.ReadV1Response> AnalyzeAsync(
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
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}