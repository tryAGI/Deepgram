#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class KeysApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"keys", @"keys endpoint commands.");
                         command.Subcommands.Add(KeysCreateCommandApiCommand.Create());
                         command.Subcommands.Add(KeysDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(KeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(KeysListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}