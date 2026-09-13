
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod), TypeInfoPropertyName = "V1SpeakPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersTag), TypeInfoPropertyName = "V1SpeakPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersBitRate0), TypeInfoPropertyName = "V1SpeakPostParametersBitRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersBitRate), TypeInfoPropertyName = "V1SpeakPostParametersBitRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer0), TypeInfoPropertyName = "V1SpeakPostParametersContainer02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer1), TypeInfoPropertyName = "V1SpeakPostParametersContainer12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer2), TypeInfoPropertyName = "V1SpeakPostParametersContainer22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer3), TypeInfoPropertyName = "V1SpeakPostParametersContainer32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer4), TypeInfoPropertyName = "V1SpeakPostParametersContainer42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer), TypeInfoPropertyName = "V1SpeakPostParametersContainer2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding0), TypeInfoPropertyName = "V1SpeakPostParametersEncoding02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding1), TypeInfoPropertyName = "V1SpeakPostParametersEncoding12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding2), TypeInfoPropertyName = "V1SpeakPostParametersEncoding22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding3), TypeInfoPropertyName = "V1SpeakPostParametersEncoding32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding4), TypeInfoPropertyName = "V1SpeakPostParametersEncoding42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding5), TypeInfoPropertyName = "V1SpeakPostParametersEncoding52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding6), TypeInfoPropertyName = "V1SpeakPostParametersEncoding62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding), TypeInfoPropertyName = "V1SpeakPostParametersEncoding2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersModel), TypeInfoPropertyName = "V1SpeakPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersCallbackMethod), TypeInfoPropertyName = "V2SpeakPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersTag), TypeInfoPropertyName = "V2SpeakPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersBitRate0), TypeInfoPropertyName = "V2SpeakPostParametersBitRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersBitRate), TypeInfoPropertyName = "V2SpeakPostParametersBitRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer0), TypeInfoPropertyName = "V2SpeakPostParametersContainer02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer1), TypeInfoPropertyName = "V2SpeakPostParametersContainer12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer2), TypeInfoPropertyName = "V2SpeakPostParametersContainer22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer3), TypeInfoPropertyName = "V2SpeakPostParametersContainer32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer4), TypeInfoPropertyName = "V2SpeakPostParametersContainer42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer), TypeInfoPropertyName = "V2SpeakPostParametersContainer2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding0), TypeInfoPropertyName = "V2SpeakPostParametersEncoding02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding1), TypeInfoPropertyName = "V2SpeakPostParametersEncoding12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding2), TypeInfoPropertyName = "V2SpeakPostParametersEncoding22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding3), TypeInfoPropertyName = "V2SpeakPostParametersEncoding32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding4), TypeInfoPropertyName = "V2SpeakPostParametersEncoding42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding5), TypeInfoPropertyName = "V2SpeakPostParametersEncoding52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding6), TypeInfoPropertyName = "V2SpeakPostParametersEncoding62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding), TypeInfoPropertyName = "V2SpeakPostParametersEncoding2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersExpressivity), TypeInfoPropertyName = "V2SpeakPostParametersExpressivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate0), TypeInfoPropertyName = "V2SpeakPostParametersSampleRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate1), TypeInfoPropertyName = "V2SpeakPostParametersSampleRate12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate2), TypeInfoPropertyName = "V2SpeakPostParametersSampleRate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate3), TypeInfoPropertyName = "V2SpeakPostParametersSampleRate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate), TypeInfoPropertyName = "V2SpeakPostParametersSampleRate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersPriority), TypeInfoPropertyName = "V2SpeakPostParametersPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV2AcceptedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponse?), TypeInfoPropertyName = "NullableErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod?), TypeInfoPropertyName = "NullableV1SpeakPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersTag?), TypeInfoPropertyName = "NullableV1SpeakPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersBitRate0?), TypeInfoPropertyName = "NullableV1SpeakPostParametersBitRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersBitRate?), TypeInfoPropertyName = "NullableV1SpeakPostParametersBitRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer0?), TypeInfoPropertyName = "NullableV1SpeakPostParametersContainer02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer1?), TypeInfoPropertyName = "NullableV1SpeakPostParametersContainer12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer2?), TypeInfoPropertyName = "NullableV1SpeakPostParametersContainer22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer3?), TypeInfoPropertyName = "NullableV1SpeakPostParametersContainer32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer4?), TypeInfoPropertyName = "NullableV1SpeakPostParametersContainer42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer?), TypeInfoPropertyName = "NullableV1SpeakPostParametersContainer2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding0?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding1?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding2?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding3?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding4?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding5?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding6?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding?), TypeInfoPropertyName = "NullableV1SpeakPostParametersEncoding2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersModel?), TypeInfoPropertyName = "NullableV1SpeakPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0?), TypeInfoPropertyName = "NullableV1SpeakPostParametersSampleRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1?), TypeInfoPropertyName = "NullableV1SpeakPostParametersSampleRate12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2?), TypeInfoPropertyName = "NullableV1SpeakPostParametersSampleRate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3?), TypeInfoPropertyName = "NullableV1SpeakPostParametersSampleRate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4?), TypeInfoPropertyName = "NullableV1SpeakPostParametersSampleRate42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate?), TypeInfoPropertyName = "NullableV1SpeakPostParametersSampleRate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersCallbackMethod?), TypeInfoPropertyName = "NullableV2SpeakPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersTag?), TypeInfoPropertyName = "NullableV2SpeakPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersBitRate0?), TypeInfoPropertyName = "NullableV2SpeakPostParametersBitRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersBitRate?), TypeInfoPropertyName = "NullableV2SpeakPostParametersBitRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer0?), TypeInfoPropertyName = "NullableV2SpeakPostParametersContainer02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer1?), TypeInfoPropertyName = "NullableV2SpeakPostParametersContainer12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer2?), TypeInfoPropertyName = "NullableV2SpeakPostParametersContainer22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer3?), TypeInfoPropertyName = "NullableV2SpeakPostParametersContainer32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer4?), TypeInfoPropertyName = "NullableV2SpeakPostParametersContainer42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersContainer?), TypeInfoPropertyName = "NullableV2SpeakPostParametersContainer2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding0?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding1?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding2?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding3?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding4?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding5?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding6?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersEncoding?), TypeInfoPropertyName = "NullableV2SpeakPostParametersEncoding2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersExpressivity?), TypeInfoPropertyName = "NullableV2SpeakPostParametersExpressivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate0?), TypeInfoPropertyName = "NullableV2SpeakPostParametersSampleRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate1?), TypeInfoPropertyName = "NullableV2SpeakPostParametersSampleRate12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate2?), TypeInfoPropertyName = "NullableV2SpeakPostParametersSampleRate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate3?), TypeInfoPropertyName = "NullableV2SpeakPostParametersSampleRate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersSampleRate?), TypeInfoPropertyName = "NullableV2SpeakPostParametersSampleRate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V2SpeakPostParametersPriority?), TypeInfoPropertyName = "NullableV2SpeakPostParametersPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Deepgram.JsonConverters.V1SpeakPostParametersTagJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1SpeakPostParametersBitRateJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1SpeakPostParametersContainerJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1SpeakPostParametersEncodingJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRateJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V2SpeakPostParametersTagJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V2SpeakPostParametersBitRateJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V2SpeakPostParametersContainerJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V2SpeakPostParametersEncodingJsonConverter());
            options.Converters.Add(new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRateJsonConverter());
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
                    typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersBitRate0)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersBitRate0?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer0)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer0?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer1)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer1?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer2)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer2?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer3)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer3?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer4)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer4?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding0)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding0?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding1)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding1?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding2)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding2?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding3)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding3?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding4)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding4?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding5)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding5?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding6)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding6?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersModel)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersModel?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate0)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate0?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate1)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate1?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate2)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate2?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate3)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate3?)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate4)

                    || typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate4?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersCallbackMethod)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersCallbackMethod?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersBitRate0)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersBitRate0?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer0)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer0?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer1)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer1?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer2)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer2?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer3)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer3?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer4)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer4?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding0)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding0?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding1)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding1?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding2)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding2?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding3)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding3?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding4)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding4?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding5)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding5?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding6)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding6?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersExpressivity)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersExpressivity?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate0)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate0?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate1)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate1?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate2)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate2?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate3)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate3?)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersPriority)

                    || typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersPriority?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersCallbackMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersCallbackMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersBitRate0))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersBitRate0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersBitRate0?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersBitRate0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer0))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer0?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer1))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer1JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer1?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer2))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer2JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer2?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer3))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer3JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer3?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer4))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer4JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersContainer4?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersContainer4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding0))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding0?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding1))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding1JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding1?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding2))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding2JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding2?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding3))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding3JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding3?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding4))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding4JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding4?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding5))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding5JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding5?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding6))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding6JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersEncoding6?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersModel))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersModel?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate0))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate0?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate1))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate1JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate1?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate2))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate2JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate2?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate3))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate3JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate3?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate4))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate4JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V1SpeakPostParametersSampleRate4?))
                {
                    return new global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersCallbackMethod))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersCallbackMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersCallbackMethod?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersCallbackMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersBitRate0))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersBitRate0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersBitRate0?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersBitRate0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer0))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer0?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer1))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer1JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer1?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer2))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer2JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer2?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer3))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer3JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer3?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer4))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer4JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersContainer4?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersContainer4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding0))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding0?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding1))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding1JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding1?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding2))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding2JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding2?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding3))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding3JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding3?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding4))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding4JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding4?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding5))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding5JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding5?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding6))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding6JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersEncoding6?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersEncoding6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersExpressivity))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersExpressivityJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersExpressivity?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersExpressivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate0))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate0JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate0?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate1))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate1JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate1?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate2))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate2JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate2?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate3))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate3JsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersSampleRate3?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersSampleRate3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersPriority))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::Deepgram.V2SpeakPostParametersPriority?))
                {
                    return new global::Deepgram.JsonConverters.V2SpeakPostParametersPriorityNullableJsonConverter();
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
                    0 => new AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}