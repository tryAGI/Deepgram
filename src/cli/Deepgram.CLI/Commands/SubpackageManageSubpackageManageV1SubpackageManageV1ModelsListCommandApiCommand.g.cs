#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageManageSubpackageManageV1SubpackageManageV1ModelsListCommandApiCommand
{
    private static Option<bool?> IncludeOutdated { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-outdated",
        description: @"returns non-latest versions of models");

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.ListModelsV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.ListModelsV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list", @"List Models
Returns metadata on all the latest public models. To retrieve custom models, use Get Project Models.");
                        command.Options.Add(IncludeOutdated);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var includeOutdated = parseResult.GetValue(IncludeOutdated);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageManageSubpackageManageV1SubpackageManageV1Models.ListAsync(
                                    includeOutdated: includeOutdated,
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