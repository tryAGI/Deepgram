#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdownGetCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"",
    };

    private static Option<global::System.DateTime?> Start { get; } = new(
        name: @"--start")
    {
        Description = @"Start date of the requested date range. Format accepted is YYYY-MM-DD",
    };

    private static Option<global::System.DateTime?> End { get; } = new(
        name: @"--end")
    {
        Description = @"End date of the requested date range. Format accepted is YYYY-MM-DD",
    };

    private static Option<global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersGrouping?> Grouping { get; } = new(
        name: @"--grouping")
    {
        Description = @"Common usage grouping parameters",
    };

    private static Option<string?> Accessor { get; } = new(
        name: @"--accessor")
    {
        Description = @"Filter for requests where a specific accessor was used",
    };

    private static Option<bool?> Alternatives { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--alternatives",
        description: @"Filter for requests where alternatives were used");

    private static Option<bool?> CallbackMethod { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--callback-method",
        description: @"Filter for requests where callback method was used");

    private static Option<bool?> Callback { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--callback",
        description: @"Filter for requests where callback was used");

    private static Option<bool?> Channels { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--channels",
        description: @"Filter for requests where channels were used");

    private static Option<bool?> CustomIntentMode { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--custom-intent-mode",
        description: @"Filter for requests where custom intent mode was used");

    private static Option<bool?> CustomIntent { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--custom-intent",
        description: @"Filter for requests where custom intent was used");

    private static Option<bool?> CustomTopicMode { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--custom-topic-mode",
        description: @"Filter for requests where custom topic mode was used");

    private static Option<bool?> CustomTopic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--custom-topic",
        description: @"Filter for requests where custom topic was used");

    private static Option<global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersDeployment?> Deployment { get; } = new(
        name: @"--deployment")
    {
        Description = @"Filter for requests where a specific deployment was used",
    };

    private static Option<bool?> DetectEntities { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--detect-entities",
        description: @"Filter for requests where detect entities was used");

    private static Option<bool?> DetectLanguage { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--detect-language",
        description: @"Filter for requests where detect language was used");

    private static Option<bool?> Diarize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--diarize",
        description: @"Filter for requests where diarize was used");

    private static Option<bool?> Dictation { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dictation",
        description: @"Filter for requests where dictation was used");

    private static Option<bool?> Encoding { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--encoding",
        description: @"Filter for requests where encoding was used");

    private static Option<global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint?> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"Filter for requests where a specific endpoint was used",
    };

    private static Option<bool?> Extra { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--extra",
        description: @"Filter for requests where extra was used");

    private static Option<bool?> FillerWords { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--filler-words",
        description: @"Filter for requests where filler words was used");

    private static Option<bool?> Intents { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--intents",
        description: @"Filter for requests where intents was used");

    private static Option<bool?> Keyterm { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--keyterm",
        description: @"Filter for requests where keyterm was used");

    private static Option<bool?> Keywords { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--keywords",
        description: @"Filter for requests where keywords was used");

    private static Option<bool?> Language { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--language",
        description: @"Filter for requests where language was used");

    private static Option<bool?> Measurements { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--measurements",
        description: @"Filter for requests where measurements were used");

    private static Option<global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersMethod?> Method { get; } = new(
        name: @"--method")
    {
        Description = @"Filter for requests where a specific method was used",
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Filter for requests where a specific model uuid was used",
    };

    private static Option<bool?> Multichannel { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--multichannel",
        description: @"Filter for requests where multichannel was used");

    private static Option<bool?> Numerals { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--numerals",
        description: @"Filter for requests where numerals were used");

    private static Option<bool?> Paragraphs { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--paragraphs",
        description: @"Filter for requests where paragraphs were used");

    private static Option<bool?> ProfanityFilter { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--profanity-filter",
        description: @"Filter for requests where profanity filter was used");

    private static Option<bool?> Punctuate { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--punctuate",
        description: @"Filter for requests where punctuate was used");

    private static Option<bool?> Redact { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--redact",
        description: @"Filter for requests where redact was used");

    private static Option<bool?> Replace { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--replace",
        description: @"Filter for requests where replace was used");

    private static Option<bool?> SampleRate { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--sample-rate",
        description: @"Filter for requests where sample rate was used");

    private static Option<bool?> Search { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--search",
        description: @"Filter for requests where search was used");

    private static Option<bool?> Sentiment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--sentiment",
        description: @"Filter for requests where sentiment was used");

    private static Option<bool?> SmartFormat { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--smart-format",
        description: @"Filter for requests where smart format was used");

    private static Option<bool?> Summarize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--summarize",
        description: @"Filter for requests where summarize was used");

    private static Option<string?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Filter for requests where a specific tag was used",
    };

    private static Option<bool?> Topics { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--topics",
        description: @"Filter for requests where topics was used");

    private static Option<bool?> UttSplit { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--utt-split",
        description: @"Filter for requests where utt split was used");

    private static Option<bool?> Utterances { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--utterances",
        description: @"Filter for requests where utterances was used");

    private static Option<bool?> Version { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--version",
        description: @"Filter for requests where version was used");

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.UsageBreakdownV1Response value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.UsageBreakdownV1Response value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get", @"Get Project Usage Breakdown
Retrieves the usage breakdown for a specific project, with various filter options by API feature or by groupings. Setting a feature (e.g. diarize) to true includes requests that used that feature, while false excludes requests that used it. Multiple true filters are combined with OR logic, while false filters use AND logic.");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Start);
                        command.Options.Add(End);
                        command.Options.Add(Grouping);
                        command.Options.Add(Accessor);
                        command.Options.Add(Alternatives);
                        command.Options.Add(CallbackMethod);
                        command.Options.Add(Callback);
                        command.Options.Add(Channels);
                        command.Options.Add(CustomIntentMode);
                        command.Options.Add(CustomIntent);
                        command.Options.Add(CustomTopicMode);
                        command.Options.Add(CustomTopic);
                        command.Options.Add(Deployment);
                        command.Options.Add(DetectEntities);
                        command.Options.Add(DetectLanguage);
                        command.Options.Add(Diarize);
                        command.Options.Add(Dictation);
                        command.Options.Add(Encoding);
                        command.Options.Add(Endpoint);
                        command.Options.Add(Extra);
                        command.Options.Add(FillerWords);
                        command.Options.Add(Intents);
                        command.Options.Add(Keyterm);
                        command.Options.Add(Keywords);
                        command.Options.Add(Language);
                        command.Options.Add(Measurements);
                        command.Options.Add(Method);
                        command.Options.Add(Model);
                        command.Options.Add(Multichannel);
                        command.Options.Add(Numerals);
                        command.Options.Add(Paragraphs);
                        command.Options.Add(ProfanityFilter);
                        command.Options.Add(Punctuate);
                        command.Options.Add(Redact);
                        command.Options.Add(Replace);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Search);
                        command.Options.Add(Sentiment);
                        command.Options.Add(SmartFormat);
                        command.Options.Add(Summarize);
                        command.Options.Add(Tag);
                        command.Options.Add(Topics);
                        command.Options.Add(UttSplit);
                        command.Options.Add(Utterances);
                        command.Options.Add(Version);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var start = parseResult.GetValue(Start);
                        var end = parseResult.GetValue(End);
                        var grouping = parseResult.GetValue(Grouping);
                        var accessor = parseResult.GetValue(Accessor);
                        var alternatives = parseResult.GetValue(Alternatives);
                        var callbackMethod = parseResult.GetValue(CallbackMethod);
                        var callback = parseResult.GetValue(Callback);
                        var channels = parseResult.GetValue(Channels);
                        var customIntentMode = parseResult.GetValue(CustomIntentMode);
                        var customIntent = parseResult.GetValue(CustomIntent);
                        var customTopicMode = parseResult.GetValue(CustomTopicMode);
                        var customTopic = parseResult.GetValue(CustomTopic);
                        var deployment = parseResult.GetValue(Deployment);
                        var detectEntities = parseResult.GetValue(DetectEntities);
                        var detectLanguage = parseResult.GetValue(DetectLanguage);
                        var diarize = parseResult.GetValue(Diarize);
                        var dictation = parseResult.GetValue(Dictation);
                        var encoding = parseResult.GetValue(Encoding);
                        var endpoint = parseResult.GetValue(Endpoint);
                        var extra = parseResult.GetValue(Extra);
                        var fillerWords = parseResult.GetValue(FillerWords);
                        var intents = parseResult.GetValue(Intents);
                        var keyterm = parseResult.GetValue(Keyterm);
                        var keywords = parseResult.GetValue(Keywords);
                        var language = parseResult.GetValue(Language);
                        var measurements = parseResult.GetValue(Measurements);
                        var method = parseResult.GetValue(Method);
                        var model = parseResult.GetValue(Model);
                        var multichannel = parseResult.GetValue(Multichannel);
                        var numerals = parseResult.GetValue(Numerals);
                        var paragraphs = parseResult.GetValue(Paragraphs);
                        var profanityFilter = parseResult.GetValue(ProfanityFilter);
                        var punctuate = parseResult.GetValue(Punctuate);
                        var redact = parseResult.GetValue(Redact);
                        var replace = parseResult.GetValue(Replace);
                        var sampleRate = parseResult.GetValue(SampleRate);
                        var search = parseResult.GetValue(Search);
                        var sentiment = parseResult.GetValue(Sentiment);
                        var smartFormat = parseResult.GetValue(SmartFormat);
                        var summarize = parseResult.GetValue(Summarize);
                        var tag = parseResult.GetValue(Tag);
                        var topics = parseResult.GetValue(Topics);
                        var uttSplit = parseResult.GetValue(UttSplit);
                        var utterances = parseResult.GetValue(Utterances);
                        var version = parseResult.GetValue(Version);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdown.GetAsync(
                                    projectId: projectId,
                                    start: start,
                                    end: end,
                                    grouping: grouping,
                                    accessor: accessor,
                                    alternatives: alternatives,
                                    callbackMethod: callbackMethod,
                                    callback: callback,
                                    channels: channels,
                                    customIntentMode: customIntentMode,
                                    customIntent: customIntent,
                                    customTopicMode: customTopicMode,
                                    customTopic: customTopic,
                                    deployment: deployment,
                                    detectEntities: detectEntities,
                                    detectLanguage: detectLanguage,
                                    diarize: diarize,
                                    dictation: dictation,
                                    encoding: encoding,
                                    endpoint: endpoint,
                                    extra: extra,
                                    fillerWords: fillerWords,
                                    intents: intents,
                                    keyterm: keyterm,
                                    keywords: keywords,
                                    language: language,
                                    measurements: measurements,
                                    method: method,
                                    model: model,
                                    multichannel: multichannel,
                                    numerals: numerals,
                                    paragraphs: paragraphs,
                                    profanityFilter: profanityFilter,
                                    punctuate: punctuate,
                                    redact: redact,
                                    replace: replace,
                                    sampleRate: sampleRate,
                                    search: search,
                                    sentiment: sentiment,
                                    smartFormat: smartFormat,
                                    summarize: summarize,
                                    tag: tag,
                                    topics: topics,
                                    uttSplit: uttSplit,
                                    utterances: utterances,
                                    version: version,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Deepgram.SourceGenerationContext.Default,
                                        @"Results",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Deepgram.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}