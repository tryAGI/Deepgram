
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseTextError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseLegacyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseModernError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponse), TypeInfoPropertyName = "ErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCallbackMethod), TypeInfoPropertyName = "V1ReadPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersSummarize0), TypeInfoPropertyName = "V1ReadPostParametersSummarize02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersSummarize), TypeInfoPropertyName = "V1ReadPostParametersSummarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersTag), TypeInfoPropertyName = "V1ReadPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomTopic), TypeInfoPropertyName = "V1ReadPostParametersCustomTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode), TypeInfoPropertyName = "V1ReadPostParametersCustomTopicMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomIntent), TypeInfoPropertyName = "V1ReadPostParametersCustomIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode), TypeInfoPropertyName = "V1ReadPostParametersCustomIntentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1RequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1RequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Request), TypeInfoPropertyName = "ReadV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataSummaryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataSentimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataTopicsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataIntentsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummaryResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummaryResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponse?), TypeInfoPropertyName = "NullableErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCallbackMethod?), TypeInfoPropertyName = "NullableV1ReadPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersSummarize0?), TypeInfoPropertyName = "NullableV1ReadPostParametersSummarize02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersSummarize?), TypeInfoPropertyName = "NullableV1ReadPostParametersSummarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersTag?), TypeInfoPropertyName = "NullableV1ReadPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomTopic?), TypeInfoPropertyName = "NullableV1ReadPostParametersCustomTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode?), TypeInfoPropertyName = "NullableV1ReadPostParametersCustomTopicMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomIntent?), TypeInfoPropertyName = "NullableV1ReadPostParametersCustomIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode?), TypeInfoPropertyName = "NullableV1ReadPostParametersCustomIntentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Request?), TypeInfoPropertyName = "NullableReadV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedSentimentsSegmentsItems>))]
    internal sealed partial class TextSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TextSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TextSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Deepgram.JsonConverters.ErrorResponseJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ReadPostParametersSummarizeJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ReadPostParametersTagJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ReadPostParametersCustomTopicJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1ReadPostParametersCustomIntentJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.ReadV1RequestJsonConverter());
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
                    typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCallbackMethod)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCallbackMethod?)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersSummarize0)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersSummarize0?)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode?)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode)

                    || typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCallbackMethod))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersCallbackMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCallbackMethod?))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersCallbackMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersSummarize0))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersSummarize0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersSummarize0?))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersSummarize0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersCustomTopicModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode?))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersCustomTopicModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersCustomIntentModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode?))
                {
                    return new global::Deepgram.JsonConverters.V1ReadPostParametersCustomIntentModeNullableJsonConverter();
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
                    0 => new TextSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}