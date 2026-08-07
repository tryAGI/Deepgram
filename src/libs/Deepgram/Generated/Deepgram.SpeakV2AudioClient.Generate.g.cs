
#nullable enable

namespace Deepgram
{
    public partial class SpeakV2AudioClient
    {

        private static readonly global::Deepgram.AutoSDKServer[] s_GenerateServers = new global::Deepgram.AutoSDKServer[]
        {            new global::Deepgram.AutoSDKServer(
                id: "https-api-deepgram-com",
                name: "api.deepgram.com",
                url: "https://api.deepgram.com/",
                description: ""),
            new global::Deepgram.AutoSDKServer(
                id: "https-agent-deepgram-com",
                name: "Production",
                url: "https://agent.deepgram.com/",
                description: "Production"),
        };


        private static readonly global::Deepgram.EndPointSecurityRequirement s_GenerateSecurityRequirement0 =
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
        private static readonly global::Deepgram.EndPointSecurityRequirement[] s_GenerateSecurityRequirements =
            new global::Deepgram.EndPointSecurityRequirement[]
            {                s_GenerateSecurityRequirement0,
            };
        partial void PrepareGenerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? callback,
            ref global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod,
            ref bool? mipOptOut,
            ref global::Deepgram.V2SpeakPostParametersTag? tag,
            ref global::Deepgram.V2SpeakPostParametersBitRate? bitRate,
            ref global::Deepgram.V2SpeakPostParametersContainer? container,
            ref global::Deepgram.V2SpeakPostParametersEncoding? encoding,
            ref string model,
            ref global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate,
            ref global::Deepgram.V2SpeakPostParametersPriority? priority,
            global::Deepgram.SpeakV2Request request);
        partial void PrepareGenerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? callback,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod,
            bool? mipOptOut,
            global::Deepgram.V2SpeakPostParametersTag? tag,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate,
            global::Deepgram.V2SpeakPostParametersContainer? container,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding,
            string model,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate,
            global::Deepgram.V2SpeakPostParametersPriority? priority,
            global::Deepgram.SpeakV2Request request);
        partial void ProcessGenerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Flux Text to Speech (batch)<br/>
        /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="tag"></param>
        /// <param name="bitRate">
        /// Default Value: 48000
        /// </param>
        /// <param name="container">
        /// Default Value: wav
        /// </param>
        /// <param name="encoding">
        /// Default Value: mp3
        /// </param>
        /// <param name="model"></param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="priority"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.SpeakV2AcceptedResponse> GenerateAsync(
            string model,

            global::Deepgram.SpeakV2Request request,
            string? callback = default,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V2SpeakPostParametersTag? tag = default,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V2SpeakPostParametersContainer? container = default,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.V2SpeakPostParametersPriority? priority = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GenerateAsResponseAsync(
                model: model,

                request: request,
                callback: callback,
                callbackMethod: callbackMethod,
                mipOptOut: mipOptOut,
                tag: tag,
                bitRate: bitRate,
                container: container,
                encoding: encoding,
                sampleRate: sampleRate,
                priority: priority,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Flux Text to Speech (batch)<br/>
        /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="tag"></param>
        /// <param name="bitRate">
        /// Default Value: 48000
        /// </param>
        /// <param name="container">
        /// Default Value: wav
        /// </param>
        /// <param name="encoding">
        /// Default Value: mp3
        /// </param>
        /// <param name="model"></param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="priority"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.AutoSDKHttpResponse<global::Deepgram.SpeakV2AcceptedResponse>> GenerateAsResponseAsync(
            string model,

            global::Deepgram.SpeakV2Request request,
            string? callback = default,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V2SpeakPostParametersTag? tag = default,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V2SpeakPostParametersContainer? container = default,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.V2SpeakPostParametersPriority? priority = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateArguments(
                httpClient: HttpClient,
                callback: ref callback,
                callbackMethod: ref callbackMethod,
                mipOptOut: ref mipOptOut,
                tag: ref tag,
                bitRate: ref bitRate,
                container: ref container,
                encoding: ref encoding,
                model: ref model,
                sampleRate: ref sampleRate,
                priority: ref priority,
                request: request);


            var __authorizations = global::Deepgram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GenerateSecurityRequirements,
                operationName: "GenerateAsync");

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
                                path: "/v2/speak",
                                baseUri: ResolveBaseUri(
                                servers: s_GenerateServers,
                                defaultBaseUrl: "https://api.deepgram.com/"));
                            __pathBuilder
                                .AddOptionalParameter("callback", callback)
                                .AddOptionalParameter("callback_method", callbackMethod?.ToValueString())
                                .AddOptionalParameter("mip_opt_out", mipOptOut?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("tag", tag?.ToString())
                                .AddOptionalParameter("bit_rate", bitRate?.ToString())
                                .AddOptionalParameter("container", container?.ToString())
                                .AddOptionalParameter("encoding", encoding?.ToString())
                                .AddRequiredParameter("model", model)
                                .AddOptionalParameter("sample_rate", sampleRate?.ToString())
                                .AddOptionalParameter("priority", priority?.ToValueString())
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
                PrepareGenerateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    callback: callback,
                    callbackMethod: callbackMethod,
                    mipOptOut: mipOptOut,
                    tag: tag,
                    bitRate: bitRate,
                    container: container,
                    encoding: encoding,
                    model: model!,
                    sampleRate: sampleRate,
                    priority: priority,
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
                                operationId: "Generate",
                                methodName: "GenerateAsync",
                                pathTemplate: "\"/v2/speak\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::Deepgram.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Generate",
                                methodName: "GenerateAsync",
                                pathTemplate: "\"/v2/speak\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Deepgram.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Deepgram.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Generate",
                                methodName: "GenerateAsync",
                                pathTemplate: "\"/v2/speak\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Deepgram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessGenerateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Generate",
                                methodName: "GenerateAsync",
                                pathTemplate: "\"/v2/speak\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Generate",
                                methodName: "GenerateAsync",
                                pathTemplate: "\"/v2/speak\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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


                                throw global::Deepgram.ApiException<global::Deepgram.ErrorResponse?>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessGenerateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Deepgram.SpeakV2AcceptedResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Deepgram.AutoSDKHttpResponse<global::Deepgram.SpeakV2AcceptedResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Deepgram.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Deepgram.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::Deepgram.SpeakV2AcceptedResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Deepgram.AutoSDKHttpResponse<global::Deepgram.SpeakV2AcceptedResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Deepgram.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::Deepgram.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Flux Text to Speech (batch)<br/>
        /// Synthesize a complete block of text into a single audio response using Deepgram's Flux TTS batch (REST) API. Use this for pre-rendering fixed audio (IVR prompts, notifications, narration) where the whole text is known up front and you don't need incremental playback or interruption.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="callbackMethod">
        /// Default Value: POST
        /// </param>
        /// <param name="mipOptOut">
        /// Default Value: false
        /// </param>
        /// <param name="tag"></param>
        /// <param name="bitRate">
        /// Default Value: 48000
        /// </param>
        /// <param name="container">
        /// Default Value: wav
        /// </param>
        /// <param name="encoding">
        /// Default Value: mp3
        /// </param>
        /// <param name="model"></param>
        /// <param name="sampleRate">
        /// Default Value: 24000
        /// </param>
        /// <param name="priority"></param>
        /// <param name="text">
        /// The text content to be converted to speech. The server normalizes and preprocesses the text (e.g. stripping inline controls) before synthesis.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.SpeakV2AcceptedResponse> GenerateAsync(
            string model,
            string text,
            string? callback = default,
            global::Deepgram.V2SpeakPostParametersCallbackMethod? callbackMethod = default,
            bool? mipOptOut = default,
            global::Deepgram.V2SpeakPostParametersTag? tag = default,
            global::Deepgram.V2SpeakPostParametersBitRate? bitRate = default,
            global::Deepgram.V2SpeakPostParametersContainer? container = default,
            global::Deepgram.V2SpeakPostParametersEncoding? encoding = default,
            global::Deepgram.V2SpeakPostParametersSampleRate? sampleRate = default,
            global::Deepgram.V2SpeakPostParametersPriority? priority = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Deepgram.SpeakV2Request
            {
                Text = text,
            };

            return await GenerateAsync(
                callback: callback,
                callbackMethod: callbackMethod,
                mipOptOut: mipOptOut,
                tag: tag,
                bitRate: bitRate,
                container: container,
                encoding: encoding,
                model: model,
                sampleRate: sampleRate,
                priority: priority,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}