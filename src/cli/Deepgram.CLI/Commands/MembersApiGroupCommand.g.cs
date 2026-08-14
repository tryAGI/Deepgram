#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class MembersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"members", @"members endpoint commands.");
                         command.Subcommands.Add(MembersDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(MembersListCommandApiCommand.Create());
        return command;
    }
}