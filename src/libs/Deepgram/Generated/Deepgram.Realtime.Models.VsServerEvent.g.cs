#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VsServerEvent : global::System.IEquatable<VsServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? SpeakV2SpeakV2Audio { get; init; }
#else
        public byte[]? SpeakV2SpeakV2Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2Audio))]
#endif
        public bool IsSpeakV2SpeakV2Audio => SpeakV2SpeakV2Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeakV2SpeakV2Audio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = SpeakV2SpeakV2Audio;
            return IsSpeakV2SpeakV2Audio;
        }

        /// <summary>
        ///
        /// </summary>
        public byte[] PickSpeakV2SpeakV2Audio() => SpeakV2SpeakV2Audio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2Audio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Connected? Connected { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Connected? Connected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connected))]
#endif
        public bool IsConnected => Connected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Connected? value)
        {
            value = Connected;
            return IsConnected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Connected PickConnected() => Connected is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connected' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? SpeechStarted { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? SpeechStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechStarted))]
#endif
        public bool IsSpeechStarted => SpeechStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? value)
        {
            value = SpeechStarted;
            return IsSpeechStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted PickSpeechStarted() => SpeechStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechStarted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? SpeechMetadata { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? SpeechMetadata { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechMetadata))]
#endif
        public bool IsSpeechMetadata => SpeechMetadata != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechMetadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? value)
        {
            value = SpeechMetadata;
            return IsSpeechMetadata;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata PickSpeechMetadata() => SpeechMetadata is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechMetadata' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? SpeechInterrupted { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? SpeechInterrupted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechInterrupted))]
#endif
        public bool IsSpeechInterrupted => SpeechInterrupted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechInterrupted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? value)
        {
            value = SpeechInterrupted;
            return IsSpeechInterrupted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted PickSpeechInterrupted() => SpeechInterrupted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechInterrupted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? Flushed { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? Flushed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Flushed))]
#endif
        public bool IsFlushed => Flushed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFlushed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? value)
        {
            value = Flushed;
            return IsFlushed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Flushed PickFlushed() => Flushed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Flushed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? SessionMetadata { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? SessionMetadata { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionMetadata))]
#endif
        public bool IsSessionMetadata => SessionMetadata != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionMetadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? value)
        {
            value = SessionMetadata;
            return IsSessionMetadata;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata PickSessionMetadata() => SessionMetadata is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionMetadata' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? ConfigureSuccess { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? ConfigureSuccess { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureSuccess))]
#endif
        public bool IsConfigureSuccess => ConfigureSuccess != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConfigureSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? value)
        {
            value = ConfigureSuccess;
            return IsConfigureSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess PickConfigureSuccess() => ConfigureSuccess is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConfigureSuccess' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? ConfigureFailure { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? ConfigureFailure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureFailure))]
#endif
        public bool IsConfigureFailure => ConfigureFailure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConfigureFailure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? value)
        {
            value = ConfigureFailure;
            return IsConfigureFailure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure PickConfigureFailure() => ConfigureFailure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConfigureFailure' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Warning? Warning { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Warning? Warning { get; }
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
        public bool TryPickWarning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Warning? value)
        {
            value = Warning;
            return IsWarning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Warning PickWarning() => Warning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Warning' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Error? Error { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Error? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Error? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Error PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(byte[] value) => new VsServerEvent((byte[]?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator byte[]?(VsServerEvent @this) => @this.SpeakV2SpeakV2Audio;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(byte[]? value)
        {
            SpeakV2SpeakV2Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2Audio(byte[]? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Connected value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Connected?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Connected?(VsServerEvent @this) => @this.Connected;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Connected? value)
        {
            Connected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromConnected(global::Deepgram.Realtime.SpeakV2SpeakV2Connected? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?(VsServerEvent @this) => @this.SpeechStarted;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? value)
        {
            SpeechStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromSpeechStarted(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?(VsServerEvent @this) => @this.SpeechMetadata;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? value)
        {
            SpeechMetadata = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromSpeechMetadata(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted?(VsServerEvent @this) => @this.SpeechInterrupted;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? value)
        {
            SpeechInterrupted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromSpeechInterrupted(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?(VsServerEvent @this) => @this.Flushed;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? value)
        {
            Flushed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromFlushed(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?(VsServerEvent @this) => @this.SessionMetadata;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? value)
        {
            SessionMetadata = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromSessionMetadata(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess?(VsServerEvent @this) => @this.ConfigureSuccess;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? value)
        {
            ConfigureSuccess = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromConfigureSuccess(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure?(VsServerEvent @this) => @this.ConfigureFailure;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? value)
        {
            ConfigureFailure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromConfigureFailure(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Warning value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Warning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Warning?(VsServerEvent @this) => @this.Warning;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Warning? value)
        {
            Warning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromWarning(global::Deepgram.Realtime.SpeakV2SpeakV2Warning? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Error value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Error?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Error?(VsServerEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Error? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VsServerEvent FromError(global::Deepgram.Realtime.SpeakV2SpeakV2Error? value) => new VsServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public VsServerEvent(
            byte[]? speakV2SpeakV2Audio,
            global::Deepgram.Realtime.SpeakV2SpeakV2Connected? connected,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? speechStarted,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? speechMetadata,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted? speechInterrupted,
            global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? flushed,
            global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? sessionMetadata,
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess? configureSuccess,
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure? configureFailure,
            global::Deepgram.Realtime.SpeakV2SpeakV2Warning? warning,
            global::Deepgram.Realtime.SpeakV2SpeakV2Error? error
            )
        {
            SpeakV2SpeakV2Audio = speakV2SpeakV2Audio;
            Connected = connected;
            SpeechStarted = speechStarted;
            SpeechMetadata = speechMetadata;
            SpeechInterrupted = speechInterrupted;
            Flushed = flushed;
            SessionMetadata = sessionMetadata;
            ConfigureSuccess = configureSuccess;
            ConfigureFailure = configureFailure;
            Warning = warning;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Warning as object ??
            ConfigureFailure as object ??
            ConfigureSuccess as object ??
            SessionMetadata as object ??
            Flushed as object ??
            SpeechInterrupted as object ??
            SpeechMetadata as object ??
            SpeechStarted as object ??
            Connected as object ??
            SpeakV2SpeakV2Audio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SpeakV2SpeakV2Audio?.ToString() ??
            Connected?.ToString() ??
            SpeechStarted?.ToString() ??
            SpeechMetadata?.ToString() ??
            SpeechInterrupted?.ToString() ??
            Flushed?.ToString() ??
            SessionMetadata?.ToString() ??
            ConfigureSuccess?.ToString() ??
            ConfigureFailure?.ToString() ??
            Warning?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && IsConfigureFailure && !IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && IsWarning && !IsError || !IsSpeakV2SpeakV2Audio && !IsConnected && !IsSpeechStarted && !IsSpeechMetadata && !IsSpeechInterrupted && !IsFlushed && !IsSessionMetadata && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[], TResult>? speakV2SpeakV2Audio = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Connected, TResult>? connected = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted, TResult>? speechStarted = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata, TResult>? speechMetadata = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted, TResult>? speechInterrupted = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed, TResult>? flushed = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata, TResult>? sessionMetadata = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess, TResult>? configureSuccess = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure, TResult>? configureFailure = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Warning, TResult>? warning = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Error, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeakV2SpeakV2Audio is { } __value0 && speakV2SpeakV2Audio != null)
            {
                return speakV2SpeakV2Audio(__value0);
            }
            else if (Connected is { } __value1 && connected != null)
            {
                return connected(__value1);
            }
            else if (SpeechStarted is { } __value2 && speechStarted != null)
            {
                return speechStarted(__value2);
            }
            else if (SpeechMetadata is { } __value3 && speechMetadata != null)
            {
                return speechMetadata(__value3);
            }
            else if (SpeechInterrupted is { } __value4 && speechInterrupted != null)
            {
                return speechInterrupted(__value4);
            }
            else if (Flushed is { } __value5 && flushed != null)
            {
                return flushed(__value5);
            }
            else if (SessionMetadata is { } __value6 && sessionMetadata != null)
            {
                return sessionMetadata(__value6);
            }
            else if (ConfigureSuccess is { } __value7 && configureSuccess != null)
            {
                return configureSuccess(__value7);
            }
            else if (ConfigureFailure is { } __value8 && configureFailure != null)
            {
                return configureFailure(__value8);
            }
            else if (Warning is { } __value9 && warning != null)
            {
                return warning(__value9);
            }
            else if (Error is { } __value10 && error != null)
            {
                return error(__value10);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<byte[]>? speakV2SpeakV2Audio = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Connected>? connected = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted>? speechStarted = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata>? speechMetadata = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted>? speechInterrupted = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed>? flushed = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata>? sessionMetadata = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess>? configureSuccess = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure>? configureFailure = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Warning>? warning = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Error>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeakV2SpeakV2Audio is { } __value0)
            {
                speakV2SpeakV2Audio?.Invoke(__value0);
            }
            else if (Connected is { } __value1)
            {
                connected?.Invoke(__value1);
            }
            else if (SpeechStarted is { } __value2)
            {
                speechStarted?.Invoke(__value2);
            }
            else if (SpeechMetadata is { } __value3)
            {
                speechMetadata?.Invoke(__value3);
            }
            else if (SpeechInterrupted is { } __value4)
            {
                speechInterrupted?.Invoke(__value4);
            }
            else if (Flushed is { } __value5)
            {
                flushed?.Invoke(__value5);
            }
            else if (SessionMetadata is { } __value6)
            {
                sessionMetadata?.Invoke(__value6);
            }
            else if (ConfigureSuccess is { } __value7)
            {
                configureSuccess?.Invoke(__value7);
            }
            else if (ConfigureFailure is { } __value8)
            {
                configureFailure?.Invoke(__value8);
            }
            else if (Warning is { } __value9)
            {
                warning?.Invoke(__value9);
            }
            else if (Error is { } __value10)
            {
                error?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<byte[]>? speakV2SpeakV2Audio = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Connected>? connected = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted>? speechStarted = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata>? speechMetadata = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted>? speechInterrupted = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed>? flushed = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata>? sessionMetadata = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess>? configureSuccess = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure>? configureFailure = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Warning>? warning = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Error>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeakV2SpeakV2Audio is { } __value0)
            {
                speakV2SpeakV2Audio?.Invoke(__value0);
            }
            else if (Connected is { } __value1)
            {
                connected?.Invoke(__value1);
            }
            else if (SpeechStarted is { } __value2)
            {
                speechStarted?.Invoke(__value2);
            }
            else if (SpeechMetadata is { } __value3)
            {
                speechMetadata?.Invoke(__value3);
            }
            else if (SpeechInterrupted is { } __value4)
            {
                speechInterrupted?.Invoke(__value4);
            }
            else if (Flushed is { } __value5)
            {
                flushed?.Invoke(__value5);
            }
            else if (SessionMetadata is { } __value6)
            {
                sessionMetadata?.Invoke(__value6);
            }
            else if (ConfigureSuccess is { } __value7)
            {
                configureSuccess?.Invoke(__value7);
            }
            else if (ConfigureFailure is { } __value8)
            {
                configureFailure?.Invoke(__value8);
            }
            else if (Warning is { } __value9)
            {
                warning?.Invoke(__value9);
            }
            else if (Error is { } __value10)
            {
                error?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeakV2SpeakV2Audio,
                typeof(byte[]),
                Connected,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected),
                SpeechStarted,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted),
                SpeechMetadata,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata),
                SpeechInterrupted,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted),
                Flushed,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed),
                SessionMetadata,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata),
                ConfigureSuccess,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess),
                ConfigureFailure,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure),
                Warning,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning),
                Error,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Error),
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
        public bool Equals(VsServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(SpeakV2SpeakV2Audio, other.SpeakV2SpeakV2Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Connected?>.Default.Equals(Connected, other.Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?>.Default.Equals(SpeechStarted, other.SpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?>.Default.Equals(SpeechMetadata, other.SpeechMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechInterrupted?>.Default.Equals(SpeechInterrupted, other.SpeechInterrupted) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?>.Default.Equals(Flushed, other.Flushed) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?>.Default.Equals(SessionMetadata, other.SessionMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureSuccess?>.Default.Equals(ConfigureSuccess, other.ConfigureSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailure?>.Default.Equals(ConfigureFailure, other.ConfigureFailure) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Warning?>.Default.Equals(Warning, other.Warning) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Error?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VsServerEvent obj1, VsServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VsServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VsServerEvent obj1, VsServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VsServerEvent o && Equals(o);
        }
    }
}
