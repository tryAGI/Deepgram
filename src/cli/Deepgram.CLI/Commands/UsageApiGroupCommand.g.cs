#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class UsageApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"usage", @"usage endpoint commands.");
                         command.Subcommands.Add(UsageGetCommandApiCommand.Create());
        return command;
    }
}