
#nullable enable

namespace Deepgram
{
    public partial class ManageClient
    {
        partial void PrepareManageV1ProjectsRequestsListArguments(
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
        partial void PrepareManageV1ProjectsRequestsListRequest(
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
        partial void ProcessManageV1ProjectsRequestsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessManageV1ProjectsRequestsListResponseContent(
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.ListProjectRequestsV1Response> ManageV1ProjectsRequestsListAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareManageV1ProjectsRequestsListArguments(
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

            var __pathBuilder = new global::Deepgram.PathBuilder(
                path: $"/v1/projects/{projectId}/requests",
                baseUri: HttpClient.BaseAddress); 
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareManageV1ProjectsRequestsListRequest(
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessManageV1ProjectsRequestsListResponse(
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
                ProcessManageV1ProjectsRequestsListResponseContent(
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
                        cancellationToken
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
    }
}