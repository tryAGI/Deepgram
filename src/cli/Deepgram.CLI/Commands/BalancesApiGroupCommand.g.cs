#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class BalancesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"balances", @"balances endpoint commands.");
                         command.Subcommands.Add(BalancesGetCommandApiCommand.Create());
                         command.Subcommands.Add(BalancesListCommandApiCommand.Create());
        return command;
    }
}