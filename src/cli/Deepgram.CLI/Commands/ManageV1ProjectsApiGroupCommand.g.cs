#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects", @"manage > v1 > projects endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsLeaveCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsListCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsUpdateCommandApiCommand.Create());
        return command;
    }
}