#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class MediaApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"media", @"media endpoint commands.");
                         command.Subcommands.Add(MediaTranscribeCommandApiCommand.Create());
                         command.Subcommands.Add(MediaTranscribeWithBytesCommandApiCommand.Create());
        return command;
    }
}