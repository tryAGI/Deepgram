#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class TokensApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tokens", @"tokens endpoint commands.");
                         command.Subcommands.Add(TokensGrantCommandApiCommand.Create());
        return command;
    }
}