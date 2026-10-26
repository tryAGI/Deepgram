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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("message")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("request_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("content")) __score8++;
            if (__jsonProps.Contains("languages")) __score8++;
            if (__jsonProps.Contains("languages_hinted")) __score8++;
            if (__jsonProps.Contains("role")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("stt_latency")) __score11++;
            if (__jsonProps.Contains("total_latency")) __score11++;
            if (__jsonProps.Contains("tts_latency")) __score11++;
            if (__jsonProps.Contains("ttt_text_latency")) __score11++;
            if (__jsonProps.Contains("ttt_thinking_latency")) __score11++;
            if (__jsonProps.Contains("ttt_token_latency")) __score11++;
            if (__jsonProps.Contains("ttt_tool_latency")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("functions")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("functions")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("total_latency")) __score14++;
            if (__jsonProps.Contains("tts_latency")) __score14++;
            if (__jsonProps.Contains("ttt_latency")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("content")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("code")) __score17++;
            if (__jsonProps.Contains("description")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("code")) __score18++;
            if (__jsonProps.Contains("description")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            var __score20 = 0;
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
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }

            global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? listenUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? thinkUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? functionCallResponse = default;
            global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? promptUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? speakUpdated = default;
            global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? injectionRefused = default;
            global::Deepgram.Realtime.AgentV1AgentV1Welcome? welcome = default;
            global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? settingsApplied = default;
            global::Deepgram.Realtime.AgentV1AgentV1ConversationText? conversationText = default;
            global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? userStartedSpeaking = default;
            global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? agentThinking = default;
            global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? latencyReport = default;
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? functionCallRequest = default;
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? functionCallCancelled = default;
            global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? agentStartedSpeaking = default;
            global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? agentAudioDone = default;
            global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? customFromThinkProvider = default;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated).Name}");
                        listenUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated).Name}");
                        thinkUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse).Name}");
                        functionCallResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated).Name}");
                        promptUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated).Name}");
                        speakUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused).Name}");
                        injectionRefused = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Welcome> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome).Name}");
                        welcome = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied).Name}");
                        settingsApplied = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ConversationText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText).Name}");
                        conversationText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking).Name}");
                        userStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking).Name}");
                        agentThinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport).Name}");
                        latencyReport = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest).Name}");
                        functionCallRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled).Name}");
                        functionCallCancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking).Name}");
                        agentStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone).Name}");
                        agentAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider).Name}");
                        customFromThinkProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 17)
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
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 18)
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
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 19)
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
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 20)
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
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated).Name}");
                    listenUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated).Name}");
                    thinkUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse).Name}");
                    functionCallResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated).Name}");
                    promptUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated).Name}");
                    speakUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused).Name}");
                    injectionRefused = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Welcome> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome).Name}");
                    welcome = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied).Name}");
                    settingsApplied = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ConversationText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText).Name}");
                    conversationText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking).Name}");
                    userStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking).Name}");
                    agentThinking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport).Name}");
                    latencyReport = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest).Name}");
                    functionCallRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled).Name}");
                    functionCallCancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking).Name}");
                    agentStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone).Name}");
                    agentAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider).Name}");
                    customFromThinkProvider = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
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
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
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
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
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
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (listenUpdated == null && thinkUpdated == null && functionCallResponse == null && promptUpdated == null && speakUpdated == null && injectionRefused == null && welcome == null && settingsApplied == null && conversationText == null && userStartedSpeaking == null && agentThinking == null && latencyReport == null && functionCallRequest == null && functionCallCancelled == null && agentStartedSpeaking == null && agentAudioDone == null && customFromThinkProvider == null && agentV1AgentV1Error == null && agentV1AgentV1Warning == null && agentV1AgentV1History == null && agentV1AgentV1Audio == null)
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
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Deepgram.Realtime.AgentV1ServerEvent(
                listenUpdated,

                thinkUpdated,

                functionCallResponse,

                promptUpdated,

                speakUpdated,

                injectionRefused,

                welcome,

                settingsApplied,

                conversationText,

                userStartedSpeaking,

                agentThinking,

                latencyReport,

                functionCallRequest,

                functionCallCancelled,

                agentStartedSpeaking,

                agentAudioDone,

                customFromThinkProvider,

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

            if (value.IsListenUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickListenUpdated(), typeInfo);
            }
            else if (value.IsThinkUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickThinkUpdated(), typeInfo);
            }
            else if (value.IsFunctionCallResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCallResponse(), typeInfo);
            }
            else if (value.IsPromptUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPromptUpdated(), typeInfo);
            }
            else if (value.IsSpeakUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeakUpdated(), typeInfo);
            }
            else if (value.IsInjectionRefused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInjectionRefused(), typeInfo);
            }
            else if (value.IsWelcome)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Welcome?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWelcome(), typeInfo);
            }
            else if (value.IsSettingsApplied)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSettingsApplied(), typeInfo);
            }
            else if (value.IsConversationText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1ConversationText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationText(), typeInfo);
            }
            else if (value.IsUserStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserStartedSpeaking(), typeInfo);
            }
            else if (value.IsAgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentThinking(), typeInfo);
            }
            else if (value.IsLatencyReport)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLatencyReport(), typeInfo);
            }
            else if (value.IsFunctionCallRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCallRequest(), typeInfo);
            }
            else if (value.IsFunctionCallCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCallCancelled(), typeInfo);
            }
            else if (value.IsAgentStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentStartedSpeaking(), typeInfo);
            }
            else if (value.IsAgentAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentAudioDone(), typeInfo);
            }
            else if (value.IsCustomFromThinkProvider)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustomFromThinkProvider(), typeInfo);
            }
            else if (value.IsAgentV1AgentV1Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Error?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Error).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentV1AgentV1Error(), typeInfo);
            }
            else if (value.IsAgentV1AgentV1Warning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1Warning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentV1AgentV1Warning(), typeInfo);
            }
            else if (value.IsAgentV1AgentV1History)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentV1History), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentV1History> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentV1History).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentV1AgentV1History(), typeInfo);
            }
            else if (value.IsAgentV1AgentV1Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(byte[]), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<byte[]?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(byte[]).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentV1AgentV1Audio(), typeInfo);
            }
        }
    }
}