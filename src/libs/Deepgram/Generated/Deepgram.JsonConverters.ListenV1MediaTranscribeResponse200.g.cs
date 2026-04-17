#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.JsonConverters
{
    /// <inheritdoc />
    public class ListenV1MediaTranscribeResponse200JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.ListenV1MediaTranscribeResponse200>
    {
        /// <inheritdoc />
        public override global::Deepgram.ListenV1MediaTranscribeResponse200 Read(
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
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("metadata.channels")) __score0++;
            if (__jsonProps.Contains("metadata.created")) __score0++;
            if (__jsonProps.Contains("metadata.duration")) __score0++;
            if (__jsonProps.Contains("metadata.intents_info")) __score0++;
            if (__jsonProps.Contains("metadata.model_info")) __score0++;
            if (__jsonProps.Contains("metadata.models")) __score0++;
            if (__jsonProps.Contains("metadata.request_id")) __score0++;
            if (__jsonProps.Contains("metadata.sentiment_info")) __score0++;
            if (__jsonProps.Contains("metadata.sha256")) __score0++;
            if (__jsonProps.Contains("metadata.summary_info")) __score0++;
            if (__jsonProps.Contains("metadata.tags")) __score0++;
            if (__jsonProps.Contains("metadata.topics_info")) __score0++;
            if (__jsonProps.Contains("metadata.transaction_key")) __score0++;
            if (__jsonProps.Contains("results")) __score0++;
            if (__jsonProps.Contains("results.channels")) __score0++;
            if (__jsonProps.Contains("results.intents")) __score0++;
            if (__jsonProps.Contains("results.sentiments")) __score0++;
            if (__jsonProps.Contains("results.summary")) __score0++;
            if (__jsonProps.Contains("results.topics")) __score0++;
            if (__jsonProps.Contains("results.utterances")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("request_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Deepgram.ListenV1Response? listenV1Response = default;
            global::Deepgram.ListenV1AcceptedResponse? listenV1AcceptedResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.ListenV1Response), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.ListenV1Response> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.ListenV1Response).Name}");
                        listenV1Response = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.ListenV1AcceptedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.ListenV1AcceptedResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.ListenV1AcceptedResponse).Name}");
                        listenV1AcceptedResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (listenV1Response == null && listenV1AcceptedResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.ListenV1Response), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.ListenV1Response> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.ListenV1Response).Name}");
                    listenV1Response = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.ListenV1AcceptedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.ListenV1AcceptedResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.ListenV1AcceptedResponse).Name}");
                    listenV1AcceptedResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.ListenV1MediaTranscribeResponse200(
                listenV1Response,

                listenV1AcceptedResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.ListenV1MediaTranscribeResponse200 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsListenV1Response)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.ListenV1Response), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.ListenV1Response?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.ListenV1Response).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenV1Response!, typeInfo);
            }
            else if (value.IsListenV1AcceptedResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.ListenV1AcceptedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.ListenV1AcceptedResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.ListenV1AcceptedResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenV1AcceptedResponse!, typeInfo);
            }
        }
    }
}