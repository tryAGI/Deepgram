#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SelfHostedV1DistributionCredentialsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"self-hosted-v1-distribution-credentials", @"selfHosted > v1 > distributionCredentials endpoint commands.");
                         command.Subcommands.Add(SelfHostedV1DistributionCredentialsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(SelfHostedV1DistributionCredentialsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SelfHostedV1DistributionCredentialsGetCommandApiCommand.Create());
                         command.Subcommands.Add(SelfHostedV1DistributionCredentialsListCommandApiCommand.Create());
        return command;
    }
}