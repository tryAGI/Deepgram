#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageAuthSubpackageAuthV1SubpackageAuthV1TokensApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-auth-subpackage-auth-v1-subpackage-auth-v1-tokens", @"subpackage_auth.subpackage_auth/v1.subpackage_auth/v1/tokens endpoint commands.");
                         command.Subcommands.Add(SubpackageAuthSubpackageAuthV1SubpackageAuthV1TokensGrantCommandApiCommand.Create());
        return command;
    }
}