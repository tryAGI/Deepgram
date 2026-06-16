#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageManageSubpackageManageV1SubpackageManageV1ModelsGetCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"The specific UUID of the model",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.GetModelV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.GetModelV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get", @"Get a specific Model
Returns metadata for a specific public model");
                        command.Arguments.Add(ModelId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageManageSubpackageManageV1SubpackageManageV1Models.GetAsync(
                                    modelId: modelId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Deepgram.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}