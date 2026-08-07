#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class VoiceAgentConfigurationsUpdateCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The unique identifier of the project",
    };

    private static Argument<string> AgentId { get; } = new(
        name: @"agent-id")
    {
        Description = @"The unique identifier of the agent configuration",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"A map of string key-value pairs to associate with this agent configuration",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.AgentConfigurationV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.AgentConfigurationV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update", @"Update Agent Metadata
Updates the metadata associated with an agent configuration. The config itself is immutable—to change the configuration, delete the existing agent and create a new one.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(AgentId);
                        command.Options.Add(Metadata);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var agentId = parseResult.GetRequiredValue(AgentId);
                        var metadata = parseResult.GetRequiredValue(Metadata);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VoiceAgentConfigurations.UpdateAsync(
                                    projectId: projectId,
                                    agentId: agentId,
                                    metadata: metadata,
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