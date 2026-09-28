#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class PurchasesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"purchases", @"purchases endpoint commands.");
                         command.Subcommands.Add(PurchasesListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}