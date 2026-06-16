#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Deepgram.CLI.Commands;

internal static partial class SubpackageListenSubpackageListenV1SubpackageListenV1MediaTranscribeCommandApiCommand
{
    private static Argument<string> Url { get; } = new(
        name: @"url")
    {
        Description = @"",
    };

    private static Option<string?> Callback { get; } = new(
        name: @"--callback")
    {
        Description = @"URL to which we'll make the callback request",
    };

    private static Option<global::Deepgram.V1ListenPostParametersCallbackMethod?> CallbackMethod { get; } = new(
        name: @"--callback-method")
    {
        Description = @"HTTP method by which the callback request will be made",
    };

    private static Option<global::Deepgram.V1ListenPostParametersExtra?> Extra { get; } = new(
        name: @"--extra")
    {
        Description = @"Arbitrary key-value pairs that are attached to the API response for usage in downstream processing",
    };

    private static Option<bool?> Sentiment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--sentiment",
        description: @"Recognizes the sentiment throughout a transcript or text");

    private static Option<global::Deepgram.V1ListenPostParametersSummarize?> Summarize { get; } = new(
        name: @"--summarize")
    {
        Description = @"Summarize content. For Listen API, supports string version option. For Read API, accepts boolean only.",
    };

    private static Option<global::Deepgram.V1ListenPostParametersTag?> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Label your requests for the purpose of identification during usage reporting",
    };

    private static Option<bool?> Topics { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--topics",
        description: @"Detect topics throughout a transcript or text");

    private static Option<global::Deepgram.V1ListenPostParametersCustomTopic?> CustomTopic { get; } = new(
        name: @"--custom-topic")
    {
        Description = @"Custom topics you want the model to detect within your input audio or text if present Submit up to `100`.",
    };

    private static Option<global::Deepgram.V1ListenPostParametersCustomTopicMode?> CustomTopicMode { get; } = new(
        name: @"--custom-topic-mode")
    {
        Description = @"Sets how the model will interpret strings submitted to the `custom_topic` param. When `strict`, the model will only return topics submitted using the `custom_topic` param. When `extended`, the model will return its own detected topics in addition to those submitted using the `custom_topic` param",
    };

    private static Option<bool?> Intents { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--intents",
        description: @"Recognizes speaker intent throughout a transcript or text");

    private static Option<global::Deepgram.V1ListenPostParametersCustomIntent?> CustomIntent { get; } = new(
        name: @"--custom-intent")
    {
        Description = @"Custom intents you want the model to detect within your input audio if present",
    };

    private static Option<global::Deepgram.V1ListenPostParametersCustomIntentMode?> CustomIntentMode { get; } = new(
        name: @"--custom-intent-mode")
    {
        Description = @"Sets how the model will interpret intents submitted to the `custom_intent` param. When `strict`, the model will only return intents submitted using the `custom_intent` param. When `extended`, the model will return its own detected intents in the `custom_intent` param.",
    };

    private static Option<bool?> DetectEntities { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--detect-entities",
        description: @"Identifies and extracts key entities from content in submitted audio");

    private static Option<global::Deepgram.V1ListenPostParametersDetectLanguage?> DetectLanguage { get; } = new(
        name: @"--detect-language")
    {
        Description = @"Identifies the dominant language spoken in submitted audio",
    };

    private static Option<bool?> Diarize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--diarize",
        description: @"Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0");

    private static Option<global::Deepgram.V1ListenPostParametersDiarizeModel?> DiarizeModel { get; } = new(
        name: @"--diarize-model")
    {
        Description = @"Select and enable a specific batch diarization model version. If specifying this parameter, you should not set the deprecated `diarize=true` parameter. Not accepted on streaming requests.",
    };

    private static Option<bool?> Dictation { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dictation",
        description: @"Dictation mode for controlling formatting with dictated speech");

    private static Option<global::Deepgram.V1ListenPostParametersEncoding?> Encoding { get; } = new(
        name: @"--encoding")
    {
        Description = @"Specify the expected encoding of your submitted audio",
    };

    private static Option<bool?> FillerWords { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--filler-words",
        description: @"Filler Words can help transcribe interruptions in your audio, like ""uh"" and ""um""");

    private static Option<global::System.Collections.Generic.IList<string>?> Keyterm { get; } = new(
        name: @"--keyterm")
    {
        Description = @"Key term prompting can boost or suppress specialized terminology and brands. Only compatible with Nova-3",
    };

    private static Option<global::Deepgram.V1ListenPostParametersKeywords?> Keywords { get; } = new(
        name: @"--keywords")
    {
        Description = @"Keywords can boost or suppress specialized terminology and brands",
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"The [BCP-47 language tag](https://tools.ietf.org/html/bcp47) that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available",
    };

    private static Option<bool?> Measurements { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--measurements",
        description: @"Spoken measurements will be converted to their corresponding abbreviations");

    private static Option<global::Deepgram.V1ListenPostParametersModel?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"AI model used to process submitted audio",
    };

    private static Option<bool?> Multichannel { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--multichannel",
        description: @"Transcribe each audio channel independently");

    private static Option<bool?> Numerals { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--numerals",
        description: @"Numerals converts numbers from written format to numerical format");

    private static Option<bool?> Paragraphs { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--paragraphs",
        description: @"Splits audio into paragraphs to improve transcript readability");

    private static Option<bool?> ProfanityFilter { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--profanity-filter",
        description: @"Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely");

    private static Option<bool?> Punctuate { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--punctuate",
        description: @"Add punctuation and capitalization to the transcript");

    private static Option<global::Deepgram.V1ListenPostParametersRedact?> Redact { get; } = new(
        name: @"--redact")
    {
        Description = @"Redaction removes sensitive information from your transcripts",
    };

    private static Option<global::Deepgram.V1ListenPostParametersReplace?> Replace { get; } = new(
        name: @"--replace")
    {
        Description = @"Search for terms or phrases in submitted audio and replaces them",
    };

    private static Option<global::Deepgram.V1ListenPostParametersSearch?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search for terms or phrases in submitted audio",
    };

    private static Option<bool?> SmartFormat { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--smart-format",
        description: @"Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability");

    private static Option<bool?> Utterances { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--utterances",
        description: @"Segments speech into meaningful semantic units");

    private static Option<double?> UttSplit { get; } = new(
        name: @"--utt-split")
    {
        Description = @"Seconds to wait before detecting a pause between words in submitted audio",
    };

    private static Option<global::Deepgram.V1ListenPostParametersVersion?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Version of an AI model to use",
    };

    private static Option<bool?> MipOptOut { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--mip-opt-out",
        description: @"Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip");

                    private static string FormatResponse(ParseResult parseResult, global::Deepgram.ListenV1MediaTranscribeResponse200 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Deepgram.ListenV1MediaTranscribeResponse200 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"transcribe", @"Transcribe and analyze pre-recorded audio and video
Transcribe audio and video using Deepgram's speech-to-text REST API");
                        command.Arguments.Add(Url);
                        command.Options.Add(Callback);
                        command.Options.Add(CallbackMethod);
                        command.Options.Add(Extra);
                        command.Options.Add(Sentiment);
                        command.Options.Add(Summarize);
                        command.Options.Add(Tag);
                        command.Options.Add(Topics);
                        command.Options.Add(CustomTopic);
                        command.Options.Add(CustomTopicMode);
                        command.Options.Add(Intents);
                        command.Options.Add(CustomIntent);
                        command.Options.Add(CustomIntentMode);
                        command.Options.Add(DetectEntities);
                        command.Options.Add(DetectLanguage);
                        command.Options.Add(Diarize);
                        command.Options.Add(DiarizeModel);
                        command.Options.Add(Dictation);
                        command.Options.Add(Encoding);
                        command.Options.Add(FillerWords);
                        command.Options.Add(Keyterm);
                        command.Options.Add(Keywords);
                        command.Options.Add(Language);
                        command.Options.Add(Measurements);
                        command.Options.Add(Model);
                        command.Options.Add(Multichannel);
                        command.Options.Add(Numerals);
                        command.Options.Add(Paragraphs);
                        command.Options.Add(ProfanityFilter);
                        command.Options.Add(Punctuate);
                        command.Options.Add(Redact);
                        command.Options.Add(Replace);
                        command.Options.Add(Search);
                        command.Options.Add(SmartFormat);
                        command.Options.Add(Utterances);
                        command.Options.Add(UttSplit);
                        command.Options.Add(Version);
                        command.Options.Add(MipOptOut);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var url = parseResult.GetRequiredValue(Url);
                        var callback = parseResult.GetValue(Callback);
                        var callbackMethod = parseResult.GetValue(CallbackMethod);
                        var extra = parseResult.GetValue(Extra);
                        var sentiment = parseResult.GetValue(Sentiment);
                        var summarize = parseResult.GetValue(Summarize);
                        var tag = parseResult.GetValue(Tag);
                        var topics = parseResult.GetValue(Topics);
                        var customTopic = parseResult.GetValue(CustomTopic);
                        var customTopicMode = parseResult.GetValue(CustomTopicMode);
                        var intents = parseResult.GetValue(Intents);
                        var customIntent = parseResult.GetValue(CustomIntent);
                        var customIntentMode = parseResult.GetValue(CustomIntentMode);
                        var detectEntities = parseResult.GetValue(DetectEntities);
                        var detectLanguage = parseResult.GetValue(DetectLanguage);
                        var diarize = parseResult.GetValue(Diarize);
                        var diarizeModel = parseResult.GetValue(DiarizeModel);
                        var dictation = parseResult.GetValue(Dictation);
                        var encoding = parseResult.GetValue(Encoding);
                        var fillerWords = parseResult.GetValue(FillerWords);
                        var keyterm = parseResult.GetValue(Keyterm);
                        var keywords = parseResult.GetValue(Keywords);
                        var language = parseResult.GetValue(Language);
                        var measurements = parseResult.GetValue(Measurements);
                        var model = parseResult.GetValue(Model);
                        var multichannel = parseResult.GetValue(Multichannel);
                        var numerals = parseResult.GetValue(Numerals);
                        var paragraphs = parseResult.GetValue(Paragraphs);
                        var profanityFilter = parseResult.GetValue(ProfanityFilter);
                        var punctuate = parseResult.GetValue(Punctuate);
                        var redact = parseResult.GetValue(Redact);
                        var replace = parseResult.GetValue(Replace);
                        var search = parseResult.GetValue(Search);
                        var smartFormat = parseResult.GetValue(SmartFormat);
                        var utterances = parseResult.GetValue(Utterances);
                        var uttSplit = parseResult.GetValue(UttSplit);
                        var version = parseResult.GetValue(Version);
                        var mipOptOut = parseResult.GetValue(MipOptOut);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageListenSubpackageListenV1SubpackageListenV1Media.TranscribeAsync(
                                    url: url,
                                    callback: callback,
                                    callbackMethod: callbackMethod,
                                    extra: extra,
                                    sentiment: sentiment,
                                    summarize: summarize,
                                    tag: tag,
                                    topics: topics,
                                    customTopic: customTopic,
                                    customTopicMode: customTopicMode,
                                    intents: intents,
                                    customIntent: customIntent,
                                    customIntentMode: customIntentMode,
                                    detectEntities: detectEntities,
                                    detectLanguage: detectLanguage,
                                    diarize: diarize,
                                    diarizeModel: diarizeModel,
                                    dictation: dictation,
                                    encoding: encoding,
                                    fillerWords: fillerWords,
                                    keyterm: keyterm,
                                    keywords: keywords,
                                    language: language,
                                    measurements: measurements,
                                    model: model,
                                    multichannel: multichannel,
                                    numerals: numerals,
                                    paragraphs: paragraphs,
                                    profanityFilter: profanityFilter,
                                    punctuate: punctuate,
                                    redact: redact,
                                    replace: replace,
                                    search: search,
                                    smartFormat: smartFormat,
                                    utterances: utterances,
                                    uttSplit: uttSplit,
                                    version: version,
                                    mipOptOut: mipOptOut,
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