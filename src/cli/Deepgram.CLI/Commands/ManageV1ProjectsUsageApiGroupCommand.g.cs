#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsUsageApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-usage", @"manage > v1 > projects > usage endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsUsageGetCommandApiCommand.Create());
        return command;
    }
}