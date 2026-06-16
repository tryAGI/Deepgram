#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageReadSubpackageReadV1SubpackageReadV1TextAnalyzeCommandApiCommand
{
    private static Option<string?> Callback { get; } = new(
        name: @"--callback")
    {
        Description = @"URL to which we'll make the callback request",
    };

    private static Option<global::Deepgram.V1ReadPostParametersCallbackMethod?> CallbackMethod { get; } = new(
        name: @"--callback-method")
    {
        Description = @"HTTP method by which the callback request will be made",
    };

    private static Option<bool?> Sentiment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--sentiment",
        description: @"Recognizes the sentiment throughout a transcript or text");

    private static Option<global::Deepgram.V1ReadPostParametersSummarize?> Summarize { get; } = new(
        name: @"--summarize")
    {
        Description = @"Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only.",
    };

    private static Option<global::Deepgram.V1ReadPostParametersTag?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Label your requests for the purpose of identification during usage reporting",
    };

    private static Option<bool?> Topics { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--topics",
        description: @"Detect topics throughout a transcript or text");

    private static Option<global::Deepgram.V1ReadPostParametersCustomTopic?> CustomTopic { get; } = new(
        name: @"--custom-topic")
    {
        Description = @"Custom topics you want the model to detect within your input audio or text if present Submit up to `100`.",
    };

    private static Option<global::Deepgram.V1ReadPostParametersCustomTopicMode?> CustomTopicMode { get; } = new(
        name: @"--custom-topic-mode")
    {
        Description = @"Sets how the model will interpret strings submitted to the `custom_topic` param. When `strict`, the model will only return topics submitted using the `custom_topic` param. When `extended`, the model will return its own detected topics in addition to those submitted using the `custom_topic` param",
    };

    private static Option<bool?> Intents { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--intents",
        description: @"Recognizes speaker intent throughout a transcript or text");

    private static Option<global::Deepgram.V1ReadPostParametersCustomIntent?> CustomIntent { get; } = new(
        name: @"--custom-intent")
    {
        Description = @"Custom intents you want the model to detect within your input audio if present",
    };

    private static Option<global::Deepgram.V1ReadPostParametersCustomIntentMode?> CustomIntentMode { get; } = new(
        name: @"--custom-intent-mode")
    {
        Description = @"Sets how the model will interpret intents submitted to the `custom_intent` param. When `strict`, the model will only return intents submitted using the `custom_intent` param. When `extended`, the model will return its own detected intents in the `custom_intent` param.",
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"The [BCP-47 language tag](https://tools.ietf.org/html/bcp47) that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.ReadV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.ReadV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"analyze", @"Analyze text content
Analyze text content using Deepgrams text analysis API");
                        command.Options.Add(Callback);
                        command.Options.Add(CallbackMethod);
                        command.Options.Add(Sentiment);
                        command.Options.Add(Summarize);
                        command.Options.Add(Tag);
                        command.Options.Add(Topics);
                        command.Options.Add(CustomTopic);
                        command.Options.Add(CustomTopicMode);
                        command.Options.Add(Intents);
                        command.Options.Add(CustomIntent);
                        command.Options.Add(CustomIntentMode);
                        command.Options.Add(Language);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount != 1)
              {
                  result.AddError(@"Specify exactly one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var callback = parseResult.GetValue(Callback);
                        var callbackMethod = parseResult.GetValue(CallbackMethod);
                        var sentiment = parseResult.GetValue(Sentiment);
                        var summarize = parseResult.GetValue(Summarize);
                        var tag = parseResult.GetValue(Tag);
                        var topics = parseResult.GetValue(Topics);
                        var customTopic = parseResult.GetValue(CustomTopic);
                        var customTopicMode = parseResult.GetValue(CustomTopicMode);
                        var intents = parseResult.GetValue(Intents);
                        var customIntent = parseResult.GetValue(CustomIntent);
                        var customIntentMode = parseResult.GetValue(CustomIntentMode);
                        var language = parseResult.GetValue(Language);
                        var request = await CliRuntime.ReadRequestAsync<global::Deepgram.ReadV1Request>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Deepgram.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageReadSubpackageReadV1SubpackageReadV1Text.AnalyzeAsync(
                                    callback: callback,
                                    callbackMethod: callbackMethod,
                                    sentiment: sentiment,
                                    summarize: summarize,
                                    tag: tag,
                                    topics: topics,
                                    customTopic: customTopic,
                                    customTopicMode: customTopicMode,
                                    intents: intents,
                                    customIntent: customIntent,
                                    customIntentMode: customIntentMode,
                                    language: language,
                                    request: request,
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