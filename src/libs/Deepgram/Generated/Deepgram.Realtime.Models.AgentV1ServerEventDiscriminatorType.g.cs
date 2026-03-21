
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentV1ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallResponse,
        /// <summary>
        /// 
        /// </summary>
        PromptUpdated,
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
        InjectionRefused,
        /// <summary>
        /// 
        /// </summary>
        Welcome,
        /// <summary>
        /// 
        /// </summary>
        SettingsApplied,
        /// <summary>
        /// 
        /// </summary>
        ConversationText,
        /// <summary>
        /// 
        /// </summary>
        UserStartedSpeaking,
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallRequest,
        /// <summary>
        /// 
        /// </summary>
        AgentStartedSpeaking,
        /// <summary>
        /// 
        /// </summary>
        AgentAudioDone,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1ServerEventDiscriminatorType value)
        {
            return value switch
            {
                AgentV1ServerEventDiscriminatorType.FunctionCallResponse => "FunctionCallResponse",
                AgentV1ServerEventDiscriminatorType.PromptUpdated => "PromptUpdated",
                AgentV1ServerEventDiscriminatorType.SpeakUpdated => "SpeakUpdated",
                AgentV1ServerEventDiscriminatorType.ThinkUpdated => "ThinkUpdated",
                AgentV1ServerEventDiscriminatorType.InjectionRefused => "InjectionRefused",
                AgentV1ServerEventDiscriminatorType.Welcome => "Welcome",
                AgentV1ServerEventDiscriminatorType.SettingsApplied => "SettingsApplied",
                AgentV1ServerEventDiscriminatorType.ConversationText => "ConversationText",
                AgentV1ServerEventDiscriminatorType.UserStartedSpeaking => "UserStartedSpeaking",
                AgentV1ServerEventDiscriminatorType.AgentThinking => "AgentThinking",
                AgentV1ServerEventDiscriminatorType.FunctionCallRequest => "FunctionCallRequest",
                AgentV1ServerEventDiscriminatorType.AgentStartedSpeaking => "AgentStartedSpeaking",
                AgentV1ServerEventDiscriminatorType.AgentAudioDone => "AgentAudioDone",
                AgentV1ServerEventDiscriminatorType.Error => "Error",
                AgentV1ServerEventDiscriminatorType.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "FunctionCallResponse" => AgentV1ServerEventDiscriminatorType.FunctionCallResponse,
                "PromptUpdated" => AgentV1ServerEventDiscriminatorType.PromptUpdated,
                "SpeakUpdated" => AgentV1ServerEventDiscriminatorType.SpeakUpdated,
                "ThinkUpdated" => AgentV1ServerEventDiscriminatorType.ThinkUpdated,
                "InjectionRefused" => AgentV1ServerEventDiscriminatorType.InjectionRefused,
                "Welcome" => AgentV1ServerEventDiscriminatorType.Welcome,
                "SettingsApplied" => AgentV1ServerEventDiscriminatorType.SettingsApplied,
                "ConversationText" => AgentV1ServerEventDiscriminatorType.ConversationText,
                "UserStartedSpeaking" => AgentV1ServerEventDiscriminatorType.UserStartedSpeaking,
                "AgentThinking" => AgentV1ServerEventDiscriminatorType.AgentThinking,
                "FunctionCallRequest" => AgentV1ServerEventDiscriminatorType.FunctionCallRequest,
                "AgentStartedSpeaking" => AgentV1ServerEventDiscriminatorType.AgentStartedSpeaking,
                "AgentAudioDone" => AgentV1ServerEventDiscriminatorType.AgentAudioDone,
                "Error" => AgentV1ServerEventDiscriminatorType.Error,
                "Warning" => AgentV1ServerEventDiscriminatorType.Warning,
                _ => null,
            };
        }
    }
}