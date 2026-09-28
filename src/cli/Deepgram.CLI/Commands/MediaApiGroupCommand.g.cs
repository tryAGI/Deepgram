#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class MediaApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"media", @"media endpoint commands.");
                         command.Subcommands.Add(MediaTranscribeCommandApiCommand.Create());
                         command.Subcommands.Add(MediaTranscribeWithBytesCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}