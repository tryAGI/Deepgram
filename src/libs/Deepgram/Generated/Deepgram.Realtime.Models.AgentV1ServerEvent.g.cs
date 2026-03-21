#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentV1ServerEvent : global::System.IEquatable<AgentV1ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Function call response message used bidirectionally:<br/>
        /// • **Client → Server**: Response after client executes a function<br/>
        ///   marked as client_side: true<br/>
        /// • **Server → Client**: Response after server executes a function<br/>
        ///   marked as client_side: false<br/>
        /// The same message structure serves both directions, enabling a unified<br/>
        /// interface for function call responses regardless of execution location.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage? FunctionCallResponse { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage? FunctionCallResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallResponse))]
#endif
        public bool IsFunctionCallResponse => FunctionCallResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1PromptUpdatedEvent? PromptUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1PromptUpdatedEvent? PromptUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptUpdated))]
#endif
        public bool IsPromptUpdated => PromptUpdated != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent? SpeakUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent? SpeakUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakUpdated))]
#endif
        public bool IsSpeakUpdated => SpeakUpdated != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent? ThinkUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent? ThinkUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkUpdated))]
#endif
        public bool IsThinkUpdated => ThinkUpdated != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1InjectionRefusedEvent? InjectionRefused { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1InjectionRefusedEvent? InjectionRefused { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InjectionRefused))]
#endif
        public bool IsInjectionRefused => InjectionRefused != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1WelcomeMessage? Welcome { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1WelcomeMessage? Welcome { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Welcome))]
#endif
        public bool IsWelcome => Welcome != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1SettingsAppliedEvent? SettingsApplied { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1SettingsAppliedEvent? SettingsApplied { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SettingsApplied))]
#endif
        public bool IsSettingsApplied => SettingsApplied != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1ConversationTextEvent? ConversationText { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1ConversationTextEvent? ConversationText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationText))]
#endif
        public bool IsConversationText => ConversationText != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent? UserStartedSpeaking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent? UserStartedSpeaking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserStartedSpeaking))]
#endif
        public bool IsUserStartedSpeaking => UserStartedSpeaking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentThinkingEvent? AgentThinking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentThinkingEvent? AgentThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinking))]
#endif
        public bool IsAgentThinking => AgentThinking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent? FunctionCallRequest { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent? FunctionCallRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallRequest))]
#endif
        public bool IsFunctionCallRequest => FunctionCallRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent? AgentStartedSpeaking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent? AgentStartedSpeaking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStartedSpeaking))]
#endif
        public bool IsAgentStartedSpeaking => AgentStartedSpeaking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent? AgentAudioDone { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent? AgentAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentAudioDone))]
#endif
        public bool IsAgentAudioDone => AgentAudioDone != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1ErrorEvent? Error { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1ErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// Notifies the client of non-fatal errors or warnings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1WarningEvent? Warning { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1WarningEvent? Warning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Warning))]
#endif
        public bool IsWarning => Warning != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage?(AgentV1ServerEvent @this) => @this.FunctionCallResponse;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage? value)
        {
            FunctionCallResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1PromptUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1PromptUpdatedEvent?(AgentV1ServerEvent @this) => @this.PromptUpdated;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent? value)
        {
            PromptUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent?(AgentV1ServerEvent @this) => @this.SpeakUpdated;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent? value)
        {
            SpeakUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent?(AgentV1ServerEvent @this) => @this.ThinkUpdated;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent? value)
        {
            ThinkUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1InjectionRefusedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1InjectionRefusedEvent?(AgentV1ServerEvent @this) => @this.InjectionRefused;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent? value)
        {
            InjectionRefused = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1WelcomeMessage value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1WelcomeMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1WelcomeMessage?(AgentV1ServerEvent @this) => @this.Welcome;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1WelcomeMessage? value)
        {
            Welcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1SettingsAppliedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1SettingsAppliedEvent?(AgentV1ServerEvent @this) => @this.SettingsApplied;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent? value)
        {
            SettingsApplied = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1ConversationTextEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1ConversationTextEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1ConversationTextEvent?(AgentV1ServerEvent @this) => @this.ConversationText;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1ConversationTextEvent? value)
        {
            ConversationText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent?(AgentV1ServerEvent @this) => @this.UserStartedSpeaking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent? value)
        {
            UserStartedSpeaking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentThinkingEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentThinkingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentThinkingEvent?(AgentV1ServerEvent @this) => @this.AgentThinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentThinkingEvent? value)
        {
            AgentThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent?(AgentV1ServerEvent @this) => @this.FunctionCallRequest;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent? value)
        {
            FunctionCallRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent?(AgentV1ServerEvent @this) => @this.AgentStartedSpeaking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent? value)
        {
            AgentStartedSpeaking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent?(AgentV1ServerEvent @this) => @this.AgentAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent? value)
        {
            AgentAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1ErrorEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1ErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1ErrorEvent?(AgentV1ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1WarningEvent value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1WarningEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1WarningEvent?(AgentV1ServerEvent @this) => @this.Warning;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1WarningEvent? value)
        {
            Warning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(
            global::Deepgram.Realtime.AgentV1ServerEventDiscriminatorType? type,
            global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage? functionCallResponse,
            global::Deepgram.Realtime.AgentV1PromptUpdatedEvent? promptUpdated,
            global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent? speakUpdated,
            global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent? thinkUpdated,
            global::Deepgram.Realtime.AgentV1InjectionRefusedEvent? injectionRefused,
            global::Deepgram.Realtime.AgentV1WelcomeMessage? welcome,
            global::Deepgram.Realtime.AgentV1SettingsAppliedEvent? settingsApplied,
            global::Deepgram.Realtime.AgentV1ConversationTextEvent? conversationText,
            global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent? userStartedSpeaking,
            global::Deepgram.Realtime.AgentV1AgentThinkingEvent? agentThinking,
            global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent? functionCallRequest,
            global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent? agentStartedSpeaking,
            global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent? agentAudioDone,
            global::Deepgram.Realtime.AgentV1ErrorEvent? error,
            global::Deepgram.Realtime.AgentV1WarningEvent? warning
            )
        {
            Type = type;

            FunctionCallResponse = functionCallResponse;
            PromptUpdated = promptUpdated;
            SpeakUpdated = speakUpdated;
            ThinkUpdated = thinkUpdated;
            InjectionRefused = injectionRefused;
            Welcome = welcome;
            SettingsApplied = settingsApplied;
            ConversationText = conversationText;
            UserStartedSpeaking = userStartedSpeaking;
            AgentThinking = agentThinking;
            FunctionCallRequest = functionCallRequest;
            AgentStartedSpeaking = agentStartedSpeaking;
            AgentAudioDone = agentAudioDone;
            Error = error;
            Warning = warning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Warning as object ??
            Error as object ??
            AgentAudioDone as object ??
            AgentStartedSpeaking as object ??
            FunctionCallRequest as object ??
            AgentThinking as object ??
            UserStartedSpeaking as object ??
            ConversationText as object ??
            SettingsApplied as object ??
            Welcome as object ??
            InjectionRefused as object ??
            ThinkUpdated as object ??
            SpeakUpdated as object ??
            PromptUpdated as object ??
            FunctionCallResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionCallResponse?.ToString() ??
            PromptUpdated?.ToString() ??
            SpeakUpdated?.ToString() ??
            ThinkUpdated?.ToString() ??
            InjectionRefused?.ToString() ??
            Welcome?.ToString() ??
            SettingsApplied?.ToString() ??
            ConversationText?.ToString() ??
            UserStartedSpeaking?.ToString() ??
            AgentThinking?.ToString() ??
            FunctionCallRequest?.ToString() ??
            AgentStartedSpeaking?.ToString() ??
            AgentAudioDone?.ToString() ??
            Error?.ToString() ??
            Warning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && IsAgentAudioDone && !IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && IsError && !IsWarning || !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsThinkUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsFunctionCallRequest && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsError && IsWarning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage?, TResult>? functionCallResponse = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1PromptUpdatedEvent?, TResult>? promptUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent?, TResult>? speakUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent?, TResult>? thinkUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1InjectionRefusedEvent?, TResult>? injectionRefused = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1WelcomeMessage?, TResult>? welcome = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1SettingsAppliedEvent?, TResult>? settingsApplied = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1ConversationTextEvent?, TResult>? conversationText = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent?, TResult>? userStartedSpeaking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentThinkingEvent?, TResult>? agentThinking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent?, TResult>? functionCallRequest = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent?, TResult>? agentStartedSpeaking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent?, TResult>? agentAudioDone = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1ErrorEvent?, TResult>? error = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1WarningEvent?, TResult>? warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallResponse && functionCallResponse != null)
            {
                return functionCallResponse(FunctionCallResponse!);
            }
            else if (IsPromptUpdated && promptUpdated != null)
            {
                return promptUpdated(PromptUpdated!);
            }
            else if (IsSpeakUpdated && speakUpdated != null)
            {
                return speakUpdated(SpeakUpdated!);
            }
            else if (IsThinkUpdated && thinkUpdated != null)
            {
                return thinkUpdated(ThinkUpdated!);
            }
            else if (IsInjectionRefused && injectionRefused != null)
            {
                return injectionRefused(InjectionRefused!);
            }
            else if (IsWelcome && welcome != null)
            {
                return welcome(Welcome!);
            }
            else if (IsSettingsApplied && settingsApplied != null)
            {
                return settingsApplied(SettingsApplied!);
            }
            else if (IsConversationText && conversationText != null)
            {
                return conversationText(ConversationText!);
            }
            else if (IsUserStartedSpeaking && userStartedSpeaking != null)
            {
                return userStartedSpeaking(UserStartedSpeaking!);
            }
            else if (IsAgentThinking && agentThinking != null)
            {
                return agentThinking(AgentThinking!);
            }
            else if (IsFunctionCallRequest && functionCallRequest != null)
            {
                return functionCallRequest(FunctionCallRequest!);
            }
            else if (IsAgentStartedSpeaking && agentStartedSpeaking != null)
            {
                return agentStartedSpeaking(AgentStartedSpeaking!);
            }
            else if (IsAgentAudioDone && agentAudioDone != null)
            {
                return agentAudioDone(AgentAudioDone!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsWarning && warning != null)
            {
                return warning(Warning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage?>? functionCallResponse = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1PromptUpdatedEvent?>? promptUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent?>? speakUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent?>? thinkUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1InjectionRefusedEvent?>? injectionRefused = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1WelcomeMessage?>? welcome = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1SettingsAppliedEvent?>? settingsApplied = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1ConversationTextEvent?>? conversationText = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent?>? userStartedSpeaking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentThinkingEvent?>? agentThinking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent?>? functionCallRequest = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent?>? agentStartedSpeaking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent?>? agentAudioDone = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1ErrorEvent?>? error = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1WarningEvent?>? warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallResponse)
            {
                functionCallResponse?.Invoke(FunctionCallResponse!);
            }
            else if (IsPromptUpdated)
            {
                promptUpdated?.Invoke(PromptUpdated!);
            }
            else if (IsSpeakUpdated)
            {
                speakUpdated?.Invoke(SpeakUpdated!);
            }
            else if (IsThinkUpdated)
            {
                thinkUpdated?.Invoke(ThinkUpdated!);
            }
            else if (IsInjectionRefused)
            {
                injectionRefused?.Invoke(InjectionRefused!);
            }
            else if (IsWelcome)
            {
                welcome?.Invoke(Welcome!);
            }
            else if (IsSettingsApplied)
            {
                settingsApplied?.Invoke(SettingsApplied!);
            }
            else if (IsConversationText)
            {
                conversationText?.Invoke(ConversationText!);
            }
            else if (IsUserStartedSpeaking)
            {
                userStartedSpeaking?.Invoke(UserStartedSpeaking!);
            }
            else if (IsAgentThinking)
            {
                agentThinking?.Invoke(AgentThinking!);
            }
            else if (IsFunctionCallRequest)
            {
                functionCallRequest?.Invoke(FunctionCallRequest!);
            }
            else if (IsAgentStartedSpeaking)
            {
                agentStartedSpeaking?.Invoke(AgentStartedSpeaking!);
            }
            else if (IsAgentAudioDone)
            {
                agentAudioDone?.Invoke(AgentAudioDone!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsWarning)
            {
                warning?.Invoke(Warning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionCallResponse,
                typeof(global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage),
                PromptUpdated,
                typeof(global::Deepgram.Realtime.AgentV1PromptUpdatedEvent),
                SpeakUpdated,
                typeof(global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent),
                ThinkUpdated,
                typeof(global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent),
                InjectionRefused,
                typeof(global::Deepgram.Realtime.AgentV1InjectionRefusedEvent),
                Welcome,
                typeof(global::Deepgram.Realtime.AgentV1WelcomeMessage),
                SettingsApplied,
                typeof(global::Deepgram.Realtime.AgentV1SettingsAppliedEvent),
                ConversationText,
                typeof(global::Deepgram.Realtime.AgentV1ConversationTextEvent),
                UserStartedSpeaking,
                typeof(global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent),
                AgentThinking,
                typeof(global::Deepgram.Realtime.AgentV1AgentThinkingEvent),
                FunctionCallRequest,
                typeof(global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent),
                AgentStartedSpeaking,
                typeof(global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent),
                AgentAudioDone,
                typeof(global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent),
                Error,
                typeof(global::Deepgram.Realtime.AgentV1ErrorEvent),
                Warning,
                typeof(global::Deepgram.Realtime.AgentV1WarningEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AgentV1ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1FunctionCallResponseMessage?>.Default.Equals(FunctionCallResponse, other.FunctionCallResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1PromptUpdatedEvent?>.Default.Equals(PromptUpdated, other.PromptUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1SpeakUpdatedEvent?>.Default.Equals(SpeakUpdated, other.SpeakUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1ThinkUpdatedEvent?>.Default.Equals(ThinkUpdated, other.ThinkUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1InjectionRefusedEvent?>.Default.Equals(InjectionRefused, other.InjectionRefused) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1WelcomeMessage?>.Default.Equals(Welcome, other.Welcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1SettingsAppliedEvent?>.Default.Equals(SettingsApplied, other.SettingsApplied) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1ConversationTextEvent?>.Default.Equals(ConversationText, other.ConversationText) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1UserStartedSpeakingEvent?>.Default.Equals(UserStartedSpeaking, other.UserStartedSpeaking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentThinkingEvent?>.Default.Equals(AgentThinking, other.AgentThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1FunctionCallRequestEvent?>.Default.Equals(FunctionCallRequest, other.FunctionCallRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentStartedSpeakingEvent?>.Default.Equals(AgentStartedSpeaking, other.AgentStartedSpeaking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentAudioDoneEvent?>.Default.Equals(AgentAudioDone, other.AgentAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1WarningEvent?>.Default.Equals(Warning, other.Warning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentV1ServerEvent obj1, AgentV1ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentV1ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentV1ServerEvent obj1, AgentV1ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentV1ServerEvent o && Equals(o);
        }
    }
}
