#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class AgentV1SettingsThinkModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agent-v1-settings-think-models", @"agent > v1 > settings > think > models endpoint commands.");
                         command.Subcommands.Add(AgentV1SettingsThinkModelsListCommandApiCommand.Create());
        return command;
    }
}