
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Deepgram
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCallbackMethod), TypeInfoPropertyName = "V1ListenPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersExtra), TypeInfoPropertyName = "V1ListenPostParametersExtra2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSummarize0), TypeInfoPropertyName = "V1ListenPostParametersSummarize02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSummarize), TypeInfoPropertyName = "V1ListenPostParametersSummarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersTag), TypeInfoPropertyName = "V1ListenPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomTopic), TypeInfoPropertyName = "V1ListenPostParametersCustomTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode), TypeInfoPropertyName = "V1ListenPostParametersCustomTopicMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomIntent), TypeInfoPropertyName = "V1ListenPostParametersCustomIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode), TypeInfoPropertyName = "V1ListenPostParametersCustomIntentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersDetectLanguage), TypeInfoPropertyName = "V1ListenPostParametersDetectLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersDiarizeModel), TypeInfoPropertyName = "V1ListenPostParametersDiarizeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersEncoding), TypeInfoPropertyName = "V1ListenPostParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersKeywords), TypeInfoPropertyName = "V1ListenPostParametersKeywords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersModel0), TypeInfoPropertyName = "V1ListenPostParametersModel02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersModel), TypeInfoPropertyName = "V1ListenPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items), TypeInfoPropertyName = "V1ListenPostParametersRedactSchemaOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersRedact), TypeInfoPropertyName = "V1ListenPostParametersRedact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersReplace), TypeInfoPropertyName = "V1ListenPostParametersReplace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSearch), TypeInfoPropertyName = "V1ListenPostParametersSearch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersVersion0), TypeInfoPropertyName = "V1ListenPostParametersVersion02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersVersion), TypeInfoPropertyName = "V1ListenPostParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1RequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataDiarizeInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataSummaryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataSentimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataTopicsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataIntentsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItemsSentencesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItemsSentencesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsUtterancesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopicsSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntentsSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentimentsSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentimentsAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentiments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedSentimentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1AcceptedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeResponse200), TypeInfoPropertyName = "ListenV1MediaTranscribeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCallbackMethod?), TypeInfoPropertyName = "NullableV1ListenPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersExtra?), TypeInfoPropertyName = "NullableV1ListenPostParametersExtra2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSummarize0?), TypeInfoPropertyName = "NullableV1ListenPostParametersSummarize02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSummarize?), TypeInfoPropertyName = "NullableV1ListenPostParametersSummarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersTag?), TypeInfoPropertyName = "NullableV1ListenPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomTopic?), TypeInfoPropertyName = "NullableV1ListenPostParametersCustomTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode?), TypeInfoPropertyName = "NullableV1ListenPostParametersCustomTopicMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomIntent?), TypeInfoPropertyName = "NullableV1ListenPostParametersCustomIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode?), TypeInfoPropertyName = "NullableV1ListenPostParametersCustomIntentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersDetectLanguage?), TypeInfoPropertyName = "NullableV1ListenPostParametersDetectLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersDiarizeModel?), TypeInfoPropertyName = "NullableV1ListenPostParametersDiarizeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersEncoding?), TypeInfoPropertyName = "NullableV1ListenPostParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersKeywords?), TypeInfoPropertyName = "NullableV1ListenPostParametersKeywords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersModel0?), TypeInfoPropertyName = "NullableV1ListenPostParametersModel02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersModel?), TypeInfoPropertyName = "NullableV1ListenPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items?), TypeInfoPropertyName = "NullableV1ListenPostParametersRedactSchemaOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersRedact?), TypeInfoPropertyName = "NullableV1ListenPostParametersRedact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersReplace?), TypeInfoPropertyName = "NullableV1ListenPostParametersReplace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSearch?), TypeInfoPropertyName = "NullableV1ListenPostParametersSearch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersVersion0?), TypeInfoPropertyName = "NullableV1ListenPostParametersVersion02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersVersion?), TypeInfoPropertyName = "NullableV1ListenPostParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeResponse200?), TypeInfoPropertyName = "NullableListenV1MediaTranscribeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItemsSentencesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsUtterancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedSentimentsSegmentsItems>))]
    internal sealed partial class MediaSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MediaSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MediaSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MediaSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersExtraJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersSummarizeJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersTagJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersCustomTopicJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersCustomIntentJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersDetectLanguageJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersKeywordsJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersModelJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersRedactJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersReplaceJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersSearchJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ListenPostParametersVersionJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.ListenV1MediaTranscribeResponse200JsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCallbackMethod)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCallbackMethod?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersSummarize0)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersSummarize0?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersDiarizeModel)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersDiarizeModel?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersEncoding)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersEncoding?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersModel0)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersModel0?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items?)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersVersion0)

                    || typeToConvert == typeof(global::Deepgram.V1ListenPostParametersVersion0?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCallbackMethod))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersCallbackMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCallbackMethod?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersCallbackMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersSummarize0))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersSummarize0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersSummarize0?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersSummarize0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersCustomTopicModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersCustomTopicModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersCustomIntentModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersCustomIntentModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersDiarizeModel))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersDiarizeModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersDiarizeModel?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersDiarizeModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersEncoding))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersEncoding?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersModel0))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersModel0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersModel0?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersModel0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersRedactSchemaOneOf1ItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersRedactSchemaOneOf1ItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersVersion0))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersVersion0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ListenPostParametersVersion0?))
                {
                    return new global::Deepgram.JsonConverters.V1ListenPostParametersVersion0NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new MediaSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}