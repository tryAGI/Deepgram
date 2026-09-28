#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class RequestsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"requests", @"requests endpoint commands.");
                         command.Subcommands.Add(RequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(RequestsListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}