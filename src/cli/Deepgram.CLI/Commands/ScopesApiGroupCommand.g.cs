#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class ScopesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"scopes", @"scopes endpoint commands.");
                         command.Subcommands.Add(ScopesListCommandApiCommand.Create());
                         command.Subcommands.Add(ScopesUpdateCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}