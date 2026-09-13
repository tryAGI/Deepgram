
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ProjectRequestResponseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ProjectRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectRequestsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ProjectRequestResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectRequestV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponse?), TypeInfoPropertyName = "NullableErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment?), TypeInfoPropertyName = "NullableV1ProjectsProjectIdRequestsGetParametersDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint?), TypeInfoPropertyName = "NullableV1ProjectsProjectIdRequestsGetParametersEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod?), TypeInfoPropertyName = "NullableV1ProjectsProjectIdRequestsGetParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus?), TypeInfoPropertyName = "NullableV1ProjectsProjectIdRequestsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ProjectRequestResponse>))]
    internal sealed partial class RequestsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RequestsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RequestsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment?)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint?)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod?)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus)

                    || typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersDeploymentJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment?))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersDeploymentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint?))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersEndpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod?))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus?))
                {
                    return new global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersStatusNullableJsonConverter();
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
                    0 => new RequestsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}