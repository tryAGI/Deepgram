#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class VariablesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"variables", @"variables endpoint commands.");
                         command.Subcommands.Add(VariablesCreateCommandApiCommand.Create());
                         command.Subcommands.Add(VariablesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(VariablesGetCommandApiCommand.Create());
                         command.Subcommands.Add(VariablesListCommandApiCommand.Create());
                         command.Subcommands.Add(VariablesUpdateCommandApiCommand.Create());
        return command;
    }
}