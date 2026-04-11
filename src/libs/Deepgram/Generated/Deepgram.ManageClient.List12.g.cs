
#nullable enable

namespace Deepgram
{
    public partial class ManageClient
    {


        private static readonly global::Deepgram.EndPointSecurityRequirement s_List12SecurityRequirement0 =
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
        private static readonly global::Deepgram.EndPointSecurityRequirement[] s_List12SecurityRequirements =
            new global::Deepgram.EndPointSecurityRequirement[]
            {                s_List12SecurityRequirement0,
            };
        partial void PrepareList12Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime? start,
            ref global::System.DateTime? end,
            ref double? limit,
            ref double? page,
            ref string? accessor,
            ref string? requestId,
            ref global::Deepgram.ManageV1ProjectsRequestsListDeployment? deployment,
            ref global::Deepgram.ManageV1ProjectsRequestsListEndpoint? endpoint,
            ref global::Deepgram.ManageV1ProjectsRequestsListMethod? method,
            ref global::Deepgram.ManageV1ProjectsRequestsListStatus? status,
            ref string projectId);
        partial void PrepareList12Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? start,
            global::System.DateTime? end,
            double? limit,
            double? page,
            string? accessor,
            string? requestId,
            global::Deepgram.ManageV1ProjectsRequestsListDeployment? deployment,
            global::Deepgram.ManageV1ProjectsRequestsListEndpoint? endpoint,
            global::Deepgram.ManageV1ProjectsRequestsListMethod? method,
            global::Deepgram.ManageV1ProjectsRequestsListStatus? status,
            string projectId);
        partial void ProcessList12Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList12ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Project Requests<br/>
        /// Generates a list of requests for a specific project
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="page"></param>
        /// <param name="accessor"></param>
        /// <param name="requestId"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="endpoint"></param>
        /// <param name="method">
        /// Method type for the request
        /// </param>
        /// <param name="status"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.ListProjectRequestsV1Response> List12Async(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            double? limit = default,
            double? page = default,
            string? accessor = default,
            string? requestId = default,
            global::Deepgram.ManageV1ProjectsRequestsListDeployment? deployment = default,
            global::Deepgram.ManageV1ProjectsRequestsListEndpoint? endpoint = default,
            global::Deepgram.ManageV1ProjectsRequestsListMethod? method = default,
            global::Deepgram.ManageV1ProjectsRequestsListStatus? status = default,
            global::Deepgram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareList12Arguments(
                httpClient: HttpClient,
                start: ref start,
                end: ref end,
                limit: ref limit,
                page: ref page,
                accessor: ref accessor,
                requestId: ref requestId,
                deployment: ref deployment,
                endpoint: ref endpoint,
                method: ref method,
                status: ref status,
                projectId: ref projectId);


            var __authorizations = global::Deepgram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_List12SecurityRequirements,
                operationName: "List12Async");

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
                                path: $"/v1/projects/{projectId}/requests",
                                baseUri: HttpClient.BaseAddress ?? new global::System.Uri("https://api.deepgram.com/", global::System.UriKind.RelativeOrAbsolute)); 
                            __pathBuilder
                                .AddOptionalParameter("start", start?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("end", end?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("accessor", accessor)
                                .AddOptionalParameter("request_id", requestId)
                                .AddOptionalParameter("deployment", deployment?.ToValueString())
                                .AddOptionalParameter("endpoint", endpoint?.ToValueString())
                                .AddOptionalParameter("method", method?.ToValueString())
                                .AddOptionalParameter("status", status?.ToValueString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Deepgram.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Deepgram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareList12Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    start: start,
                    end: end,
                    limit: limit,
                    page: page,
                    accessor: accessor,
                    requestId: requestId,
                    deployment: deployment,
                    endpoint: endpoint,
                    method: method,
                    status: status,
                    projectId: projectId);

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
                                operationId: "List12",
                                methodName: "List12Async",
                                pathTemplate: "$\"/v1/projects/{projectId}/requests\"",
                                httpMethod: "GET",
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
                                operationId: "List12",
                                methodName: "List12Async",
                                pathTemplate: "$\"/v1/projects/{projectId}/requests\"",
                                httpMethod: "GET",
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
                                operationId: "List12",
                                methodName: "List12Async",
                                pathTemplate: "$\"/v1/projects/{projectId}/requests\"",
                                httpMethod: "GET",
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
                ProcessList12Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Deepgram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Deepgram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List12",
                                methodName: "List12Async",
                                pathTemplate: "$\"/v1/projects/{projectId}/requests\"",
                                httpMethod: "GET",
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
                                operationId: "List12",
                                methodName: "List12Async",
                                pathTemplate: "$\"/v1/projects/{projectId}/requests\"",
                                httpMethod: "GET",
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
                                ProcessList12ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Deepgram.ListProjectRequestsV1Response.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::Deepgram.ListProjectRequestsV1Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}