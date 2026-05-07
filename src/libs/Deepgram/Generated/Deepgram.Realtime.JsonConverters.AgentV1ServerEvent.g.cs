#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class AgentV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.AgentV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.AgentV1ServerEvent Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("message")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("request_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("content")) __score7++;
            if (__jsonProps.Contains("languages")) __score7++;
            if (__jsonProps.Contains("languages_hinted")) __score7++;
            if (__jsonProps.Contains("role")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("content")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("functions")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("total_latency")) __score11++;
            if (__jsonProps.Contains("tts_latency")) __score11++;
            if (__jsonProps.Contains("ttt_latency")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("code")) __score13++;
            if (__jsonProps.Contains("description")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("code")) __score14++;
            if (__jsonProps.Contains("description")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            var __score16 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }

            global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? agentV1AgentV1ReceiveFunctionCallResponse = default;
            global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? agentV1AgentV1PromptUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? agentV1AgentV1SpeakUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? agentV1AgentV1ThinkUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? agentV1AgentV1InjectionRefused = default;
            global::Deepgram.Realtime.AgentV1AgentV1Welcome? agentV1AgentV1Welcome = default;
            global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? agentV1AgentV1SettingsApplied = default;
            global::Deepgram.Realtime.AgentV1AgentV1ConversationText? agentV1AgentV1ConversationText = default;
            global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? agentV1AgentV1UserStartedSpeaking = default;
            global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? agentV1AgentV1AgentThinking = default;
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? agentV1AgentV1FunctionCallRequest = default;
            global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? agentV1AgentV1AgentStartedSpeaking = default;
            global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? agentV1AgentV1AgentAudioDone = default;
            global::Deepgram.Realtime.AgentV1AgentV1Error? agentV1AgentV1Error = default;
            global::Deepgram.Realtime.AgentV1AgentV1Warning? agentV1AgentV1Warning = default;
            global::Deepgram.Realtime.AgentV1AgentV1History? agentV1AgentV1History = default;
            byte[]? agentV1AgentV1Audio = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse).Name}");
                        agentV1AgentV1ReceiveFunctionCallResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated).Name}");
                        agentV1AgentV1PromptUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated).Name}");
                        agentV1AgentV1SpeakUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated).Name}");
                        agentV1AgentV1ThinkUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused).Name}");
                        agentV1AgentV1InjectionRefused = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Welcome> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome).Name}");
                        agentV1AgentV1Welcome = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied).Name}");
                        agentV1AgentV1SettingsApplied = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ConversationText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText).Name}");
                        agentV1AgentV1ConversationText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking).Name}");
                        agentV1AgentV1UserStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking).Name}");
                        agentV1AgentV1AgentThinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest).Name}");
                        agentV1AgentV1FunctionCallRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking).Name}");
                        agentV1AgentV1AgentStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone).Name}");
                        agentV1AgentV1AgentAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Error> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Error).Name}");
                        agentV1AgentV1Error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Warning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning).Name}");
                        agentV1AgentV1Warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1History), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1History> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1History).Name}");
                        agentV1AgentV1History = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                        agentV1AgentV1Audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (agentV1AgentV1ReceiveFunctionCallResponse == null && agentV1AgentV1PromptUpdated == null && agentV1AgentV1SpeakUpdated == null && agentV1AgentV1ThinkUpdated == null && agentV1AgentV1InjectionRefused == null && agentV1AgentV1Welcome == null && agentV1AgentV1SettingsApplied == null && agentV1AgentV1ConversationText == null && agentV1AgentV1UserStartedSpeaking == null && agentV1AgentV1AgentThinking == null && agentV1AgentV1FunctionCallRequest == null && agentV1AgentV1AgentStartedSpeaking == null && agentV1AgentV1AgentAudioDone == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse).Name}");
                    agentV1AgentV1ReceiveFunctionCallResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated).Name}");
                    agentV1AgentV1PromptUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated).Name}");
                    agentV1AgentV1SpeakUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated).Name}");
                    agentV1AgentV1ThinkUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused).Name}");
                    agentV1AgentV1InjectionRefused = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Welcome> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome).Name}");
                    agentV1AgentV1Welcome = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied).Name}");
                    agentV1AgentV1SettingsApplied = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ConversationText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText).Name}");
                    agentV1AgentV1ConversationText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking).Name}");
                    agentV1AgentV1UserStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking).Name}");
                    agentV1AgentV1AgentThinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest).Name}");
                    agentV1AgentV1FunctionCallRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking).Name}");
                    agentV1AgentV1AgentStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone).Name}");
                    agentV1AgentV1AgentAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Error> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Error).Name}");
                    agentV1AgentV1Error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Warning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning).Name}");
                    agentV1AgentV1Warning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1History), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1History> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1History).Name}");
                    agentV1AgentV1History = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                    agentV1AgentV1Audio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Deepgram.Realtime.AgentV1ServerEvent(
                agentV1AgentV1ReceiveFunctionCallResponse,

                agentV1AgentV1PromptUpdated,

                agentV1AgentV1SpeakUpdated,

                agentV1AgentV1ThinkUpdated,

                agentV1AgentV1InjectionRefused,

                agentV1AgentV1Welcome,

                agentV1AgentV1SettingsApplied,

                agentV1AgentV1ConversationText,

                agentV1AgentV1UserStartedSpeaking,

                agentV1AgentV1AgentThinking,

                agentV1AgentV1FunctionCallRequest,

                agentV1AgentV1AgentStartedSpeaking,

                agentV1AgentV1AgentAudioDone,

                agentV1AgentV1Error,

                agentV1AgentV1Warning,

                agentV1AgentV1History,

                agentV1AgentV1Audio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.AgentV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgentV1AgentV1ReceiveFunctionCallResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1ReceiveFunctionCallResponse!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1PromptUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1PromptUpdated!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1SpeakUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1SpeakUpdated!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1ThinkUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1ThinkUpdated!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1InjectionRefused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1InjectionRefused!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1Welcome)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Welcome?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1Welcome!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1SettingsApplied)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1SettingsApplied!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1ConversationText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ConversationText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1ConversationText!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1UserStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1UserStartedSpeaking!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1AgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1AgentThinking!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1FunctionCallRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1FunctionCallRequest!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1AgentStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1AgentStartedSpeaking!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1AgentAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1AgentAudioDone!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Error?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Error).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1Error!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1Warning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Warning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1Warning!, typeInfo);
            }
            else if (value.IsAgentV1AgentV1History)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1History), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1History> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1History).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1History!.Value, typeInfo);
            }
            else if (value.IsAgentV1AgentV1Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentV1AgentV1Audio!, typeInfo);
            }
        }
    }
}