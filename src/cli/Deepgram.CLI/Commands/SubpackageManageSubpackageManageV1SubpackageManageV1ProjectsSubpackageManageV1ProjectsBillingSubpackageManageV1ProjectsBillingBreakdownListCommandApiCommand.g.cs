#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBreakdownListCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The unique identifier of the project",
    };

    private static Option<global::System.DateTime?> Start { get; } = new(
        name: @"--start")
    {
        Description = @"Start date of the requested date range. Format accepted is YYYY-MM-DD",
    };

    private static Option<global::System.DateTime?> End { get; } = new(
        name: @"--end")
    {
        Description = @"End date of the requested date range. Format accepted is YYYY-MM-DD",
    };

    private static Option<string?> Accessor { get; } = new(
        name: @"--accessor")
    {
        Description = @"Filter for requests where a specific accessor was used",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersDeployment?> Deployment { get; } = new(
        name: @"--deployment")
    {
        Description = @"Filter for requests where a specific deployment was used",
    };

    private static Option<string?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Filter for requests where a specific tag was used",
    };

    private static Option<string?> LineItem { get; } = new(
        name: @"--line-item")
    {
        Description = @"Filter requests by line item (e.g. streaming::nova-3)",
    };

    private static Option<global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>?> Grouping { get; } = new(
        name: @"--grouping")
    {
        Description = @"Group billing breakdown by one or more dimensions (accessor, deployment, line_item, tags)",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.BillingBreakdownV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.BillingBreakdownV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list", @"Get Project Billing Breakdown
Retrieves the billing summary for a specific project, with various filter options or by grouping options.");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Start);
                        command.Options.Add(End);
                        command.Options.Add(Accessor);
                        command.Options.Add(Deployment);
                        command.Options.Add(Tag);
                        command.Options.Add(LineItem);
                        command.Options.Add(Grouping);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var start = parseResult.GetValue(Start);
                        var end = parseResult.GetValue(End);
                        var accessor = parseResult.GetValue(Accessor);
                        var deployment = parseResult.GetValue(Deployment);
                        var tag = parseResult.GetValue(Tag);
                        var lineItem = parseResult.GetValue(LineItem);
                        var grouping = parseResult.GetValue(Grouping);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBreakdown.ListAsync(
                                    projectId: projectId,
                                    start: start,
                                    end: end,
                                    accessor: accessor,
                                    deployment: deployment,
                                    tag: tag,
                                    lineItem: lineItem,
                                    grouping: grouping,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Deepgram.SourceGenerationContext.Default,
                                        @"Results",
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