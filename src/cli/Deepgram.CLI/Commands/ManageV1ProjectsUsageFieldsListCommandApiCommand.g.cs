#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class ManageV1ProjectsUsageFieldsListCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.UsageFieldsV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.UsageFieldsV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list", @"List Project Usage Fields
Lists the features, models, tags, languages, and processing method used for requests in the specified project");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Start);
                        command.Options.Add(End);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var start = parseResult.GetValue(Start);
                        var end = parseResult.GetValue(End);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ManageV1ProjectsUsageFields.ListAsync(
                                    projectId: projectId,
                                    start: start,
                                    end: end,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Deepgram.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}