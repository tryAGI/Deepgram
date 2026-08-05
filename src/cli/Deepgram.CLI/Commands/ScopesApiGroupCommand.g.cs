#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ScopesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"scopes", @"scopes endpoint commands.");
                         command.Subcommands.Add(ScopesListCommandApiCommand.Create());
                         command.Subcommands.Add(ScopesUpdateCommandApiCommand.Create());
        return command;
    }
}