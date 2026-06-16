#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-manage-subpackage-manage-v1-subpackage-manage-v1-projects-subpackage-manage-v1-projects-members-subpackage-manage-v1-projects-members-scopes", @"subpackage_manage.subpackage_manage/v1.subpackage_manage/v1/projects.subpackage_manage/v1/projects/members.subpackage_manage/v1/projects/members/scopes endpoint commands.");
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopesListCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopesUpdateCommandApiCommand.Create());
        return command;
    }
}