#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ReadV1TextApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"read-v1-text", @"read > v1 > text endpoint commands.");
                         command.Subcommands.Add(ReadV1TextAnalyzeCommandApiCommand.Create());
        return command;
    }
}