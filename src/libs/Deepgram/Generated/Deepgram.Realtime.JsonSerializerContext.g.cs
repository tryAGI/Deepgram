
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
            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1EncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1EncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1SampleRateJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1SampleRateNullableJsonConverter),

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

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2EncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2EncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderCredentialsTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsBedrockThinkProviderCredentialsTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AnthropicThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GoogleThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.GroqThinkProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ContextLengthJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ThinkSettingsV1ContextLengthNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.DeepgramSpeakProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderModelIdJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ElevenLabsSpeakProviderModelIdNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderModelIdJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CartesiaSpeakProviderModelIdNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVersionJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVersionNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderModelJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderModelNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVoiceJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OpenAiSpeakProviderVoiceNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderVoiceJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderVoiceNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderEngineJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderEngineNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderCredentialsTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AwsPollySpeakProviderCredentialsTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1TextMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1TextMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ControlMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ControlMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1MetadataEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1MetadataEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ControlEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ControlEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1WarningEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1WarningEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ControlMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ControlMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ResultsEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ResultsEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1MetadataEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1MetadataEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1UtteranceEndEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1UtteranceEndEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1SpeechStartedEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1SpeechStartedEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ControlMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ControlMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ConnectedEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ConnectedEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2TurnInfoEventEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2TurnInfoEventEventNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2FatalErrorEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2FatalErrorEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAudioInputEncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAudioInputEncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAudioOutputEncodingJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAudioOutputEncodingNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAgentContextMessageVariant1RoleJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1SettingsMessageAgentContextMessageVariant1RoleNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ControlMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ControlMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ConversationTextEventRoleJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ConversationTextEventRoleNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ErrorEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ErrorEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1WarningEventTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1WarningEventTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ServerEventDiscriminatorMessageTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ServerEventDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2KeytermJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeakV1ServerEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ServerEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ServerEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.AgentV1ServerEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.OpenAiThinkProvider, global::Deepgram.Realtime.AwsBedrockThinkProvider, global::Deepgram.Realtime.AnthropicThinkProvider, global::Deepgram.Realtime.GoogleThinkProvider, global::Deepgram.Realtime.GroqThinkProvider>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.ThinkSettingsV1ContextLength?, double?>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.DeepgramSpeakProvider, global::Deepgram.Realtime.ElevenLabsSpeakProvider, global::Deepgram.Realtime.CartesiaSpeakProvider, global::Deepgram.Realtime.OpenAiSpeakProvider, global::Deepgram.Realtime.AwsPollySpeakProvider>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.AgentV1SettingsMessageAgent, global::System.Guid?>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.AgentV1SettingsMessageAgentListenProviderVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentListenProviderVariant2>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>),

            typeof(global::Deepgram.Realtime.JsonConverters.OneOfJsonConverter<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1Encoding), TypeInfoPropertyName = "SpeakV1Encoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1MipOptOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1Model), TypeInfoPropertyName = "SpeakV1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1SampleRate), TypeInfoPropertyName = "SpeakV1SampleRate2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Model), TypeInfoPropertyName = "ListenV2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Encoding), TypeInfoPropertyName = "ListenV2Encoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2SampleRate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2EagerEotThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2EotThreshold))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2EotTimeoutMs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Keyterm), TypeInfoPropertyName = "ListenV2Keyterm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2MipOptOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2Tag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProviderVersion), TypeInfoPropertyName = "OpenAiThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiThinkProviderModel), TypeInfoPropertyName = "OpenAiThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderModel), TypeInfoPropertyName = "AwsBedrockThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsBedrockThinkProviderCredentialsType), TypeInfoPropertyName = "AwsBedrockThinkProviderCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProviderVersion), TypeInfoPropertyName = "AnthropicThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AnthropicThinkProviderModel), TypeInfoPropertyName = "AnthropicThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProviderVersion), TypeInfoPropertyName = "GoogleThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GoogleThinkProviderModel), TypeInfoPropertyName = "GoogleThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProviderVersion), TypeInfoPropertyName = "GroqThinkProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.GroqThinkProviderModel), TypeInfoPropertyName = "GroqThinkProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.OpenAiThinkProvider, global::Deepgram.Realtime.AwsBedrockThinkProvider, global::Deepgram.Realtime.AnthropicThinkProvider, global::Deepgram.Realtime.GoogleThinkProvider, global::Deepgram.Realtime.GroqThinkProvider>), TypeInfoPropertyName = "OneOfOpenAiThinkProviderAwsBedrockThinkProviderAnthropicThinkProviderGoogleThinkProviderGroqThinkProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1FunctionEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1ContextLength?, double?>), TypeInfoPropertyName = "OneOfThinkSettingsV1ContextLengthDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ThinkSettingsV1ContextLength), TypeInfoPropertyName = "ThinkSettingsV1ContextLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProviderVersion), TypeInfoPropertyName = "DeepgramSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.DeepgramSpeakProviderModel), TypeInfoPropertyName = "DeepgramSpeakProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProviderVersion), TypeInfoPropertyName = "ElevenLabsSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ElevenLabsSpeakProviderModelId), TypeInfoPropertyName = "ElevenLabsSpeakProviderModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderVersion), TypeInfoPropertyName = "CartesiaSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderModelId), TypeInfoPropertyName = "CartesiaSpeakProviderModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CartesiaSpeakProviderVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderVersion), TypeInfoPropertyName = "OpenAiSpeakProviderVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderModel), TypeInfoPropertyName = "OpenAiSpeakProviderModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OpenAiSpeakProviderVoice), TypeInfoPropertyName = "OpenAiSpeakProviderVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderVoice), TypeInfoPropertyName = "AwsPollySpeakProviderVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderEngine), TypeInfoPropertyName = "AwsPollySpeakProviderEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AwsPollySpeakProviderCredentialsType), TypeInfoPropertyName = "AwsPollySpeakProviderCredentialsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.DeepgramSpeakProvider, global::Deepgram.Realtime.ElevenLabsSpeakProvider, global::Deepgram.Realtime.CartesiaSpeakProvider, global::Deepgram.Realtime.OpenAiSpeakProvider, global::Deepgram.Realtime.AwsPollySpeakProvider>), TypeInfoPropertyName = "OneOfDeepgramSpeakProviderElevenLabsSpeakProviderCartesiaSpeakProviderOpenAiSpeakProviderAwsPollySpeakProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakSettingsV1Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1TextMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1TextMessageType), TypeInfoPropertyName = "SpeakV1TextMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ControlMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ControlMessageType), TypeInfoPropertyName = "SpeakV1ControlMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1MetadataEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1MetadataEventType), TypeInfoPropertyName = "SpeakV1MetadataEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ControlEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ControlEventType), TypeInfoPropertyName = "SpeakV1ControlEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1WarningEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1WarningEventType), TypeInfoPropertyName = "SpeakV1WarningEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ControlMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ControlMessageType), TypeInfoPropertyName = "ListenV1ControlMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternativesWords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternatives))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternativesWords>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternatives>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventMetadataModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventEntities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ResultsEventType), TypeInfoPropertyName = "ListenV1ResultsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ListenV1ResultsEventEntities>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1MetadataEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1MetadataEventType), TypeInfoPropertyName = "ListenV1MetadataEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1UtteranceEndEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1UtteranceEndEventType), TypeInfoPropertyName = "ListenV1UtteranceEndEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1SpeechStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1SpeechStartedEventType), TypeInfoPropertyName = "ListenV1SpeechStartedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ControlMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ControlMessageType), TypeInfoPropertyName = "ListenV2ControlMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ConnectedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ConnectedEventType), TypeInfoPropertyName = "ListenV2ConnectedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2TurnInfoEventWords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2TurnInfoEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2TurnInfoEventEvent), TypeInfoPropertyName = "ListenV2TurnInfoEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ListenV2TurnInfoEventWords>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ConfigureSuccessEventThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ConfigureFailureEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2FatalErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2FatalErrorEventType), TypeInfoPropertyName = "ListenV2FatalErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAudioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAudioInputEncoding), TypeInfoPropertyName = "AgentV1SettingsMessageAudioInputEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAudioOutputEncoding), TypeInfoPropertyName = "AgentV1SettingsMessageAudioOutputEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgent, global::System.Guid?>), TypeInfoPropertyName = "OneOfAgentV1SettingsMessageAgentGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2>), TypeInfoPropertyName = "OneOfAgentV1SettingsMessageAgentContextMessageVariant1AgentV1SettingsMessageAgentContextMessageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1Role), TypeInfoPropertyName = "AgentV1SettingsMessageAgentContextMessageVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2FunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentListen))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgentListenProviderVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentListenProviderVariant2>), TypeInfoPropertyName = "OneOfAgentV1SettingsMessageAgentListenProviderVariant1AgentV1SettingsMessageAgentListenProviderVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentListenProviderVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsMessageAgentListenProviderVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>), TypeInfoPropertyName = "OneOfThinkSettingsV1IListThinkSettingsV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>>), TypeInfoPropertyName = "OneOfSpeakSettingsV1IListSpeakSettingsV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1UpdateSpeakMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1UpdateThinkMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1UpdatePromptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1InjectUserMessageMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1InjectAgentMessageMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ControlMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ControlMessageType), TypeInfoPropertyName = "AgentV1ControlMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1WelcomeMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ConversationTextEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ConversationTextEventRole), TypeInfoPropertyName = "AgentV1ConversationTextEventRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentThinkingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEventFunctions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.AgentV1FunctionCallRequestEventFunctions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ErrorEventType), TypeInfoPropertyName = "AgentV1ErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1WarningEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1WarningEventType), TypeInfoPropertyName = "AgentV1WarningEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ServerEvent), TypeInfoPropertyName = "SpeakV1ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeakV1ServerEventDiscriminatorMessageType), TypeInfoPropertyName = "SpeakV1ServerEventDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ServerEvent), TypeInfoPropertyName = "ListenV1ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType), TypeInfoPropertyName = "ListenV1ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ServerEvent), TypeInfoPropertyName = "ListenV2ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType), TypeInfoPropertyName = "ListenV2ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ServerEvent), TypeInfoPropertyName = "AgentV1ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType), TypeInfoPropertyName = "AgentV1ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ThinkSettingsV1Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternativesWords>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ListenV1ResultsEventChannelAlternatives>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ListenV1ResultsEventEntities>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ListenV2TurnInfoEventWords>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant1, global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.AgentV1SettingsMessageAgentContextMessageVariant2FunctionCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.ThinkSettingsV1, global::System.Collections.Generic.List<global::Deepgram.Realtime.ThinkSettingsV1>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.ThinkSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.OneOf<global::Deepgram.Realtime.SpeakSettingsV1, global::System.Collections.Generic.List<global::Deepgram.Realtime.SpeakSettingsV1>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.SpeakSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.AgentV1FunctionCallRequestEventFunctions>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}