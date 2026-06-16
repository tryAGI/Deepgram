#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageVoiceAgentSubpackageVoiceAgentVariablesDeleteCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"",
    };

    private static Argument<string> VariableId { get; } = new(
        name: @"variable-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.DeleteAgentVariableV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.DeleteAgentVariableV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete", @"Delete an Agent Variable
Deletes the specified template variable");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(VariableId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var variableId = parseResult.GetRequiredValue(VariableId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageVoiceAgentSubpackageVoiceAgentVariables.DeleteAsync(
                                    projectId: projectId,
                                    variableId: variableId,
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