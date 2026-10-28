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
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? ListenUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? ListenUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenUpdated))]
#endif
        public bool IsListenUpdated => ListenUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListenUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? value)
        {
            value = ListenUpdated;
            return IsListenUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated PickListenUpdated() => ListenUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? ThinkUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? ThinkUpdated { get; }
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
        public bool TryPickThinkUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? value)
        {
            value = ThinkUpdated;
            return IsThinkUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated PickThinkUpdated() => ThinkUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated? ThinkLiveUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated? ThinkLiveUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkLiveUpdated))]
#endif
        public bool IsThinkLiveUpdated => ThinkLiveUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThinkLiveUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated? value)
        {
            value = ThinkLiveUpdated;
            return IsThinkLiveUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated PickThinkLiveUpdated() => ThinkLiveUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkLiveUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected? FrustrationDetected { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected? FrustrationDetected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FrustrationDetected))]
#endif
        public bool IsFrustrationDetected => FrustrationDetected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFrustrationDetected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected? value)
        {
            value = FrustrationDetected;
            return IsFrustrationDetected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected PickFrustrationDetected() => FrustrationDetected is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FrustrationDetected' but the value was {ToString()}.");

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
        public global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? FunctionCallResponse { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? FunctionCallResponse { get; }
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
        public bool TryPickFunctionCallResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? value)
        {
            value = FunctionCallResponse;
            return IsFunctionCallResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse PickFunctionCallResponse() => FunctionCallResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallResponse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? PromptUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? PromptUpdated { get; }
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
        public bool TryPickPromptUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? value)
        {
            value = PromptUpdated;
            return IsPromptUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated PickPromptUpdated() => PromptUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PromptUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? SpeakUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? SpeakUpdated { get; }
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
        public bool TryPickSpeakUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? value)
        {
            value = SpeakUpdated;
            return IsSpeakUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated PickSpeakUpdated() => SpeakUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakUpdated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? InjectionRefused { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? InjectionRefused { get; }
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
        public bool TryPickInjectionRefused(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? value)
        {
            value = InjectionRefused;
            return IsInjectionRefused;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused PickInjectionRefused() => InjectionRefused is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InjectionRefused' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1Welcome? Welcome { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1Welcome? Welcome { get; }
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
        public bool TryPickWelcome(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1Welcome? value)
        {
            value = Welcome;
            return IsWelcome;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1Welcome PickWelcome() => Welcome is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Welcome' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? SettingsApplied { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? SettingsApplied { get; }
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
        public bool TryPickSettingsApplied(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? value)
        {
            value = SettingsApplied;
            return IsSettingsApplied;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied PickSettingsApplied() => SettingsApplied is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SettingsApplied' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationText? ConversationText { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationText? ConversationText { get; }
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
        public bool TryPickConversationText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ConversationText? value)
        {
            value = ConversationText;
            return IsConversationText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationText PickConversationText() => ConversationText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? UserStartedSpeaking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? UserStartedSpeaking { get; }
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
        public bool TryPickUserStartedSpeaking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? value)
        {
            value = UserStartedSpeaking;
            return IsUserStartedSpeaking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking PickUserStartedSpeaking() => UserStartedSpeaking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserStartedSpeaking' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? AgentThinking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? AgentThinking { get; }
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
        public bool TryPickAgentThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? value)
        {
            value = AgentThinking;
            return IsAgentThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinking PickAgentThinking() => AgentThinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentThinking' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? LatencyReport { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? LatencyReport { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LatencyReport))]
#endif
        public bool IsLatencyReport => LatencyReport != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLatencyReport(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? value)
        {
            value = LatencyReport;
            return IsLatencyReport;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1LatencyReport PickLatencyReport() => LatencyReport is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LatencyReport' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? FunctionCallRequest { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? FunctionCallRequest { get; }
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
        public bool TryPickFunctionCallRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? value)
        {
            value = FunctionCallRequest;
            return IsFunctionCallRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest PickFunctionCallRequest() => FunctionCallRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? FunctionCallCancelled { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? FunctionCallCancelled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallCancelled))]
#endif
        public bool IsFunctionCallCancelled => FunctionCallCancelled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallCancelled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? value)
        {
            value = FunctionCallCancelled;
            return IsFunctionCallCancelled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled PickFunctionCallCancelled() => FunctionCallCancelled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallCancelled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? AgentStartedSpeaking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? AgentStartedSpeaking { get; }
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
        public bool TryPickAgentStartedSpeaking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? value)
        {
            value = AgentStartedSpeaking;
            return IsAgentStartedSpeaking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking PickAgentStartedSpeaking() => AgentStartedSpeaking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentStartedSpeaking' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? AgentAudioDone { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? AgentAudioDone { get; }
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
        public bool TryPickAgentAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? value)
        {
            value = AgentAudioDone;
            return IsAgentAudioDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone PickAgentAudioDone() => AgentAudioDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentAudioDone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? CustomFromThinkProvider { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? CustomFromThinkProvider { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomFromThinkProvider))]
#endif
        public bool IsCustomFromThinkProvider => CustomFromThinkProvider != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomFromThinkProvider(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? value)
        {
            value = CustomFromThinkProvider;
            return IsCustomFromThinkProvider;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider PickCustomFromThinkProvider() => CustomFromThinkProvider is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomFromThinkProvider' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1Error? AgentV1AgentV1Error { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1Error? AgentV1AgentV1Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1Error))]
#endif
        public bool IsAgentV1AgentV1Error => AgentV1AgentV1Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentV1AgentV1Error(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1Error? value)
        {
            value = AgentV1AgentV1Error;
            return IsAgentV1AgentV1Error;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1Error PickAgentV1AgentV1Error() => AgentV1AgentV1Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1Error' but the value was {ToString()}.");

        /// <summary>
        /// Notifies the client of non-fatal errors or warnings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1Warning? AgentV1AgentV1Warning { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1Warning? AgentV1AgentV1Warning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1Warning))]
#endif
        public bool IsAgentV1AgentV1Warning => AgentV1AgentV1Warning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentV1AgentV1Warning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1Warning? value)
        {
            value = AgentV1AgentV1Warning;
            return IsAgentV1AgentV1Warning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1Warning PickAgentV1AgentV1Warning() => AgentV1AgentV1Warning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1Warning' but the value was {ToString()}.");

        /// <summary>
        /// A history message is either a conversational message or a function call
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1History? AgentV1AgentV1History { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1History? AgentV1AgentV1History { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1History))]
#endif
        public bool IsAgentV1AgentV1History => AgentV1AgentV1History != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentV1AgentV1History(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1History? value)
        {
            value = AgentV1AgentV1History;
            return IsAgentV1AgentV1History;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1History PickAgentV1AgentV1History() => AgentV1AgentV1History is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1History' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? AgentV1AgentV1Audio { get; init; }
#else
        public byte[]? AgentV1AgentV1Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1Audio))]
#endif
        public bool IsAgentV1AgentV1Audio => AgentV1AgentV1Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentV1AgentV1Audio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = AgentV1AgentV1Audio;
            return IsAgentV1AgentV1Audio;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickAgentV1AgentV1Audio() => AgentV1AgentV1Audio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1Audio' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated?(AgentV1ServerEvent @this) => @this.ListenUpdated;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? value)
        {
            ListenUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromListenUpdated(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?(AgentV1ServerEvent @this) => @this.ThinkUpdated;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? value)
        {
            ThinkUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromThinkUpdated(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated?(AgentV1ServerEvent @this) => @this.ThinkLiveUpdated;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated? value)
        {
            ThinkLiveUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromThinkLiveUpdated(global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected?(AgentV1ServerEvent @this) => @this.FrustrationDetected;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected? value)
        {
            FrustrationDetected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromFrustrationDetected(global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?(AgentV1ServerEvent @this) => @this.FunctionCallResponse;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? value)
        {
            FunctionCallResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromFunctionCallResponse(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?(AgentV1ServerEvent @this) => @this.PromptUpdated;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? value)
        {
            PromptUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromPromptUpdated(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?(AgentV1ServerEvent @this) => @this.SpeakUpdated;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? value)
        {
            SpeakUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromSpeakUpdated(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?(AgentV1ServerEvent @this) => @this.InjectionRefused;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? value)
        {
            InjectionRefused = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromInjectionRefused(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Welcome value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1Welcome?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1Welcome?(AgentV1ServerEvent @this) => @this.Welcome;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Welcome? value)
        {
            Welcome = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromWelcome(global::Deepgram.Realtime.AgentV1AgentV1Welcome? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?(AgentV1ServerEvent @this) => @this.SettingsApplied;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? value)
        {
            SettingsApplied = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromSettingsApplied(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ConversationText value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ConversationText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ConversationText?(AgentV1ServerEvent @this) => @this.ConversationText;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ConversationText? value)
        {
            ConversationText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromConversationText(global::Deepgram.Realtime.AgentV1AgentV1ConversationText? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?(AgentV1ServerEvent @this) => @this.UserStartedSpeaking;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? value)
        {
            UserStartedSpeaking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromUserStartedSpeaking(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?(AgentV1ServerEvent @this) => @this.AgentThinking;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? value)
        {
            AgentThinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentThinking(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1LatencyReport?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1LatencyReport?(AgentV1ServerEvent @this) => @this.LatencyReport;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? value)
        {
            LatencyReport = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromLatencyReport(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?(AgentV1ServerEvent @this) => @this.FunctionCallRequest;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? value)
        {
            FunctionCallRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromFunctionCallRequest(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled?(AgentV1ServerEvent @this) => @this.FunctionCallCancelled;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? value)
        {
            FunctionCallCancelled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromFunctionCallCancelled(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?(AgentV1ServerEvent @this) => @this.AgentStartedSpeaking;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? value)
        {
            AgentStartedSpeaking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentStartedSpeaking(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?(AgentV1ServerEvent @this) => @this.AgentAudioDone;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? value)
        {
            AgentAudioDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentAudioDone(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider?(AgentV1ServerEvent @this) => @this.CustomFromThinkProvider;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? value)
        {
            CustomFromThinkProvider = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromCustomFromThinkProvider(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Error value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1Error?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1Error?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1Error;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Error? value)
        {
            AgentV1AgentV1Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1Error(global::Deepgram.Realtime.AgentV1AgentV1Error? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Warning value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1Warning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1Warning?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1Warning;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Warning? value)
        {
            AgentV1AgentV1Warning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1Warning(global::Deepgram.Realtime.AgentV1AgentV1Warning? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1History value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1History?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1History?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1History;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1History? value)
        {
            AgentV1AgentV1History = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1History(global::Deepgram.Realtime.AgentV1AgentV1History? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentV1ServerEvent(byte[] value) => new AgentV1ServerEvent((byte[]?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator byte[]?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1Audio;

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(byte[]? value)
        {
            AgentV1AgentV1Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1Audio(byte[]? value) => new AgentV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public AgentV1ServerEvent(
            global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated? listenUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? thinkUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated? thinkLiveUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected? frustrationDetected,
            global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? functionCallResponse,
            global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? promptUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? speakUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? injectionRefused,
            global::Deepgram.Realtime.AgentV1AgentV1Welcome? welcome,
            global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? settingsApplied,
            global::Deepgram.Realtime.AgentV1AgentV1ConversationText? conversationText,
            global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? userStartedSpeaking,
            global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? agentThinking,
            global::Deepgram.Realtime.AgentV1AgentV1LatencyReport? latencyReport,
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? functionCallRequest,
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled? functionCallCancelled,
            global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? agentStartedSpeaking,
            global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? agentAudioDone,
            global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider? customFromThinkProvider,
            global::Deepgram.Realtime.AgentV1AgentV1Error? agentV1AgentV1Error,
            global::Deepgram.Realtime.AgentV1AgentV1Warning? agentV1AgentV1Warning,
            global::Deepgram.Realtime.AgentV1AgentV1History? agentV1AgentV1History,
            byte[]? agentV1AgentV1Audio
            )
        {
            ListenUpdated = listenUpdated;
            ThinkUpdated = thinkUpdated;
            ThinkLiveUpdated = thinkLiveUpdated;
            FrustrationDetected = frustrationDetected;
            FunctionCallResponse = functionCallResponse;
            PromptUpdated = promptUpdated;
            SpeakUpdated = speakUpdated;
            InjectionRefused = injectionRefused;
            Welcome = welcome;
            SettingsApplied = settingsApplied;
            ConversationText = conversationText;
            UserStartedSpeaking = userStartedSpeaking;
            AgentThinking = agentThinking;
            LatencyReport = latencyReport;
            FunctionCallRequest = functionCallRequest;
            FunctionCallCancelled = functionCallCancelled;
            AgentStartedSpeaking = agentStartedSpeaking;
            AgentAudioDone = agentAudioDone;
            CustomFromThinkProvider = customFromThinkProvider;
            AgentV1AgentV1Error = agentV1AgentV1Error;
            AgentV1AgentV1Warning = agentV1AgentV1Warning;
            AgentV1AgentV1History = agentV1AgentV1History;
            AgentV1AgentV1Audio = agentV1AgentV1Audio;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AgentV1AgentV1Audio as object ??
            AgentV1AgentV1History as object ??
            AgentV1AgentV1Warning as object ??
            AgentV1AgentV1Error as object ??
            CustomFromThinkProvider as object ??
            AgentAudioDone as object ??
            AgentStartedSpeaking as object ??
            FunctionCallCancelled as object ??
            FunctionCallRequest as object ??
            LatencyReport as object ??
            AgentThinking as object ??
            UserStartedSpeaking as object ??
            ConversationText as object ??
            SettingsApplied as object ??
            Welcome as object ??
            InjectionRefused as object ??
            SpeakUpdated as object ??
            PromptUpdated as object ??
            FunctionCallResponse as object ??
            FrustrationDetected as object ??
            ThinkLiveUpdated as object ??
            ThinkUpdated as object ??
            ListenUpdated as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ListenUpdated?.ToString() ??
            ThinkUpdated?.ToString() ??
            ThinkLiveUpdated?.ToString() ??
            FrustrationDetected?.ToString() ??
            FunctionCallResponse?.ToString() ??
            PromptUpdated?.ToString() ??
            SpeakUpdated?.ToString() ??
            InjectionRefused?.ToString() ??
            Welcome?.ToString() ??
            SettingsApplied?.ToString() ??
            ConversationText?.ToString() ??
            UserStartedSpeaking?.ToString() ??
            AgentThinking?.ToString() ??
            LatencyReport?.ToString() ??
            FunctionCallRequest?.ToString() ??
            FunctionCallCancelled?.ToString() ??
            AgentStartedSpeaking?.ToString() ??
            AgentAudioDone?.ToString() ??
            CustomFromThinkProvider?.ToString() ??
            AgentV1AgentV1Error?.ToString() ??
            AgentV1AgentV1Warning?.ToString() ??
            AgentV1AgentV1History?.ToString() ??
            AgentV1AgentV1Audio?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsListenUpdated && !IsThinkUpdated && !IsThinkLiveUpdated && !IsFrustrationDetected && !IsFunctionCallResponse && !IsPromptUpdated && !IsSpeakUpdated && !IsInjectionRefused && !IsWelcome && !IsSettingsApplied && !IsConversationText && !IsUserStartedSpeaking && !IsAgentThinking && !IsLatencyReport && !IsFunctionCallRequest && !IsFunctionCallCancelled && !IsAgentStartedSpeaking && !IsAgentAudioDone && !IsCustomFromThinkProvider && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && IsAgentV1AgentV1Audio;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated, TResult>? listenUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated, TResult>? thinkUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated, TResult>? thinkLiveUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected, TResult>? frustrationDetected = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse, TResult>? functionCallResponse = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated, TResult>? promptUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated, TResult>? speakUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused, TResult>? injectionRefused = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1Welcome, TResult>? welcome = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied, TResult>? settingsApplied = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ConversationText, TResult>? conversationText = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking, TResult>? userStartedSpeaking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking, TResult>? agentThinking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport, TResult>? latencyReport = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest, TResult>? functionCallRequest = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled, TResult>? functionCallCancelled = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking, TResult>? agentStartedSpeaking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone, TResult>? agentAudioDone = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider, TResult>? customFromThinkProvider = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1Error, TResult>? agentV1AgentV1Error = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1Warning, TResult>? agentV1AgentV1Warning = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1History?, TResult>? agentV1AgentV1History = null,
            global::System.Func<byte[], TResult>? agentV1AgentV1Audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenUpdated is { } __value0 && listenUpdated != null)
            {
                return listenUpdated(__value0);
            }
            else if (ThinkUpdated is { } __value1 && thinkUpdated != null)
            {
                return thinkUpdated(__value1);
            }
            else if (ThinkLiveUpdated is { } __value2 && thinkLiveUpdated != null)
            {
                return thinkLiveUpdated(__value2);
            }
            else if (FrustrationDetected is { } __value3 && frustrationDetected != null)
            {
                return frustrationDetected(__value3);
            }
            else if (FunctionCallResponse is { } __value4 && functionCallResponse != null)
            {
                return functionCallResponse(__value4);
            }
            else if (PromptUpdated is { } __value5 && promptUpdated != null)
            {
                return promptUpdated(__value5);
            }
            else if (SpeakUpdated is { } __value6 && speakUpdated != null)
            {
                return speakUpdated(__value6);
            }
            else if (InjectionRefused is { } __value7 && injectionRefused != null)
            {
                return injectionRefused(__value7);
            }
            else if (Welcome is { } __value8 && welcome != null)
            {
                return welcome(__value8);
            }
            else if (SettingsApplied is { } __value9 && settingsApplied != null)
            {
                return settingsApplied(__value9);
            }
            else if (ConversationText is { } __value10 && conversationText != null)
            {
                return conversationText(__value10);
            }
            else if (UserStartedSpeaking is { } __value11 && userStartedSpeaking != null)
            {
                return userStartedSpeaking(__value11);
            }
            else if (AgentThinking is { } __value12 && agentThinking != null)
            {
                return agentThinking(__value12);
            }
            else if (LatencyReport is { } __value13 && latencyReport != null)
            {
                return latencyReport(__value13);
            }
            else if (FunctionCallRequest is { } __value14 && functionCallRequest != null)
            {
                return functionCallRequest(__value14);
            }
            else if (FunctionCallCancelled is { } __value15 && functionCallCancelled != null)
            {
                return functionCallCancelled(__value15);
            }
            else if (AgentStartedSpeaking is { } __value16 && agentStartedSpeaking != null)
            {
                return agentStartedSpeaking(__value16);
            }
            else if (AgentAudioDone is { } __value17 && agentAudioDone != null)
            {
                return agentAudioDone(__value17);
            }
            else if (CustomFromThinkProvider is { } __value18 && customFromThinkProvider != null)
            {
                return customFromThinkProvider(__value18);
            }
            else if (AgentV1AgentV1Error is { } __value19 && agentV1AgentV1Error != null)
            {
                return agentV1AgentV1Error(__value19);
            }
            else if (AgentV1AgentV1Warning is { } __value20 && agentV1AgentV1Warning != null)
            {
                return agentV1AgentV1Warning(__value20);
            }
            else if (AgentV1AgentV1History is { } __value21 && agentV1AgentV1History != null)
            {
                return agentV1AgentV1History(__value21);
            }
            else if (AgentV1AgentV1Audio is { } __value22 && agentV1AgentV1Audio != null)
            {
                return agentV1AgentV1Audio(__value22);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated>? listenUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated>? thinkUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated>? thinkLiveUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected>? frustrationDetected = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse>? functionCallResponse = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated>? promptUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated>? speakUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused>? injectionRefused = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Welcome>? welcome = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied>? settingsApplied = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ConversationText>? conversationText = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking>? userStartedSpeaking = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking>? agentThinking = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport>? latencyReport = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest>? functionCallRequest = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled>? functionCallCancelled = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking>? agentStartedSpeaking = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone>? agentAudioDone = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider>? customFromThinkProvider = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Error>? agentV1AgentV1Error = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Warning>? agentV1AgentV1Warning = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1History?>? agentV1AgentV1History = null,

            global::System.Action<byte[]>? agentV1AgentV1Audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenUpdated is { } __value0)
            {
                listenUpdated?.Invoke(__value0);
            }
            else if (ThinkUpdated is { } __value1)
            {
                thinkUpdated?.Invoke(__value1);
            }
            else if (ThinkLiveUpdated is { } __value2)
            {
                thinkLiveUpdated?.Invoke(__value2);
            }
            else if (FrustrationDetected is { } __value3)
            {
                frustrationDetected?.Invoke(__value3);
            }
            else if (FunctionCallResponse is { } __value4)
            {
                functionCallResponse?.Invoke(__value4);
            }
            else if (PromptUpdated is { } __value5)
            {
                promptUpdated?.Invoke(__value5);
            }
            else if (SpeakUpdated is { } __value6)
            {
                speakUpdated?.Invoke(__value6);
            }
            else if (InjectionRefused is { } __value7)
            {
                injectionRefused?.Invoke(__value7);
            }
            else if (Welcome is { } __value8)
            {
                welcome?.Invoke(__value8);
            }
            else if (SettingsApplied is { } __value9)
            {
                settingsApplied?.Invoke(__value9);
            }
            else if (ConversationText is { } __value10)
            {
                conversationText?.Invoke(__value10);
            }
            else if (UserStartedSpeaking is { } __value11)
            {
                userStartedSpeaking?.Invoke(__value11);
            }
            else if (AgentThinking is { } __value12)
            {
                agentThinking?.Invoke(__value12);
            }
            else if (LatencyReport is { } __value13)
            {
                latencyReport?.Invoke(__value13);
            }
            else if (FunctionCallRequest is { } __value14)
            {
                functionCallRequest?.Invoke(__value14);
            }
            else if (FunctionCallCancelled is { } __value15)
            {
                functionCallCancelled?.Invoke(__value15);
            }
            else if (AgentStartedSpeaking is { } __value16)
            {
                agentStartedSpeaking?.Invoke(__value16);
            }
            else if (AgentAudioDone is { } __value17)
            {
                agentAudioDone?.Invoke(__value17);
            }
            else if (CustomFromThinkProvider is { } __value18)
            {
                customFromThinkProvider?.Invoke(__value18);
            }
            else if (AgentV1AgentV1Error is { } __value19)
            {
                agentV1AgentV1Error?.Invoke(__value19);
            }
            else if (AgentV1AgentV1Warning is { } __value20)
            {
                agentV1AgentV1Warning?.Invoke(__value20);
            }
            else if (AgentV1AgentV1History is { } __value21)
            {
                agentV1AgentV1History?.Invoke(__value21);
            }
            else if (AgentV1AgentV1Audio is { } __value22)
            {
                agentV1AgentV1Audio?.Invoke(__value22);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated>? listenUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated>? thinkUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated>? thinkLiveUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected>? frustrationDetected = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse>? functionCallResponse = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated>? promptUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated>? speakUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused>? injectionRefused = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Welcome>? welcome = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied>? settingsApplied = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ConversationText>? conversationText = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking>? userStartedSpeaking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking>? agentThinking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport>? latencyReport = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest>? functionCallRequest = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled>? functionCallCancelled = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking>? agentStartedSpeaking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone>? agentAudioDone = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider>? customFromThinkProvider = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Error>? agentV1AgentV1Error = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Warning>? agentV1AgentV1Warning = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1History?>? agentV1AgentV1History = null,
            global::System.Action<byte[]>? agentV1AgentV1Audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenUpdated is { } __value0)
            {
                listenUpdated?.Invoke(__value0);
            }
            else if (ThinkUpdated is { } __value1)
            {
                thinkUpdated?.Invoke(__value1);
            }
            else if (ThinkLiveUpdated is { } __value2)
            {
                thinkLiveUpdated?.Invoke(__value2);
            }
            else if (FrustrationDetected is { } __value3)
            {
                frustrationDetected?.Invoke(__value3);
            }
            else if (FunctionCallResponse is { } __value4)
            {
                functionCallResponse?.Invoke(__value4);
            }
            else if (PromptUpdated is { } __value5)
            {
                promptUpdated?.Invoke(__value5);
            }
            else if (SpeakUpdated is { } __value6)
            {
                speakUpdated?.Invoke(__value6);
            }
            else if (InjectionRefused is { } __value7)
            {
                injectionRefused?.Invoke(__value7);
            }
            else if (Welcome is { } __value8)
            {
                welcome?.Invoke(__value8);
            }
            else if (SettingsApplied is { } __value9)
            {
                settingsApplied?.Invoke(__value9);
            }
            else if (ConversationText is { } __value10)
            {
                conversationText?.Invoke(__value10);
            }
            else if (UserStartedSpeaking is { } __value11)
            {
                userStartedSpeaking?.Invoke(__value11);
            }
            else if (AgentThinking is { } __value12)
            {
                agentThinking?.Invoke(__value12);
            }
            else if (LatencyReport is { } __value13)
            {
                latencyReport?.Invoke(__value13);
            }
            else if (FunctionCallRequest is { } __value14)
            {
                functionCallRequest?.Invoke(__value14);
            }
            else if (FunctionCallCancelled is { } __value15)
            {
                functionCallCancelled?.Invoke(__value15);
            }
            else if (AgentStartedSpeaking is { } __value16)
            {
                agentStartedSpeaking?.Invoke(__value16);
            }
            else if (AgentAudioDone is { } __value17)
            {
                agentAudioDone?.Invoke(__value17);
            }
            else if (CustomFromThinkProvider is { } __value18)
            {
                customFromThinkProvider?.Invoke(__value18);
            }
            else if (AgentV1AgentV1Error is { } __value19)
            {
                agentV1AgentV1Error?.Invoke(__value19);
            }
            else if (AgentV1AgentV1Warning is { } __value20)
            {
                agentV1AgentV1Warning?.Invoke(__value20);
            }
            else if (AgentV1AgentV1History is { } __value21)
            {
                agentV1AgentV1History?.Invoke(__value21);
            }
            else if (AgentV1AgentV1Audio is { } __value22)
            {
                agentV1AgentV1Audio?.Invoke(__value22);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated),
                ThinkUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated),
                ThinkLiveUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated),
                FrustrationDetected,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected),
                FunctionCallResponse,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse),
                PromptUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated),
                SpeakUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated),
                InjectionRefused,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused),
                Welcome,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome),
                SettingsApplied,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied),
                ConversationText,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText),
                UserStartedSpeaking,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking),
                AgentThinking,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking),
                LatencyReport,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1LatencyReport),
                FunctionCallRequest,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest),
                FunctionCallCancelled,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled),
                AgentStartedSpeaking,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking),
                AgentAudioDone,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone),
                CustomFromThinkProvider,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider),
                AgentV1AgentV1Error,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1Error),
                AgentV1AgentV1Warning,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1Warning),
                AgentV1AgentV1History,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1History),
                AgentV1AgentV1Audio,
                typeof(byte[]),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ListenUpdated?>.Default.Equals(ListenUpdated, other.ListenUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?>.Default.Equals(ThinkUpdated, other.ThinkUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ThinkLiveUpdated?>.Default.Equals(ThinkLiveUpdated, other.ThinkLiveUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1FrustrationDetected?>.Default.Equals(FrustrationDetected, other.FrustrationDetected) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?>.Default.Equals(FunctionCallResponse, other.FunctionCallResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?>.Default.Equals(PromptUpdated, other.PromptUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?>.Default.Equals(SpeakUpdated, other.SpeakUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?>.Default.Equals(InjectionRefused, other.InjectionRefused) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1Welcome?>.Default.Equals(Welcome, other.Welcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?>.Default.Equals(SettingsApplied, other.SettingsApplied) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ConversationText?>.Default.Equals(ConversationText, other.ConversationText) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?>.Default.Equals(UserStartedSpeaking, other.UserStartedSpeaking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?>.Default.Equals(AgentThinking, other.AgentThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1LatencyReport?>.Default.Equals(LatencyReport, other.LatencyReport) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?>.Default.Equals(FunctionCallRequest, other.FunctionCallRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallCancelled?>.Default.Equals(FunctionCallCancelled, other.FunctionCallCancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?>.Default.Equals(AgentStartedSpeaking, other.AgentStartedSpeaking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?>.Default.Equals(AgentAudioDone, other.AgentAudioDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1CustomFromThinkProvider?>.Default.Equals(CustomFromThinkProvider, other.CustomFromThinkProvider) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1Error?>.Default.Equals(AgentV1AgentV1Error, other.AgentV1AgentV1Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1Warning?>.Default.Equals(AgentV1AgentV1Warning, other.AgentV1AgentV1Warning) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1History?>.Default.Equals(AgentV1AgentV1History, other.AgentV1AgentV1History) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(AgentV1AgentV1Audio, other.AgentV1AgentV1Audio)
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
