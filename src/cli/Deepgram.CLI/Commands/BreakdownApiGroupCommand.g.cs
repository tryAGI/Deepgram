#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class BreakdownApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"breakdown", @"breakdown endpoint commands.");
                         command.Subcommands.Add(BreakdownGetCommandApiCommand.Create());
                         command.Subcommands.Add(BreakdownListCommandApiCommand.Create());
        return command;
    }
}