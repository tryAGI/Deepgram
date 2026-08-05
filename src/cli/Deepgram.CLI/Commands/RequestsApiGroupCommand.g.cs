#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class RequestsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"requests", @"requests endpoint commands.");
                         command.Subcommands.Add(RequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(RequestsListCommandApiCommand.Create());
        return command;
    }
}