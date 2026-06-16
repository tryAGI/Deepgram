#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdownApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-manage-subpackage-manage-v1-subpackage-manage-v1-projects-subpackage-manage-v1-projects-usage-subpackage-manage-v1-projects-usage-breakdown", @"subpackage_manage.subpackage_manage/v1.subpackage_manage/v1/projects.subpackage_manage/v1/projects/usage.subpackage_manage/v1/projects/usage/breakdown endpoint commands.");
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdownGetCommandApiCommand.Create());
        return command;
    }
}