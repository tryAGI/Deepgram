#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsMembersInvitesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-members-invites", @"manage > v1 > projects > members > invites endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsMembersInvitesCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersInvitesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersInvitesListCommandApiCommand.Create());
        return command;
    }
}