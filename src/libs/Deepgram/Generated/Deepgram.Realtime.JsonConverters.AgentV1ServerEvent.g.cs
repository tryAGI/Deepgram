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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage? functionCallResponse = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.FunctionCallResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage)}");
                functionCallResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1PromptUpdatedEvent? promptUpdated = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.PromptUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1PromptUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent)}");
                promptUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent? speakUpdated = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.SpeakUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent)}");
                speakUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent? thinkUpdated = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.ThinkUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent)}");
                thinkUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1InjectionRefusedEvent? injectionRefused = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.InjectionRefused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1InjectionRefusedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent)}");
                injectionRefused = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1WelcomeMessage? welcome = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.Welcome)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1WelcomeMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1WelcomeMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1WelcomeMessage)}");
                welcome = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1SettingsAppliedEvent? settingsApplied = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.SettingsApplied)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1SettingsAppliedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent)}");
                settingsApplied = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1ConversationTextEvent? conversationText = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.ConversationText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ConversationTextEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ConversationTextEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1ConversationTextEvent)}");
                conversationText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent? userStartedSpeaking = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.UserStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent)}");
                userStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1AgentThinkingEvent? agentThinking = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.AgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1AgentThinkingEvent)}");
                agentThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent? functionCallRequest = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.FunctionCallRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent)}");
                functionCallRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent? agentStartedSpeaking = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.AgentStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent)}");
                agentStartedSpeaking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent? agentAudioDone = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.AgentAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent)}");
                agentAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1ErrorEvent? error = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.AgentV1WarningEvent? warning = default;
            if (discriminator?.Type == global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType.Warning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1WarningEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1WarningEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.AgentV1WarningEvent)}");
                warning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Deepgram.Realtime.AgentV1ServerEvent(
                discriminator?.Type,
                functionCallResponse,

                promptUpdated,

                speakUpdated,

                thinkUpdated,

                injectionRefused,

                welcome,

                settingsApplied,

                conversationText,

                userStartedSpeaking,

                agentThinking,

                functionCallRequest,

                agentStartedSpeaking,

                agentAudioDone,

                error,

                warning
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

            if (value.IsFunctionCallResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallResponse, typeInfo);
            }
            else if (value.IsPromptUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1PromptUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptUpdated, typeInfo);
            }
            else if (value.IsSpeakUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakUpdated, typeInfo);
            }
            else if (value.IsThinkUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkUpdated, typeInfo);
            }
            else if (value.IsInjectionRefused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1InjectionRefusedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InjectionRefused, typeInfo);
            }
            else if (value.IsWelcome)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1WelcomeMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1WelcomeMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1WelcomeMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Welcome, typeInfo);
            }
            else if (value.IsSettingsApplied)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1SettingsAppliedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SettingsApplied, typeInfo);
            }
            else if (value.IsConversationText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ConversationTextEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ConversationTextEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1ConversationTextEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationText, typeInfo);
            }
            else if (value.IsUserStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserStartedSpeaking, typeInfo);
            }
            else if (value.IsAgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentThinkingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentThinkingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinking, typeInfo);
            }
            else if (value.IsFunctionCallRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallRequest, typeInfo);
            }
            else if (value.IsAgentStartedSpeaking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentStartedSpeaking, typeInfo);
            }
            else if (value.IsAgentAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentAudioDone, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsWarning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.AgentV1WarningEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.AgentV1WarningEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.AgentV1WarningEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Warning, typeInfo);
            }
        }
    }
}