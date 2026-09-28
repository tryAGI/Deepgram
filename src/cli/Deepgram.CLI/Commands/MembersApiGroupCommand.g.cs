#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class MembersApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"members", @"members endpoint commands.");
                         command.Subcommands.Add(MembersDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(MembersListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}