#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class BalancesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"balances", @"balances endpoint commands.");
                         command.Subcommands.Add(BalancesGetCommandApiCommand.Create());
                         command.Subcommands.Add(BalancesListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}