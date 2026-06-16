#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingFieldsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-manage-subpackage-manage-v1-subpackage-manage-v1-projects-subpackage-manage-v1-projects-billing-subpackage-manage-v1-projects-billing-fields", @"subpackage_manage.subpackage_manage/v1.subpackage_manage/v1/projects.subpackage_manage/v1/projects/billing.subpackage_manage/v1/projects/billing/fields endpoint commands.");
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingFieldsListCommandApiCommand.Create());
        return command;
    }
}