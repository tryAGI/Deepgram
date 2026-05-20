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
        /// Function call response message used bidirectionally:<br/>
        /// • **Client → Server**: Response after client executes a function<br/>
        ///   marked as client_side: true<br/>
        /// • **Server → Client**: Response after server executes a function<br/>
        ///   marked as client_side: false<br/>
        /// The same message structure serves both directions, enabling a unified<br/>
        /// interface for function call responses regardless of execution location.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? AgentV1AgentV1ReceiveFunctionCallResponse { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? AgentV1AgentV1ReceiveFunctionCallResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1ReceiveFunctionCallResponse))]
#endif
        public bool IsAgentV1AgentV1ReceiveFunctionCallResponse => AgentV1AgentV1ReceiveFunctionCallResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1ReceiveFunctionCallResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? value)
        {
            value = AgentV1AgentV1ReceiveFunctionCallResponse;
            return IsAgentV1AgentV1ReceiveFunctionCallResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse PickAgentV1AgentV1ReceiveFunctionCallResponse() => IsAgentV1AgentV1ReceiveFunctionCallResponse
            ? AgentV1AgentV1ReceiveFunctionCallResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1ReceiveFunctionCallResponse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? AgentV1AgentV1PromptUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? AgentV1AgentV1PromptUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1PromptUpdated))]
#endif
        public bool IsAgentV1AgentV1PromptUpdated => AgentV1AgentV1PromptUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1PromptUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? value)
        {
            value = AgentV1AgentV1PromptUpdated;
            return IsAgentV1AgentV1PromptUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated PickAgentV1AgentV1PromptUpdated() => IsAgentV1AgentV1PromptUpdated
            ? AgentV1AgentV1PromptUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1PromptUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? AgentV1AgentV1SpeakUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? AgentV1AgentV1SpeakUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1SpeakUpdated))]
#endif
        public bool IsAgentV1AgentV1SpeakUpdated => AgentV1AgentV1SpeakUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1SpeakUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? value)
        {
            value = AgentV1AgentV1SpeakUpdated;
            return IsAgentV1AgentV1SpeakUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated PickAgentV1AgentV1SpeakUpdated() => IsAgentV1AgentV1SpeakUpdated
            ? AgentV1AgentV1SpeakUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1SpeakUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? AgentV1AgentV1ThinkUpdated { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? AgentV1AgentV1ThinkUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1ThinkUpdated))]
#endif
        public bool IsAgentV1AgentV1ThinkUpdated => AgentV1AgentV1ThinkUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1ThinkUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? value)
        {
            value = AgentV1AgentV1ThinkUpdated;
            return IsAgentV1AgentV1ThinkUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated PickAgentV1AgentV1ThinkUpdated() => IsAgentV1AgentV1ThinkUpdated
            ? AgentV1AgentV1ThinkUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1ThinkUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? AgentV1AgentV1InjectionRefused { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? AgentV1AgentV1InjectionRefused { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1InjectionRefused))]
#endif
        public bool IsAgentV1AgentV1InjectionRefused => AgentV1AgentV1InjectionRefused != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1InjectionRefused(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? value)
        {
            value = AgentV1AgentV1InjectionRefused;
            return IsAgentV1AgentV1InjectionRefused;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused PickAgentV1AgentV1InjectionRefused() => IsAgentV1AgentV1InjectionRefused
            ? AgentV1AgentV1InjectionRefused!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1InjectionRefused' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1Welcome? AgentV1AgentV1Welcome { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1Welcome? AgentV1AgentV1Welcome { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1Welcome))]
#endif
        public bool IsAgentV1AgentV1Welcome => AgentV1AgentV1Welcome != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1Welcome(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1Welcome? value)
        {
            value = AgentV1AgentV1Welcome;
            return IsAgentV1AgentV1Welcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1Welcome PickAgentV1AgentV1Welcome() => IsAgentV1AgentV1Welcome
            ? AgentV1AgentV1Welcome!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1Welcome' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? AgentV1AgentV1SettingsApplied { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? AgentV1AgentV1SettingsApplied { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1SettingsApplied))]
#endif
        public bool IsAgentV1AgentV1SettingsApplied => AgentV1AgentV1SettingsApplied != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1SettingsApplied(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? value)
        {
            value = AgentV1AgentV1SettingsApplied;
            return IsAgentV1AgentV1SettingsApplied;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied PickAgentV1AgentV1SettingsApplied() => IsAgentV1AgentV1SettingsApplied
            ? AgentV1AgentV1SettingsApplied!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1SettingsApplied' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationText? AgentV1AgentV1ConversationText { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationText? AgentV1AgentV1ConversationText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1ConversationText))]
#endif
        public bool IsAgentV1AgentV1ConversationText => AgentV1AgentV1ConversationText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1ConversationText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1ConversationText? value)
        {
            value = AgentV1AgentV1ConversationText;
            return IsAgentV1AgentV1ConversationText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1ConversationText PickAgentV1AgentV1ConversationText() => IsAgentV1AgentV1ConversationText
            ? AgentV1AgentV1ConversationText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1ConversationText' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? AgentV1AgentV1UserStartedSpeaking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? AgentV1AgentV1UserStartedSpeaking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1UserStartedSpeaking))]
#endif
        public bool IsAgentV1AgentV1UserStartedSpeaking => AgentV1AgentV1UserStartedSpeaking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1UserStartedSpeaking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? value)
        {
            value = AgentV1AgentV1UserStartedSpeaking;
            return IsAgentV1AgentV1UserStartedSpeaking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking PickAgentV1AgentV1UserStartedSpeaking() => IsAgentV1AgentV1UserStartedSpeaking
            ? AgentV1AgentV1UserStartedSpeaking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1UserStartedSpeaking' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? AgentV1AgentV1AgentThinking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? AgentV1AgentV1AgentThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1AgentThinking))]
#endif
        public bool IsAgentV1AgentV1AgentThinking => AgentV1AgentV1AgentThinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1AgentThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? value)
        {
            value = AgentV1AgentV1AgentThinking;
            return IsAgentV1AgentV1AgentThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1AgentThinking PickAgentV1AgentV1AgentThinking() => IsAgentV1AgentV1AgentThinking
            ? AgentV1AgentV1AgentThinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1AgentThinking' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? AgentV1AgentV1FunctionCallRequest { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? AgentV1AgentV1FunctionCallRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1FunctionCallRequest))]
#endif
        public bool IsAgentV1AgentV1FunctionCallRequest => AgentV1AgentV1FunctionCallRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1FunctionCallRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? value)
        {
            value = AgentV1AgentV1FunctionCallRequest;
            return IsAgentV1AgentV1FunctionCallRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest PickAgentV1AgentV1FunctionCallRequest() => IsAgentV1AgentV1FunctionCallRequest
            ? AgentV1AgentV1FunctionCallRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1FunctionCallRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? AgentV1AgentV1AgentStartedSpeaking { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? AgentV1AgentV1AgentStartedSpeaking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1AgentStartedSpeaking))]
#endif
        public bool IsAgentV1AgentV1AgentStartedSpeaking => AgentV1AgentV1AgentStartedSpeaking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1AgentStartedSpeaking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? value)
        {
            value = AgentV1AgentV1AgentStartedSpeaking;
            return IsAgentV1AgentV1AgentStartedSpeaking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking PickAgentV1AgentV1AgentStartedSpeaking() => IsAgentV1AgentV1AgentStartedSpeaking
            ? AgentV1AgentV1AgentStartedSpeaking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1AgentStartedSpeaking' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? AgentV1AgentV1AgentAudioDone { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? AgentV1AgentV1AgentAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1AgentAudioDone))]
#endif
        public bool IsAgentV1AgentV1AgentAudioDone => AgentV1AgentV1AgentAudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentV1AgentV1AgentAudioDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? value)
        {
            value = AgentV1AgentV1AgentAudioDone;
            return IsAgentV1AgentV1AgentAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone PickAgentV1AgentV1AgentAudioDone() => IsAgentV1AgentV1AgentAudioDone
            ? AgentV1AgentV1AgentAudioDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1AgentAudioDone' but the value was {ToString()}.");

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
        public global::Deepgram.Realtime.AgentV1AgentV1Error PickAgentV1AgentV1Error() => IsAgentV1AgentV1Error
            ? AgentV1AgentV1Error!
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
        public global::Deepgram.Realtime.AgentV1AgentV1Warning PickAgentV1AgentV1Warning() => IsAgentV1AgentV1Warning
            ? AgentV1AgentV1Warning!
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
        public global::Deepgram.Realtime.AgentV1AgentV1History PickAgentV1AgentV1History() => IsAgentV1AgentV1History
            ? AgentV1AgentV1History!.Value
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
        public byte[] PickAgentV1AgentV1Audio() => IsAgentV1AgentV1Audio
            ? AgentV1AgentV1Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentV1AgentV1Audio' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1ReceiveFunctionCallResponse;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? value)
        {
            AgentV1AgentV1ReceiveFunctionCallResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1ReceiveFunctionCallResponse(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1PromptUpdated;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? value)
        {
            AgentV1AgentV1PromptUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1PromptUpdated(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1SpeakUpdated;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? value)
        {
            AgentV1AgentV1SpeakUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1SpeakUpdated(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1ThinkUpdated;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? value)
        {
            AgentV1AgentV1ThinkUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1ThinkUpdated(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1InjectionRefused;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? value)
        {
            AgentV1AgentV1InjectionRefused = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1InjectionRefused(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Welcome value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1Welcome?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1Welcome?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1Welcome;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1Welcome? value)
        {
            AgentV1AgentV1Welcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1Welcome(global::Deepgram.Realtime.AgentV1AgentV1Welcome? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1SettingsApplied;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? value)
        {
            AgentV1AgentV1SettingsApplied = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1SettingsApplied(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ConversationText value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1ConversationText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1ConversationText?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1ConversationText;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1ConversationText? value)
        {
            AgentV1AgentV1ConversationText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1ConversationText(global::Deepgram.Realtime.AgentV1AgentV1ConversationText? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1UserStartedSpeaking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? value)
        {
            AgentV1AgentV1UserStartedSpeaking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1UserStartedSpeaking(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1AgentThinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? value)
        {
            AgentV1AgentV1AgentThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1AgentThinking(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1FunctionCallRequest;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? value)
        {
            AgentV1AgentV1FunctionCallRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1FunctionCallRequest(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1AgentStartedSpeaking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? value)
        {
            AgentV1AgentV1AgentStartedSpeaking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1AgentStartedSpeaking(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? value) => new AgentV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone value) => new AgentV1ServerEvent((global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?(AgentV1ServerEvent @this) => @this.AgentV1AgentV1AgentAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? value)
        {
            AgentV1AgentV1AgentAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentV1ServerEvent FromAgentV1AgentV1AgentAudioDone(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? value) => new AgentV1ServerEvent(value);

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
            global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse? agentV1AgentV1ReceiveFunctionCallResponse,
            global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated? agentV1AgentV1PromptUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated? agentV1AgentV1SpeakUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated? agentV1AgentV1ThinkUpdated,
            global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused? agentV1AgentV1InjectionRefused,
            global::Deepgram.Realtime.AgentV1AgentV1Welcome? agentV1AgentV1Welcome,
            global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied? agentV1AgentV1SettingsApplied,
            global::Deepgram.Realtime.AgentV1AgentV1ConversationText? agentV1AgentV1ConversationText,
            global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking? agentV1AgentV1UserStartedSpeaking,
            global::Deepgram.Realtime.AgentV1AgentV1AgentThinking? agentV1AgentV1AgentThinking,
            global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest? agentV1AgentV1FunctionCallRequest,
            global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking? agentV1AgentV1AgentStartedSpeaking,
            global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone? agentV1AgentV1AgentAudioDone,
            global::Deepgram.Realtime.AgentV1AgentV1Error? agentV1AgentV1Error,
            global::Deepgram.Realtime.AgentV1AgentV1Warning? agentV1AgentV1Warning,
            global::Deepgram.Realtime.AgentV1AgentV1History? agentV1AgentV1History,
            byte[]? agentV1AgentV1Audio
            )
        {
            AgentV1AgentV1ReceiveFunctionCallResponse = agentV1AgentV1ReceiveFunctionCallResponse;
            AgentV1AgentV1PromptUpdated = agentV1AgentV1PromptUpdated;
            AgentV1AgentV1SpeakUpdated = agentV1AgentV1SpeakUpdated;
            AgentV1AgentV1ThinkUpdated = agentV1AgentV1ThinkUpdated;
            AgentV1AgentV1InjectionRefused = agentV1AgentV1InjectionRefused;
            AgentV1AgentV1Welcome = agentV1AgentV1Welcome;
            AgentV1AgentV1SettingsApplied = agentV1AgentV1SettingsApplied;
            AgentV1AgentV1ConversationText = agentV1AgentV1ConversationText;
            AgentV1AgentV1UserStartedSpeaking = agentV1AgentV1UserStartedSpeaking;
            AgentV1AgentV1AgentThinking = agentV1AgentV1AgentThinking;
            AgentV1AgentV1FunctionCallRequest = agentV1AgentV1FunctionCallRequest;
            AgentV1AgentV1AgentStartedSpeaking = agentV1AgentV1AgentStartedSpeaking;
            AgentV1AgentV1AgentAudioDone = agentV1AgentV1AgentAudioDone;
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
            AgentV1AgentV1AgentAudioDone as object ??
            AgentV1AgentV1AgentStartedSpeaking as object ??
            AgentV1AgentV1FunctionCallRequest as object ??
            AgentV1AgentV1AgentThinking as object ??
            AgentV1AgentV1UserStartedSpeaking as object ??
            AgentV1AgentV1ConversationText as object ??
            AgentV1AgentV1SettingsApplied as object ??
            AgentV1AgentV1Welcome as object ??
            AgentV1AgentV1InjectionRefused as object ??
            AgentV1AgentV1ThinkUpdated as object ??
            AgentV1AgentV1SpeakUpdated as object ??
            AgentV1AgentV1PromptUpdated as object ??
            AgentV1AgentV1ReceiveFunctionCallResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentV1AgentV1ReceiveFunctionCallResponse?.ToString() ??
            AgentV1AgentV1PromptUpdated?.ToString() ??
            AgentV1AgentV1SpeakUpdated?.ToString() ??
            AgentV1AgentV1ThinkUpdated?.ToString() ??
            AgentV1AgentV1InjectionRefused?.ToString() ??
            AgentV1AgentV1Welcome?.ToString() ??
            AgentV1AgentV1SettingsApplied?.ToString() ??
            AgentV1AgentV1ConversationText?.ToString() ??
            AgentV1AgentV1UserStartedSpeaking?.ToString() ??
            AgentV1AgentV1AgentThinking?.ToString() ??
            AgentV1AgentV1FunctionCallRequest?.ToString() ??
            AgentV1AgentV1AgentStartedSpeaking?.ToString() ??
            AgentV1AgentV1AgentAudioDone?.ToString() ??
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
            return IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && IsAgentV1AgentV1History && !IsAgentV1AgentV1Audio || !IsAgentV1AgentV1ReceiveFunctionCallResponse && !IsAgentV1AgentV1PromptUpdated && !IsAgentV1AgentV1SpeakUpdated && !IsAgentV1AgentV1ThinkUpdated && !IsAgentV1AgentV1InjectionRefused && !IsAgentV1AgentV1Welcome && !IsAgentV1AgentV1SettingsApplied && !IsAgentV1AgentV1ConversationText && !IsAgentV1AgentV1UserStartedSpeaking && !IsAgentV1AgentV1AgentThinking && !IsAgentV1AgentV1FunctionCallRequest && !IsAgentV1AgentV1AgentStartedSpeaking && !IsAgentV1AgentV1AgentAudioDone && !IsAgentV1AgentV1Error && !IsAgentV1AgentV1Warning && !IsAgentV1AgentV1History && IsAgentV1AgentV1Audio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse, TResult>? agentV1AgentV1ReceiveFunctionCallResponse = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated, TResult>? agentV1AgentV1PromptUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated, TResult>? agentV1AgentV1SpeakUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated, TResult>? agentV1AgentV1ThinkUpdated = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused, TResult>? agentV1AgentV1InjectionRefused = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1Welcome, TResult>? agentV1AgentV1Welcome = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied, TResult>? agentV1AgentV1SettingsApplied = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1ConversationText, TResult>? agentV1AgentV1ConversationText = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking, TResult>? agentV1AgentV1UserStartedSpeaking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking, TResult>? agentV1AgentV1AgentThinking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest, TResult>? agentV1AgentV1FunctionCallRequest = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking, TResult>? agentV1AgentV1AgentStartedSpeaking = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone, TResult>? agentV1AgentV1AgentAudioDone = null,
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

            if (IsAgentV1AgentV1ReceiveFunctionCallResponse && agentV1AgentV1ReceiveFunctionCallResponse != null)
            {
                return agentV1AgentV1ReceiveFunctionCallResponse(AgentV1AgentV1ReceiveFunctionCallResponse!);
            }
            else if (IsAgentV1AgentV1PromptUpdated && agentV1AgentV1PromptUpdated != null)
            {
                return agentV1AgentV1PromptUpdated(AgentV1AgentV1PromptUpdated!);
            }
            else if (IsAgentV1AgentV1SpeakUpdated && agentV1AgentV1SpeakUpdated != null)
            {
                return agentV1AgentV1SpeakUpdated(AgentV1AgentV1SpeakUpdated!);
            }
            else if (IsAgentV1AgentV1ThinkUpdated && agentV1AgentV1ThinkUpdated != null)
            {
                return agentV1AgentV1ThinkUpdated(AgentV1AgentV1ThinkUpdated!);
            }
            else if (IsAgentV1AgentV1InjectionRefused && agentV1AgentV1InjectionRefused != null)
            {
                return agentV1AgentV1InjectionRefused(AgentV1AgentV1InjectionRefused!);
            }
            else if (IsAgentV1AgentV1Welcome && agentV1AgentV1Welcome != null)
            {
                return agentV1AgentV1Welcome(AgentV1AgentV1Welcome!);
            }
            else if (IsAgentV1AgentV1SettingsApplied && agentV1AgentV1SettingsApplied != null)
            {
                return agentV1AgentV1SettingsApplied(AgentV1AgentV1SettingsApplied!);
            }
            else if (IsAgentV1AgentV1ConversationText && agentV1AgentV1ConversationText != null)
            {
                return agentV1AgentV1ConversationText(AgentV1AgentV1ConversationText!);
            }
            else if (IsAgentV1AgentV1UserStartedSpeaking && agentV1AgentV1UserStartedSpeaking != null)
            {
                return agentV1AgentV1UserStartedSpeaking(AgentV1AgentV1UserStartedSpeaking!);
            }
            else if (IsAgentV1AgentV1AgentThinking && agentV1AgentV1AgentThinking != null)
            {
                return agentV1AgentV1AgentThinking(AgentV1AgentV1AgentThinking!);
            }
            else if (IsAgentV1AgentV1FunctionCallRequest && agentV1AgentV1FunctionCallRequest != null)
            {
                return agentV1AgentV1FunctionCallRequest(AgentV1AgentV1FunctionCallRequest!);
            }
            else if (IsAgentV1AgentV1AgentStartedSpeaking && agentV1AgentV1AgentStartedSpeaking != null)
            {
                return agentV1AgentV1AgentStartedSpeaking(AgentV1AgentV1AgentStartedSpeaking!);
            }
            else if (IsAgentV1AgentV1AgentAudioDone && agentV1AgentV1AgentAudioDone != null)
            {
                return agentV1AgentV1AgentAudioDone(AgentV1AgentV1AgentAudioDone!);
            }
            else if (IsAgentV1AgentV1Error && agentV1AgentV1Error != null)
            {
                return agentV1AgentV1Error(AgentV1AgentV1Error!);
            }
            else if (IsAgentV1AgentV1Warning && agentV1AgentV1Warning != null)
            {
                return agentV1AgentV1Warning(AgentV1AgentV1Warning!);
            }
            else if (IsAgentV1AgentV1History && agentV1AgentV1History != null)
            {
                return agentV1AgentV1History(AgentV1AgentV1History!);
            }
            else if (IsAgentV1AgentV1Audio && agentV1AgentV1Audio != null)
            {
                return agentV1AgentV1Audio(AgentV1AgentV1Audio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse>? agentV1AgentV1ReceiveFunctionCallResponse = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated>? agentV1AgentV1PromptUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated>? agentV1AgentV1SpeakUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated>? agentV1AgentV1ThinkUpdated = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused>? agentV1AgentV1InjectionRefused = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Welcome>? agentV1AgentV1Welcome = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied>? agentV1AgentV1SettingsApplied = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ConversationText>? agentV1AgentV1ConversationText = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking>? agentV1AgentV1UserStartedSpeaking = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking>? agentV1AgentV1AgentThinking = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest>? agentV1AgentV1FunctionCallRequest = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking>? agentV1AgentV1AgentStartedSpeaking = null,

            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone>? agentV1AgentV1AgentAudioDone = null,

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

            if (IsAgentV1AgentV1ReceiveFunctionCallResponse)
            {
                agentV1AgentV1ReceiveFunctionCallResponse?.Invoke(AgentV1AgentV1ReceiveFunctionCallResponse!);
            }
            else if (IsAgentV1AgentV1PromptUpdated)
            {
                agentV1AgentV1PromptUpdated?.Invoke(AgentV1AgentV1PromptUpdated!);
            }
            else if (IsAgentV1AgentV1SpeakUpdated)
            {
                agentV1AgentV1SpeakUpdated?.Invoke(AgentV1AgentV1SpeakUpdated!);
            }
            else if (IsAgentV1AgentV1ThinkUpdated)
            {
                agentV1AgentV1ThinkUpdated?.Invoke(AgentV1AgentV1ThinkUpdated!);
            }
            else if (IsAgentV1AgentV1InjectionRefused)
            {
                agentV1AgentV1InjectionRefused?.Invoke(AgentV1AgentV1InjectionRefused!);
            }
            else if (IsAgentV1AgentV1Welcome)
            {
                agentV1AgentV1Welcome?.Invoke(AgentV1AgentV1Welcome!);
            }
            else if (IsAgentV1AgentV1SettingsApplied)
            {
                agentV1AgentV1SettingsApplied?.Invoke(AgentV1AgentV1SettingsApplied!);
            }
            else if (IsAgentV1AgentV1ConversationText)
            {
                agentV1AgentV1ConversationText?.Invoke(AgentV1AgentV1ConversationText!);
            }
            else if (IsAgentV1AgentV1UserStartedSpeaking)
            {
                agentV1AgentV1UserStartedSpeaking?.Invoke(AgentV1AgentV1UserStartedSpeaking!);
            }
            else if (IsAgentV1AgentV1AgentThinking)
            {
                agentV1AgentV1AgentThinking?.Invoke(AgentV1AgentV1AgentThinking!);
            }
            else if (IsAgentV1AgentV1FunctionCallRequest)
            {
                agentV1AgentV1FunctionCallRequest?.Invoke(AgentV1AgentV1FunctionCallRequest!);
            }
            else if (IsAgentV1AgentV1AgentStartedSpeaking)
            {
                agentV1AgentV1AgentStartedSpeaking?.Invoke(AgentV1AgentV1AgentStartedSpeaking!);
            }
            else if (IsAgentV1AgentV1AgentAudioDone)
            {
                agentV1AgentV1AgentAudioDone?.Invoke(AgentV1AgentV1AgentAudioDone!);
            }
            else if (IsAgentV1AgentV1Error)
            {
                agentV1AgentV1Error?.Invoke(AgentV1AgentV1Error!);
            }
            else if (IsAgentV1AgentV1Warning)
            {
                agentV1AgentV1Warning?.Invoke(AgentV1AgentV1Warning!);
            }
            else if (IsAgentV1AgentV1History)
            {
                agentV1AgentV1History?.Invoke(AgentV1AgentV1History!);
            }
            else if (IsAgentV1AgentV1Audio)
            {
                agentV1AgentV1Audio?.Invoke(AgentV1AgentV1Audio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse>? agentV1AgentV1ReceiveFunctionCallResponse = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated>? agentV1AgentV1PromptUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated>? agentV1AgentV1SpeakUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated>? agentV1AgentV1ThinkUpdated = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused>? agentV1AgentV1InjectionRefused = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1Welcome>? agentV1AgentV1Welcome = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied>? agentV1AgentV1SettingsApplied = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1ConversationText>? agentV1AgentV1ConversationText = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking>? agentV1AgentV1UserStartedSpeaking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking>? agentV1AgentV1AgentThinking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest>? agentV1AgentV1FunctionCallRequest = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking>? agentV1AgentV1AgentStartedSpeaking = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone>? agentV1AgentV1AgentAudioDone = null,
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

            if (IsAgentV1AgentV1ReceiveFunctionCallResponse)
            {
                agentV1AgentV1ReceiveFunctionCallResponse?.Invoke(AgentV1AgentV1ReceiveFunctionCallResponse!);
            }
            else if (IsAgentV1AgentV1PromptUpdated)
            {
                agentV1AgentV1PromptUpdated?.Invoke(AgentV1AgentV1PromptUpdated!);
            }
            else if (IsAgentV1AgentV1SpeakUpdated)
            {
                agentV1AgentV1SpeakUpdated?.Invoke(AgentV1AgentV1SpeakUpdated!);
            }
            else if (IsAgentV1AgentV1ThinkUpdated)
            {
                agentV1AgentV1ThinkUpdated?.Invoke(AgentV1AgentV1ThinkUpdated!);
            }
            else if (IsAgentV1AgentV1InjectionRefused)
            {
                agentV1AgentV1InjectionRefused?.Invoke(AgentV1AgentV1InjectionRefused!);
            }
            else if (IsAgentV1AgentV1Welcome)
            {
                agentV1AgentV1Welcome?.Invoke(AgentV1AgentV1Welcome!);
            }
            else if (IsAgentV1AgentV1SettingsApplied)
            {
                agentV1AgentV1SettingsApplied?.Invoke(AgentV1AgentV1SettingsApplied!);
            }
            else if (IsAgentV1AgentV1ConversationText)
            {
                agentV1AgentV1ConversationText?.Invoke(AgentV1AgentV1ConversationText!);
            }
            else if (IsAgentV1AgentV1UserStartedSpeaking)
            {
                agentV1AgentV1UserStartedSpeaking?.Invoke(AgentV1AgentV1UserStartedSpeaking!);
            }
            else if (IsAgentV1AgentV1AgentThinking)
            {
                agentV1AgentV1AgentThinking?.Invoke(AgentV1AgentV1AgentThinking!);
            }
            else if (IsAgentV1AgentV1FunctionCallRequest)
            {
                agentV1AgentV1FunctionCallRequest?.Invoke(AgentV1AgentV1FunctionCallRequest!);
            }
            else if (IsAgentV1AgentV1AgentStartedSpeaking)
            {
                agentV1AgentV1AgentStartedSpeaking?.Invoke(AgentV1AgentV1AgentStartedSpeaking!);
            }
            else if (IsAgentV1AgentV1AgentAudioDone)
            {
                agentV1AgentV1AgentAudioDone?.Invoke(AgentV1AgentV1AgentAudioDone!);
            }
            else if (IsAgentV1AgentV1Error)
            {
                agentV1AgentV1Error?.Invoke(AgentV1AgentV1Error!);
            }
            else if (IsAgentV1AgentV1Warning)
            {
                agentV1AgentV1Warning?.Invoke(AgentV1AgentV1Warning!);
            }
            else if (IsAgentV1AgentV1History)
            {
                agentV1AgentV1History?.Invoke(AgentV1AgentV1History!);
            }
            else if (IsAgentV1AgentV1Audio)
            {
                agentV1AgentV1Audio?.Invoke(AgentV1AgentV1Audio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentV1AgentV1ReceiveFunctionCallResponse,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse),
                AgentV1AgentV1PromptUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated),
                AgentV1AgentV1SpeakUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated),
                AgentV1AgentV1ThinkUpdated,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated),
                AgentV1AgentV1InjectionRefused,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused),
                AgentV1AgentV1Welcome,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1Welcome),
                AgentV1AgentV1SettingsApplied,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied),
                AgentV1AgentV1ConversationText,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1ConversationText),
                AgentV1AgentV1UserStartedSpeaking,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking),
                AgentV1AgentV1AgentThinking,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentThinking),
                AgentV1AgentV1FunctionCallRequest,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest),
                AgentV1AgentV1AgentStartedSpeaking,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking),
                AgentV1AgentV1AgentAudioDone,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ReceiveFunctionCallResponse?>.Default.Equals(AgentV1AgentV1ReceiveFunctionCallResponse, other.AgentV1AgentV1ReceiveFunctionCallResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1PromptUpdated?>.Default.Equals(AgentV1AgentV1PromptUpdated, other.AgentV1AgentV1PromptUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1SpeakUpdated?>.Default.Equals(AgentV1AgentV1SpeakUpdated, other.AgentV1AgentV1SpeakUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ThinkUpdated?>.Default.Equals(AgentV1AgentV1ThinkUpdated, other.AgentV1AgentV1ThinkUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1InjectionRefused?>.Default.Equals(AgentV1AgentV1InjectionRefused, other.AgentV1AgentV1InjectionRefused) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1Welcome?>.Default.Equals(AgentV1AgentV1Welcome, other.AgentV1AgentV1Welcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1SettingsApplied?>.Default.Equals(AgentV1AgentV1SettingsApplied, other.AgentV1AgentV1SettingsApplied) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1ConversationText?>.Default.Equals(AgentV1AgentV1ConversationText, other.AgentV1AgentV1ConversationText) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1UserStartedSpeaking?>.Default.Equals(AgentV1AgentV1UserStartedSpeaking, other.AgentV1AgentV1UserStartedSpeaking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1AgentThinking?>.Default.Equals(AgentV1AgentV1AgentThinking, other.AgentV1AgentV1AgentThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1FunctionCallRequest?>.Default.Equals(AgentV1AgentV1FunctionCallRequest, other.AgentV1AgentV1FunctionCallRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1AgentStartedSpeaking?>.Default.Equals(AgentV1AgentV1AgentStartedSpeaking, other.AgentV1AgentV1AgentStartedSpeaking) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1AgentAudioDone?>.Default.Equals(AgentV1AgentV1AgentAudioDone, other.AgentV1AgentV1AgentAudioDone) &&
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
