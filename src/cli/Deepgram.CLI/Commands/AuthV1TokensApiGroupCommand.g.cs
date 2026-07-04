#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class AuthV1TokensApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"auth-v1-tokens", @"auth > v1 > tokens endpoint commands.");
                         command.Subcommands.Add(AuthV1TokensGrantCommandApiCommand.Create());
        return command;
    }
}