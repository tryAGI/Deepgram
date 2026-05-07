
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentV1ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentAudioDone,
        /// <summary>
        /// 
        /// </summary>
        AgentStartedSpeaking,
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
        /// <summary>
        /// 
        /// </summary>
        ConversationText,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallRequest,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallResponse,
        /// <summary>
        /// 
        /// </summary>
        InjectionRefused,
        /// <summary>
        /// 
        /// </summary>
        PromptUpdated,
        /// <summary>
        /// 
        /// </summary>
        SettingsApplied,
        /// <summary>
        /// 
        /// </summary>
        SpeakUpdated,
        /// <summary>
        /// 
        /// </summary>
        ThinkUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserStartedSpeaking,
        /// <summary>
        /// 
        /// </summary>
        Welcome,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                AgentV1ServerEventDiscriminatorMessageType.AgentAudioDone => "AgentAudioDone",
                AgentV1ServerEventDiscriminatorMessageType.AgentStartedSpeaking => "AgentStartedSpeaking",
                AgentV1ServerEventDiscriminatorMessageType.AgentThinking => "AgentThinking",
                AgentV1ServerEventDiscriminatorMessageType.ConversationText => "ConversationText",
                AgentV1ServerEventDiscriminatorMessageType.FunctionCallRequest => "FunctionCallRequest",
                AgentV1ServerEventDiscriminatorMessageType.FunctionCallResponse => "FunctionCallResponse",
                AgentV1ServerEventDiscriminatorMessageType.InjectionRefused => "InjectionRefused",
                AgentV1ServerEventDiscriminatorMessageType.PromptUpdated => "PromptUpdated",
                AgentV1ServerEventDiscriminatorMessageType.SettingsApplied => "SettingsApplied",
                AgentV1ServerEventDiscriminatorMessageType.SpeakUpdated => "SpeakUpdated",
                AgentV1ServerEventDiscriminatorMessageType.ThinkUpdated => "ThinkUpdated",
                AgentV1ServerEventDiscriminatorMessageType.UserStartedSpeaking => "UserStartedSpeaking",
                AgentV1ServerEventDiscriminatorMessageType.Welcome => "Welcome",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "AgentAudioDone" => AgentV1ServerEventDiscriminatorMessageType.AgentAudioDone,
                "AgentStartedSpeaking" => AgentV1ServerEventDiscriminatorMessageType.AgentStartedSpeaking,
                "AgentThinking" => AgentV1ServerEventDiscriminatorMessageType.AgentThinking,
                "ConversationText" => AgentV1ServerEventDiscriminatorMessageType.ConversationText,
                "FunctionCallRequest" => AgentV1ServerEventDiscriminatorMessageType.FunctionCallRequest,
                "FunctionCallResponse" => AgentV1ServerEventDiscriminatorMessageType.FunctionCallResponse,
                "InjectionRefused" => AgentV1ServerEventDiscriminatorMessageType.InjectionRefused,
                "PromptUpdated" => AgentV1ServerEventDiscriminatorMessageType.PromptUpdated,
                "SettingsApplied" => AgentV1ServerEventDiscriminatorMessageType.SettingsApplied,
                "SpeakUpdated" => AgentV1ServerEventDiscriminatorMessageType.SpeakUpdated,
                "ThinkUpdated" => AgentV1ServerEventDiscriminatorMessageType.ThinkUpdated,
                "UserStartedSpeaking" => AgentV1ServerEventDiscriminatorMessageType.UserStartedSpeaking,
                "Welcome" => AgentV1ServerEventDiscriminatorMessageType.Welcome,
                _ => null,
            };
        }
    }
}