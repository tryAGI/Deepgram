#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class SpeakSettingsV1ProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.SpeakSettingsV1Provider>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.SpeakSettingsV1Provider Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("speed")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("language")) __score1++;
            if (__jsonProps.Contains("language_code")) __score1++;
            if (__jsonProps.Contains("model_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("version")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("language")) __score2++;
            if (__jsonProps.Contains("model_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("version")) __score2++;
            if (__jsonProps.Contains("voice")) __score2++;
            if (__jsonProps.Contains("voice.id")) __score2++;
            if (__jsonProps.Contains("voice.mode")) __score2++;
            if (__jsonProps.Contains("volume")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("model")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("version")) __score3++;
            if (__jsonProps.Contains("voice")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("credentials")) __score4++;
            if (__jsonProps.Contains("credentials.access_key_id")) __score4++;
            if (__jsonProps.Contains("credentials.region")) __score4++;
            if (__jsonProps.Contains("credentials.secret_access_key")) __score4++;
            if (__jsonProps.Contains("credentials.session_token")) __score4++;
            if (__jsonProps.Contains("credentials.type")) __score4++;
            if (__jsonProps.Contains("engine")) __score4++;
            if (__jsonProps.Contains("language")) __score4++;
            if (__jsonProps.Contains("language_code")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("voice")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Deepgram.Realtime.DeepgramSpeakProvider? deepgramSpeakProvider = default;
            global::Deepgram.Realtime.ElevenLabsSpeakProvider? elevenLabsSpeakProvider = default;
            global::Deepgram.Realtime.CartesiaSpeakProvider? cartesiaSpeakProvider = default;
            global::Deepgram.Realtime.OpenAiSpeakProvider? openAiSpeakProvider = default;
            global::Deepgram.Realtime.AwsPollySpeakProvider? awsPollySpeakProvider = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.DeepgramSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.DeepgramSpeakProvider> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.DeepgramSpeakProvider).Name}");
                        deepgramSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ElevenLabsSpeakProvider> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider).Name}");
                        elevenLabsSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.CartesiaSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.CartesiaSpeakProvider> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.CartesiaSpeakProvider).Name}");
                        cartesiaSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.OpenAiSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.OpenAiSpeakProvider> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.OpenAiSpeakProvider).Name}");
                        openAiSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AwsPollySpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AwsPollySpeakProvider> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AwsPollySpeakProvider).Name}");
                        awsPollySpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (deepgramSpeakProvider == null && elevenLabsSpeakProvider == null && cartesiaSpeakProvider == null && openAiSpeakProvider == null && awsPollySpeakProvider == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.DeepgramSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.DeepgramSpeakProvider> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.DeepgramSpeakProvider).Name}");
                    deepgramSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deepgramSpeakProvider == null && elevenLabsSpeakProvider == null && cartesiaSpeakProvider == null && openAiSpeakProvider == null && awsPollySpeakProvider == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ElevenLabsSpeakProvider> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider).Name}");
                    elevenLabsSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deepgramSpeakProvider == null && elevenLabsSpeakProvider == null && cartesiaSpeakProvider == null && openAiSpeakProvider == null && awsPollySpeakProvider == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.CartesiaSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.CartesiaSpeakProvider> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.CartesiaSpeakProvider).Name}");
                    cartesiaSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deepgramSpeakProvider == null && elevenLabsSpeakProvider == null && cartesiaSpeakProvider == null && openAiSpeakProvider == null && awsPollySpeakProvider == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.OpenAiSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.OpenAiSpeakProvider> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.OpenAiSpeakProvider).Name}");
                    openAiSpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (deepgramSpeakProvider == null && elevenLabsSpeakProvider == null && cartesiaSpeakProvider == null && openAiSpeakProvider == null && awsPollySpeakProvider == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AwsPollySpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AwsPollySpeakProvider> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AwsPollySpeakProvider).Name}");
                    awsPollySpeakProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.SpeakSettingsV1Provider(
                deepgramSpeakProvider,

                elevenLabsSpeakProvider,

                cartesiaSpeakProvider,

                openAiSpeakProvider,

                awsPollySpeakProvider
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.SpeakSettingsV1Provider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDeepgramSpeakProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.DeepgramSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.DeepgramSpeakProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.DeepgramSpeakProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeepgramSpeakProvider!, typeInfo);
            }
            else if (value.IsElevenLabsSpeakProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ElevenLabsSpeakProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenLabsSpeakProvider!, typeInfo);
            }
            else if (value.IsCartesiaSpeakProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.CartesiaSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.CartesiaSpeakProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.CartesiaSpeakProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CartesiaSpeakProvider!, typeInfo);
            }
            else if (value.IsOpenAiSpeakProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.OpenAiSpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.OpenAiSpeakProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.OpenAiSpeakProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiSpeakProvider!, typeInfo);
            }
            else if (value.IsAwsPollySpeakProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AwsPollySpeakProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AwsPollySpeakProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AwsPollySpeakProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AwsPollySpeakProvider!, typeInfo);
            }
        }
    }
}