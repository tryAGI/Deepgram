#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageManageSubpackageManageV1SubpackageManageV1ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-manage-subpackage-manage-v1-subpackage-manage-v1-models", @"subpackage_manage.subpackage_manage/v1.subpackage_manage/v1/models endpoint commands.");
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ModelsGetCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageManageSubpackageManageV1SubpackageManageV1ModelsListCommandApiCommand.Create());
        return command;
    }
}