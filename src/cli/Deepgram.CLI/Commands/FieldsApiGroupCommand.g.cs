#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class FieldsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"fields", @"fields endpoint commands.");
                         command.Subcommands.Add(FieldsListCommandApiCommand.Create());
                         command.Subcommands.Add(FieldsList2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}