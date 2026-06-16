#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsRequestsListCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> Start { get; } = new(
        name: @"--start")
    {
        Description = @"Start date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM",
    };

    private static Option<global::System.DateTime?> End { get; } = new(
        name: @"--end")
    {
        Description = @"End date of the requested date range. Formats accepted are YYYY-MM-DD, YYYY-MM-DDTHH:MM:SS, or YYYY-MM-DDTHH:MM:SS+HH:MM",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of results to return per page. Default 10. Range [1,1000]",
    };

    private static Option<double?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Navigate and return the results to retrieve specific portions of information of the response",
    };

    private static Option<string?> Accessor { get; } = new(
        name: @"--accessor")
    {
        Description = @"Filter for requests where a specific accessor was used",
    };

    private static Option<string?> RequestId { get; } = new(
        name: @"--request-id")
    {
        Description = @"Filter for a specific request id",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment?> Deployment { get; } = new(
        name: @"--deployment")
    {
        Description = @"Filter for requests where a specific deployment was used",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint?> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"Filter for requests where a specific endpoint was used",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod?> Method { get; } = new(
        name: @"--method")
    {
        Description = @"Filter for requests where a specific method was used",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for requests that succeeded (status code < 300) or failed (status code >=400)",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.ListProjectRequestsV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.ListProjectRequestsV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list", @"List Project Requests
Generates a list of requests for a specific project");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Start);
                        command.Options.Add(End);
                        command.Options.Add(Limit);
                        command.Options.Add(Page);
                        command.Options.Add(Accessor);
                        command.Options.Add(RequestId);
                        command.Options.Add(Deployment);
                        command.Options.Add(Endpoint);
                        command.Options.Add(Method);
                        command.Options.Add(Status);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var start = parseResult.GetValue(Start);
                        var end = parseResult.GetValue(End);
                        var limit = parseResult.GetValue(Limit);
                        var page = parseResult.GetValue(Page);
                        var accessor = parseResult.GetValue(Accessor);
                        var requestId = parseResult.GetValue(RequestId);
                        var deployment = parseResult.GetValue(Deployment);
                        var endpoint = parseResult.GetValue(Endpoint);
                        var method = parseResult.GetValue(Method);
                        var status = parseResult.GetValue(Status);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsRequests.ListAsync(
                                    projectId: projectId,
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
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Deepgram.SourceGenerationContext.Default,
                                        @"Requests",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Deepgram.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}