
#nullable enable

namespace Deepgram
{
    public partial class ManageClient
    {
        partial void PrepareManageV1ProjectsBillingBreakdownListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime? start,
            ref global::System.DateTime? end,
            ref string? accessor,
            ref global::Deepgram.ManageV1ProjectsBillingBreakdownListDeployment? deployment,
            ref string? tag,
            ref string? lineItem,
            global::System.Collections.Generic.IList<global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem>? grouping,
            ref string projectId);
        partial void PrepareManageV1ProjectsBillingBreakdownListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? accessor,
            global::Deepgram.ManageV1ProjectsBillingBreakdownListDeployment? deployment,
            string? tag,
            string? lineItem,
            global::System.Collections.Generic.IList<global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem>? grouping,
            string projectId);
        partial void ProcessManageV1ProjectsBillingBreakdownListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessManageV1ProjectsBillingBreakdownListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Project Billing Breakdown<br/>
        /// Retrieves the billing summary for a specific project, with various filter options or by grouping options.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="accessor"></param>
        /// <param name="deployment">
        /// Deployment type for the requests
        /// </param>
        /// <param name="tag"></param>
        /// <param name="lineItem"></param>
        /// <param name="grouping"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Deepgram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Deepgram.BillingBreakdownV1Response> ManageV1ProjectsBillingBreakdownListAsync(
            string projectId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? accessor = default,
            global::Deepgram.ManageV1ProjectsBillingBreakdownListDeployment? deployment = default,
            string? tag = default,
            string? lineItem = default,
            global::System.Collections.Generic.IList<global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem>? grouping = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareManageV1ProjectsBillingBreakdownListArguments(
                httpClient: HttpClient,
                start: ref start,
                end: ref end,
                accessor: ref accessor,
                deployment: ref deployment,
                tag: ref tag,
                lineItem: ref lineItem,
                grouping: grouping,
                projectId: ref projectId);

            var __pathBuilder = new global::Deepgram.PathBuilder(
                path: $"/v1/projects/{projectId}/billing/breakdown",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("start", start?.ToString("yyyy-MM-dd"))
                .AddOptionalParameter("end", end?.ToString("yyyy-MM-dd"))
                .AddOptionalParameter("accessor", accessor)
                .AddOptionalParameter("deployment", deployment?.ToValueString())
                .AddOptionalParameter("tag", tag)
                .AddOptionalParameter("line_item", lineItem)
                .AddOptionalParameter("grouping", grouping, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
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
            PrepareManageV1ProjectsBillingBreakdownListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                start: start,
                end: end,
                accessor: accessor,
                deployment: deployment,
                tag: tag,
                lineItem: lineItem,
                grouping: grouping,
                projectId: projectId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessManageV1ProjectsBillingBreakdownListResponse(
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
                ProcessManageV1ProjectsBillingBreakdownListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Deepgram.BillingBreakdownV1Response.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Deepgram.BillingBreakdownV1Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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