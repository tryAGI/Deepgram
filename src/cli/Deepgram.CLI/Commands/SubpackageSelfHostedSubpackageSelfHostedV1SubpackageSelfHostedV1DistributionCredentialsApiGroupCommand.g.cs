#nullable enable

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static class SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-self-hosted-subpackage-self-hosted-v1-subpackage-self-hosted-v1-distribution-credentials", @"subpackage_selfHosted.subpackage_selfHosted/v1.subpackage_selfHosted/v1/distributionCredentials endpoint commands.");
                         command.Subcommands.Add(SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsGetCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsListCommandApiCommand.Create());
        return command;
    }
}