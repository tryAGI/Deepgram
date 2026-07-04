#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsKeysApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-keys", @"manage > v1 > projects > keys endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsKeysCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsKeysDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsKeysListCommandApiCommand.Create());
        return command;
    }
}