#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsUsageFieldsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-usage-fields", @"manage > v1 > projects > usage > fields endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsUsageFieldsListCommandApiCommand.Create());
        return command;
    }
}