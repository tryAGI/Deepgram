#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class TokensApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tokens", @"tokens endpoint commands.");
                         command.Subcommands.Add(TokensGrantCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}