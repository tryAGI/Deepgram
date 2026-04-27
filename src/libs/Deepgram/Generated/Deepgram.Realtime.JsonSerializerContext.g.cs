
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ReceiveFunctionCallResponseTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ReceiveFunctionCallResponseTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1PromptUpdatedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1PromptUpdatedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SpeakUpdatedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SpeakUpdatedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ThinkUpdatedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ThinkUpdatedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectionRefusedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectionRefusedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1WelcomeTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1WelcomeTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SettingsAppliedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SettingsAppliedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ConversationTextRoleJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ConversationTextRoleNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ConversationTextTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1ConversationTextTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UserStartedSpeakingTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UserStartedSpeakingTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentThinkingTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentThinkingTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1FunctionCallRequestTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1FunctionCallRequestTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentStartedSpeakingTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentStartedSpeakingTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentAudioDoneTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1AgentAudioDoneTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ErrorTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1ErrorTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1WarningTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1WarningTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0RoleJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0RoleNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0TypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0TypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1TypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1TypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0TypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0TypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0VersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0VersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1TypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1TypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1VersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1VersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderCredentialsTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderCredentialsTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ContextLength0JsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ContextLength0NullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderModelIdJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderModelIdNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderModelIdJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderModelIdNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVoiceJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVoiceNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderVoiceJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderVoiceNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderEngineJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderEngineNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderCredentialsTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderCredentialsTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SettingsTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SettingsTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateSpeakTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateSpeakTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectUserMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectUserMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehaviorJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehaviorNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectAgentMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1InjectAgentMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SendFunctionCallResponseTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1SendFunctionCallResponseTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1KeepAliveTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1KeepAliveTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdatePromptTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdatePromptTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateThinkTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1AgentV1UpdateThinkTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1CallbackMethodJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1CallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1DetectEntitiesJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1DetectEntitiesNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1DiarizeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1DiarizeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1DictationJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1DictationNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1EncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1EncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1InterimResultsJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1InterimResultsNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1MultichannelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1MultichannelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1NumeralsJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1NumeralsNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ProfanityFilterJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ProfanityFilterNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1PunctuateJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1PunctuateNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1RedactJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1RedactNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1SmartFormatJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1SmartFormatNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1VadEventsJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1VadEventsNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ResultsTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1ResultsTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1MetadataTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1MetadataTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1UtteranceEndTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1UtteranceEndTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1SpeechStartedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1SpeechStartedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1FinalizeTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1FinalizeTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1CloseStreamTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1CloseStreamTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1KeepAliveTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV1MessagesListenV1KeepAliveTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2EncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2EncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2ConnectedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2ConnectedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2TurnInfoEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2TurnInfoEventNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2TurnInfoTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2TurnInfoTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureSuccessTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureSuccessTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureFailureTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureFailureTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2FatalErrorTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2FatalErrorTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2CloseStreamTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2CloseStreamTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2ConfigureTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1EncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1EncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1SampleRateJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1SampleRateNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1MetadataTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1MetadataTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1FlushedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1FlushedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1ClearedTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1ClearedTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1WarningTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1WarningTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1TextTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1TextTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1FlushTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1FlushTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1ClearTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1ClearTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1CloseTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV1MessagesSpeakV1CloseTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProviderJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ProviderJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ContextLengthJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentThinkJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakSettingsV1ProviderJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1SettingsAgentSpeakJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeakJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ChannelsAgentV1MessagesAgentV1UpdateThinkThinkJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2KeytermJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponseType), TypeInfoPropertyName = "AgentV1AgentV1ReceiveFunctionCallResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdatedType), TypeInfoPropertyName = "AgentV1AgentV1PromptUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdatedType), TypeInfoPropertyName = "AgentV1AgentV1SpeakUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdatedType), TypeInfoPropertyName = "AgentV1AgentV1ThinkUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefusedType), TypeInfoPropertyName = "AgentV1AgentV1InjectionRefusedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1WelcomeType), TypeInfoPropertyName = "AgentV1AgentV1WelcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsAppliedType), TypeInfoPropertyName = "AgentV1AgentV1SettingsAppliedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ConversationTextRole), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1ConversationTextRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationTextType), TypeInfoPropertyName = "AgentV1AgentV1ConversationTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeakingType), TypeInfoPropertyName = "AgentV1AgentV1UserStartedSpeakingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinkingType), TypeInfoPropertyName = "AgentV1AgentV1AgentThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequestType), TypeInfoPropertyName = "AgentV1AgentV1FunctionCallRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeakingType), TypeInfoPropertyName = "AgentV1AgentV1AgentStartedSpeakingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDoneType), TypeInfoPropertyName = "AgentV1AgentV1AgentAudioDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1ErrorType), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1ErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1WarningType), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1WarningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAudioInputEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAudioOutputEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf0Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0Type), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0Version), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListen))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProviderVersion), TypeInfoPropertyName = "OpenAiThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProviderModel), TypeInfoPropertyName = "OpenAiThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProviderType), TypeInfoPropertyName = "OpenAiThinkProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderModel), TypeInfoPropertyName = "AwsBedrockThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderCredentialsType), TypeInfoPropertyName = "AwsBedrockThinkProviderCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderType), TypeInfoPropertyName = "AwsBedrockThinkProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProviderVersion), TypeInfoPropertyName = "AnthropicThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProviderModel), TypeInfoPropertyName = "AnthropicThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProviderType), TypeInfoPropertyName = "AnthropicThinkProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProviderVersion), TypeInfoPropertyName = "GoogleThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProviderModel), TypeInfoPropertyName = "GoogleThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProviderType), TypeInfoPropertyName = "GoogleThinkProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProviderVersion), TypeInfoPropertyName = "GroqThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProviderModel), TypeInfoPropertyName = "GroqThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProviderType), TypeInfoPropertyName = "GroqThinkProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1Provider), TypeInfoPropertyName = "ThinkSettingsV1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1FunctionsItemsEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1FunctionsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1ContextLength0), TypeInfoPropertyName = "ThinkSettingsV1ContextLength02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1ContextLength), TypeInfoPropertyName = "ThinkSettingsV1ContextLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1FunctionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentThink), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentThink2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProviderVersion), TypeInfoPropertyName = "DeepgramSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProviderModel), TypeInfoPropertyName = "DeepgramSpeakProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProviderType), TypeInfoPropertyName = "DeepgramSpeakProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProviderVersion), TypeInfoPropertyName = "ElevenLabsSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProviderModelId), TypeInfoPropertyName = "ElevenLabsSpeakProviderModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProviderType), TypeInfoPropertyName = "ElevenLabsSpeakProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderVersion), TypeInfoPropertyName = "CartesiaSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderModelId), TypeInfoPropertyName = "CartesiaSpeakProviderModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderType), TypeInfoPropertyName = "CartesiaSpeakProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderVersion), TypeInfoPropertyName = "OpenAiSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderModel), TypeInfoPropertyName = "OpenAiSpeakProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderVoice), TypeInfoPropertyName = "OpenAiSpeakProviderVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderType), TypeInfoPropertyName = "OpenAiSpeakProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderVoice), TypeInfoPropertyName = "AwsPollySpeakProviderVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderEngine), TypeInfoPropertyName = "AwsPollySpeakProviderEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderCredentialsType), TypeInfoPropertyName = "AwsPollySpeakProviderCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderType), TypeInfoPropertyName = "AwsPollySpeakProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakSettingsV1Provider), TypeInfoPropertyName = "SpeakSettingsV1Provider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakSettingsV1Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentSpeak), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1SettingsAgentSpeak2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1Settings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsType), TypeInfoPropertyName = "AgentV1AgentV1SettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UpdateSpeak))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UpdateSpeakType), TypeInfoPropertyName = "AgentV1AgentV1UpdateSpeakType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectUserMessageType), TypeInfoPropertyName = "AgentV1AgentV1InjectUserMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1InjectAgentMessageBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectAgentMessageType), TypeInfoPropertyName = "AgentV1AgentV1InjectAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SendFunctionCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1SendFunctionCallResponseType), TypeInfoPropertyName = "AgentV1AgentV1SendFunctionCallResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1KeepAliveType), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1KeepAliveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1KeepAlive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UpdatePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UpdatePromptType), TypeInfoPropertyName = "AgentV1AgentV1UpdatePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1UpdateThinkThink), TypeInfoPropertyName = "ChannelsAgentV1MessagesAgentV1UpdateThinkThink2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UpdateThink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentV1UpdateThinkType), TypeInfoPropertyName = "AgentV1AgentV1UpdateThinkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Callback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1CallbackMethod), TypeInfoPropertyName = "ListenV1CallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Channels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1DetectEntities), TypeInfoPropertyName = "ListenV1DetectEntities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Diarize), TypeInfoPropertyName = "ListenV1Diarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Dictation), TypeInfoPropertyName = "ListenV1Dictation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Encoding), TypeInfoPropertyName = "ListenV1Encoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Endpointing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Extra))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1InterimResults), TypeInfoPropertyName = "ListenV1InterimResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Keyterm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Keywords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Language))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1MipOptOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Model), TypeInfoPropertyName = "ListenV1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Multichannel), TypeInfoPropertyName = "ListenV1Multichannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Numerals), TypeInfoPropertyName = "ListenV1Numerals2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ProfanityFilter), TypeInfoPropertyName = "ListenV1ProfanityFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Punctuate), TypeInfoPropertyName = "ListenV1Punctuate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Redact), TypeInfoPropertyName = "ListenV1Redact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Replace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1SampleRate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Search))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1SmartFormat), TypeInfoPropertyName = "ListenV1SmartFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Tag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1UtteranceEndMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1VadEvents), TypeInfoPropertyName = "ListenV1VadEvents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1ResultsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsMetadataModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsEntitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1Results))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1MetadataType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1MetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1UtteranceEndType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1UtteranceEndType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1SpeechStartedType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1SpeechStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1FinalizeType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1FinalizeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1Finalize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1CloseStreamType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1CloseStreamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1CloseStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1KeepAliveType), TypeInfoPropertyName = "ChannelsListenV1MessagesListenV1KeepAliveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ListenV1KeepAlive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Model), TypeInfoPropertyName = "ListenV2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Encoding), TypeInfoPropertyName = "ListenV2Encoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2SampleRate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2EagerEotThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2EotThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2EotTimeoutMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Keyterm), TypeInfoPropertyName = "ListenV2Keyterm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2MipOptOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Tag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConnectedType), TypeInfoPropertyName = "ChannelsListenV2MessagesListenV2ConnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoEvent), TypeInfoPropertyName = "ChannelsListenV2MessagesListenV2TurnInfoEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfoType), TypeInfoPropertyName = "ListenV2ListenV2TurnInfoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConfigureSuccessThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccessType), TypeInfoPropertyName = "ListenV2ListenV2ConfigureSuccessType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailureType), TypeInfoPropertyName = "ListenV2ListenV2ConfigureFailureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2FatalErrorType), TypeInfoPropertyName = "ChannelsListenV2MessagesListenV2FatalErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2CloseStreamType), TypeInfoPropertyName = "ChannelsListenV2MessagesListenV2CloseStreamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2CloseStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2ConfigureThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2Configure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureType), TypeInfoPropertyName = "ListenV2ListenV2ConfigureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1Encoding), TypeInfoPropertyName = "SpeakV1Encoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1MipOptOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1Model), TypeInfoPropertyName = "SpeakV1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SampleRate), TypeInfoPropertyName = "SpeakV1SampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1MetadataType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1MetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1FlushedType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1FlushedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1ClearedType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1ClearedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1WarningType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1WarningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1TextType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1TextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Text))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1FlushType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1FlushType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flush))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1ClearType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1ClearType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Clear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ChannelsSpeakV1MessagesSpeakV1CloseType), TypeInfoPropertyName = "ChannelsSpeakV1MessagesSpeakV1CloseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Close))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1FunctionCallRequestFunctionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItemsOneOf1FunctionCallsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ThinkSettingsV1FunctionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ThinkSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.SpeakSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsChannelAlternativesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsListenV1MessagesListenV1ResultsEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoWordsItems>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}