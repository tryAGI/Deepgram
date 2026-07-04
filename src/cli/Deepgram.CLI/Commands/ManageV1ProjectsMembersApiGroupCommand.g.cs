#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsMembersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-members", @"manage > v1 > projects > members endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsMembersDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersListCommandApiCommand.Create());
        return command;
    }
}