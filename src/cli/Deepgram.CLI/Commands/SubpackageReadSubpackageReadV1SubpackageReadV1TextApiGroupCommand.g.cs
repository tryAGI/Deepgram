#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageReadSubpackageReadV1SubpackageReadV1TextApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-read-subpackage-read-v1-subpackage-read-v1-text", @"subpackage_read.subpackage_read/v1.subpackage_read/v1/text endpoint commands.");
                         command.Subcommands.Add(SubpackageReadSubpackageReadV1SubpackageReadV1TextAnalyzeCommandApiCommand.Create());
        return command;
    }
}