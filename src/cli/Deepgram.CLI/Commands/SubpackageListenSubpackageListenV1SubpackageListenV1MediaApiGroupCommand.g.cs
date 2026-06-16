#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageListenSubpackageListenV1SubpackageListenV1MediaApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-listen-subpackage-listen-v1-subpackage-listen-v1-media", @"subpackage_listen.subpackage_listen/v1.subpackage_listen/v1/media endpoint commands.");
                         command.Subcommands.Add(SubpackageListenSubpackageListenV1SubpackageListenV1MediaTranscribeCommandApiCommand.Create());
        return command;
    }
}