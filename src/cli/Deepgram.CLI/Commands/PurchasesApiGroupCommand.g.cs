#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class PurchasesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"purchases", @"purchases endpoint commands.");
                         command.Subcommands.Add(PurchasesListCommandApiCommand.Create());
        return command;
    }
}