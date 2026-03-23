
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
        Error,
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
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Welcome,
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
                AgentV1ServerEventDiscriminatorType.AgentAudioDone => "AgentAudioDone",
                AgentV1ServerEventDiscriminatorType.AgentStartedSpeaking => "AgentStartedSpeaking",
                AgentV1ServerEventDiscriminatorType.AgentThinking => "AgentThinking",
                AgentV1ServerEventDiscriminatorType.ConversationText => "ConversationText",
                AgentV1ServerEventDiscriminatorType.Error => "Error",
                AgentV1ServerEventDiscriminatorType.FunctionCallRequest => "FunctionCallRequest",
                AgentV1ServerEventDiscriminatorType.FunctionCallResponse => "FunctionCallResponse",
                AgentV1ServerEventDiscriminatorType.InjectionRefused => "InjectionRefused",
                AgentV1ServerEventDiscriminatorType.PromptUpdated => "PromptUpdated",
                AgentV1ServerEventDiscriminatorType.SettingsApplied => "SettingsApplied",
                AgentV1ServerEventDiscriminatorType.SpeakUpdated => "SpeakUpdated",
                AgentV1ServerEventDiscriminatorType.ThinkUpdated => "ThinkUpdated",
                AgentV1ServerEventDiscriminatorType.UserStartedSpeaking => "UserStartedSpeaking",
                AgentV1ServerEventDiscriminatorType.Warning => "Warning",
                AgentV1ServerEventDiscriminatorType.Welcome => "Welcome",
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
                "AgentAudioDone" => AgentV1ServerEventDiscriminatorType.AgentAudioDone,
                "AgentStartedSpeaking" => AgentV1ServerEventDiscriminatorType.AgentStartedSpeaking,
                "AgentThinking" => AgentV1ServerEventDiscriminatorType.AgentThinking,
                "ConversationText" => AgentV1ServerEventDiscriminatorType.ConversationText,
                "Error" => AgentV1ServerEventDiscriminatorType.Error,
                "FunctionCallRequest" => AgentV1ServerEventDiscriminatorType.FunctionCallRequest,
                "FunctionCallResponse" => AgentV1ServerEventDiscriminatorType.FunctionCallResponse,
                "InjectionRefused" => AgentV1ServerEventDiscriminatorType.InjectionRefused,
                "PromptUpdated" => AgentV1ServerEventDiscriminatorType.PromptUpdated,
                "SettingsApplied" => AgentV1ServerEventDiscriminatorType.SettingsApplied,
                "SpeakUpdated" => AgentV1ServerEventDiscriminatorType.SpeakUpdated,
                "ThinkUpdated" => AgentV1ServerEventDiscriminatorType.ThinkUpdated,
                "UserStartedSpeaking" => AgentV1ServerEventDiscriminatorType.UserStartedSpeaking,
                "Warning" => AgentV1ServerEventDiscriminatorType.Warning,
                "Welcome" => AgentV1ServerEventDiscriminatorType.Welcome,
                _ => null,
            };
        }
    }
}