#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class InvitesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"invites", @"invites endpoint commands.");
                         command.Subcommands.Add(InvitesCreateCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesListCommandApiCommand.Create());
        return command;
    }
}