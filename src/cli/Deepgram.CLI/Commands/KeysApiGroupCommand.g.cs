#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class KeysApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"keys", @"keys endpoint commands.");
                         command.Subcommands.Add(KeysCreateCommandApiCommand.Create());
                         command.Subcommands.Add(KeysDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(KeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(KeysListCommandApiCommand.Create());
        return command;
    }
}