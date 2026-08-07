#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class ManageV1ProjectsMembersScopesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"manage-v1-projects-members-scopes", @"manage > v1 > projects > members > scopes endpoint commands.");
                         command.Subcommands.Add(ManageV1ProjectsMembersScopesListCommandApiCommand.Create());
                         command.Subcommands.Add(ManageV1ProjectsMembersScopesUpdateCommandApiCommand.Create());
        return command;
    }
}