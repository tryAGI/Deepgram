#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ListenV1MediaApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"listen-v1-media", @"listen > v1 > media endpoint commands.");
                         command.Subcommands.Add(ListenV1MediaTranscribeCommandApiCommand.Create());
        return command;
    }
}