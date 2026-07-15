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
        public byte[] PickSpeakV2SpeakV2Audio() => IsSpeakV2SpeakV2Audio
            ? SpeakV2SpeakV2Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2Audio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Connected? SpeakV2SpeakV2Connected { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Connected? SpeakV2SpeakV2Connected { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2Connected))]
#endif
        public bool IsSpeakV2SpeakV2Connected => SpeakV2SpeakV2Connected != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2Connected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Connected? value)
        {
            value = SpeakV2SpeakV2Connected;
            return IsSpeakV2SpeakV2Connected;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Connected PickSpeakV2SpeakV2Connected() => IsSpeakV2SpeakV2Connected
            ? SpeakV2SpeakV2Connected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2Connected' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? SpeakV2SpeakV2SpeechStarted { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? SpeakV2SpeakV2SpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2SpeechStarted))]
#endif
        public bool IsSpeakV2SpeakV2SpeechStarted => SpeakV2SpeakV2SpeechStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2SpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? value)
        {
            value = SpeakV2SpeakV2SpeechStarted;
            return IsSpeakV2SpeakV2SpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted PickSpeakV2SpeakV2SpeechStarted() => IsSpeakV2SpeakV2SpeechStarted
            ? SpeakV2SpeakV2SpeechStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2SpeechStarted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? SpeakV2SpeakV2SpeechMetadata { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? SpeakV2SpeakV2SpeechMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2SpeechMetadata))]
#endif
        public bool IsSpeakV2SpeakV2SpeechMetadata => SpeakV2SpeakV2SpeechMetadata != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2SpeechMetadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? value)
        {
            value = SpeakV2SpeakV2SpeechMetadata;
            return IsSpeakV2SpeakV2SpeechMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata PickSpeakV2SpeakV2SpeechMetadata() => IsSpeakV2SpeakV2SpeechMetadata
            ? SpeakV2SpeakV2SpeechMetadata!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2SpeechMetadata' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? SpeakV2SpeakV2Flushed { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? SpeakV2SpeakV2Flushed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2Flushed))]
#endif
        public bool IsSpeakV2SpeakV2Flushed => SpeakV2SpeakV2Flushed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2Flushed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? value)
        {
            value = SpeakV2SpeakV2Flushed;
            return IsSpeakV2SpeakV2Flushed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Flushed PickSpeakV2SpeakV2Flushed() => IsSpeakV2SpeakV2Flushed
            ? SpeakV2SpeakV2Flushed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2Flushed' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? SpeakV2SpeakV2SessionMetadata { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? SpeakV2SpeakV2SessionMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2SessionMetadata))]
#endif
        public bool IsSpeakV2SpeakV2SessionMetadata => SpeakV2SpeakV2SessionMetadata != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2SessionMetadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? value)
        {
            value = SpeakV2SpeakV2SessionMetadata;
            return IsSpeakV2SpeakV2SessionMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata PickSpeakV2SpeakV2SessionMetadata() => IsSpeakV2SpeakV2SessionMetadata
            ? SpeakV2SpeakV2SessionMetadata!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2SessionMetadata' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Warning? SpeakV2SpeakV2Warning { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Warning? SpeakV2SpeakV2Warning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2Warning))]
#endif
        public bool IsSpeakV2SpeakV2Warning => SpeakV2SpeakV2Warning != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2Warning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Warning? value)
        {
            value = SpeakV2SpeakV2Warning;
            return IsSpeakV2SpeakV2Warning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Warning PickSpeakV2SpeakV2Warning() => IsSpeakV2SpeakV2Warning
            ? SpeakV2SpeakV2Warning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2Warning' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV2SpeakV2Error? SpeakV2SpeakV2Error { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV2SpeakV2Error? SpeakV2SpeakV2Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV2SpeakV2Error))]
#endif
        public bool IsSpeakV2SpeakV2Error => SpeakV2SpeakV2Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV2SpeakV2Error(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV2SpeakV2Error? value)
        {
            value = SpeakV2SpeakV2Error;
            return IsSpeakV2SpeakV2Error;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV2SpeakV2Error PickSpeakV2SpeakV2Error() => IsSpeakV2SpeakV2Error
            ? SpeakV2SpeakV2Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV2SpeakV2Error' but the value was {ToString()}.");
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
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Connected?(VsServerEvent @this) => @this.SpeakV2SpeakV2Connected;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Connected? value)
        {
            SpeakV2SpeakV2Connected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2Connected(global::Deepgram.Realtime.SpeakV2SpeakV2Connected? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?(VsServerEvent @this) => @this.SpeakV2SpeakV2SpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? value)
        {
            SpeakV2SpeakV2SpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2SpeechStarted(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?(VsServerEvent @this) => @this.SpeakV2SpeakV2SpeechMetadata;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? value)
        {
            SpeakV2SpeakV2SpeechMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2SpeechMetadata(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?(VsServerEvent @this) => @this.SpeakV2SpeakV2Flushed;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? value)
        {
            SpeakV2SpeakV2Flushed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2Flushed(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?(VsServerEvent @this) => @this.SpeakV2SpeakV2SessionMetadata;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? value)
        {
            SpeakV2SpeakV2SessionMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2SessionMetadata(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Warning value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Warning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Warning?(VsServerEvent @this) => @this.SpeakV2SpeakV2Warning;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Warning? value)
        {
            SpeakV2SpeakV2Warning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2Warning(global::Deepgram.Realtime.SpeakV2SpeakV2Warning? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Error value) => new VsServerEvent((global::Deepgram.Realtime.SpeakV2SpeakV2Error?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV2SpeakV2Error?(VsServerEvent @this) => @this.SpeakV2SpeakV2Error;

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(global::Deepgram.Realtime.SpeakV2SpeakV2Error? value)
        {
            SpeakV2SpeakV2Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VsServerEvent FromSpeakV2SpeakV2Error(global::Deepgram.Realtime.SpeakV2SpeakV2Error? value) => new VsServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public VsServerEvent(
            byte[]? speakV2SpeakV2Audio,
            global::Deepgram.Realtime.SpeakV2SpeakV2Connected? speakV2SpeakV2Connected,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted? speakV2SpeakV2SpeechStarted,
            global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata? speakV2SpeakV2SpeechMetadata,
            global::Deepgram.Realtime.SpeakV2SpeakV2Flushed? speakV2SpeakV2Flushed,
            global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata? speakV2SpeakV2SessionMetadata,
            global::Deepgram.Realtime.SpeakV2SpeakV2Warning? speakV2SpeakV2Warning,
            global::Deepgram.Realtime.SpeakV2SpeakV2Error? speakV2SpeakV2Error
            )
        {
            SpeakV2SpeakV2Audio = speakV2SpeakV2Audio;
            SpeakV2SpeakV2Connected = speakV2SpeakV2Connected;
            SpeakV2SpeakV2SpeechStarted = speakV2SpeakV2SpeechStarted;
            SpeakV2SpeakV2SpeechMetadata = speakV2SpeakV2SpeechMetadata;
            SpeakV2SpeakV2Flushed = speakV2SpeakV2Flushed;
            SpeakV2SpeakV2SessionMetadata = speakV2SpeakV2SessionMetadata;
            SpeakV2SpeakV2Warning = speakV2SpeakV2Warning;
            SpeakV2SpeakV2Error = speakV2SpeakV2Error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeakV2SpeakV2Error as object ??
            SpeakV2SpeakV2Warning as object ??
            SpeakV2SpeakV2SessionMetadata as object ??
            SpeakV2SpeakV2Flushed as object ??
            SpeakV2SpeakV2SpeechMetadata as object ??
            SpeakV2SpeakV2SpeechStarted as object ??
            SpeakV2SpeakV2Connected as object ??
            SpeakV2SpeakV2Audio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpeakV2SpeakV2Audio?.ToString() ??
            SpeakV2SpeakV2Connected?.ToString() ??
            SpeakV2SpeakV2SpeechStarted?.ToString() ??
            SpeakV2SpeakV2SpeechMetadata?.ToString() ??
            SpeakV2SpeakV2Flushed?.ToString() ??
            SpeakV2SpeakV2SessionMetadata?.ToString() ??
            SpeakV2SpeakV2Warning?.ToString() ??
            SpeakV2SpeakV2Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && IsSpeakV2SpeakV2Warning && !IsSpeakV2SpeakV2Error || !IsSpeakV2SpeakV2Audio && !IsSpeakV2SpeakV2Connected && !IsSpeakV2SpeakV2SpeechStarted && !IsSpeakV2SpeakV2SpeechMetadata && !IsSpeakV2SpeakV2Flushed && !IsSpeakV2SpeakV2SessionMetadata && !IsSpeakV2SpeakV2Warning && IsSpeakV2SpeakV2Error;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[], TResult>? speakV2SpeakV2Audio = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Connected, TResult>? speakV2SpeakV2Connected = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted, TResult>? speakV2SpeakV2SpeechStarted = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata, TResult>? speakV2SpeakV2SpeechMetadata = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed, TResult>? speakV2SpeakV2Flushed = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata, TResult>? speakV2SpeakV2SessionMetadata = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Warning, TResult>? speakV2SpeakV2Warning = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV2SpeakV2Error, TResult>? speakV2SpeakV2Error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakV2SpeakV2Audio && speakV2SpeakV2Audio != null)
            {
                return speakV2SpeakV2Audio(SpeakV2SpeakV2Audio!);
            }
            else if (IsSpeakV2SpeakV2Connected && speakV2SpeakV2Connected != null)
            {
                return speakV2SpeakV2Connected(SpeakV2SpeakV2Connected!);
            }
            else if (IsSpeakV2SpeakV2SpeechStarted && speakV2SpeakV2SpeechStarted != null)
            {
                return speakV2SpeakV2SpeechStarted(SpeakV2SpeakV2SpeechStarted!);
            }
            else if (IsSpeakV2SpeakV2SpeechMetadata && speakV2SpeakV2SpeechMetadata != null)
            {
                return speakV2SpeakV2SpeechMetadata(SpeakV2SpeakV2SpeechMetadata!);
            }
            else if (IsSpeakV2SpeakV2Flushed && speakV2SpeakV2Flushed != null)
            {
                return speakV2SpeakV2Flushed(SpeakV2SpeakV2Flushed!);
            }
            else if (IsSpeakV2SpeakV2SessionMetadata && speakV2SpeakV2SessionMetadata != null)
            {
                return speakV2SpeakV2SessionMetadata(SpeakV2SpeakV2SessionMetadata!);
            }
            else if (IsSpeakV2SpeakV2Warning && speakV2SpeakV2Warning != null)
            {
                return speakV2SpeakV2Warning(SpeakV2SpeakV2Warning!);
            }
            else if (IsSpeakV2SpeakV2Error && speakV2SpeakV2Error != null)
            {
                return speakV2SpeakV2Error(SpeakV2SpeakV2Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]>? speakV2SpeakV2Audio = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Connected>? speakV2SpeakV2Connected = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted>? speakV2SpeakV2SpeechStarted = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata>? speakV2SpeakV2SpeechMetadata = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed>? speakV2SpeakV2Flushed = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata>? speakV2SpeakV2SessionMetadata = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Warning>? speakV2SpeakV2Warning = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Error>? speakV2SpeakV2Error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakV2SpeakV2Audio)
            {
                speakV2SpeakV2Audio?.Invoke(SpeakV2SpeakV2Audio!);
            }
            else if (IsSpeakV2SpeakV2Connected)
            {
                speakV2SpeakV2Connected?.Invoke(SpeakV2SpeakV2Connected!);
            }
            else if (IsSpeakV2SpeakV2SpeechStarted)
            {
                speakV2SpeakV2SpeechStarted?.Invoke(SpeakV2SpeakV2SpeechStarted!);
            }
            else if (IsSpeakV2SpeakV2SpeechMetadata)
            {
                speakV2SpeakV2SpeechMetadata?.Invoke(SpeakV2SpeakV2SpeechMetadata!);
            }
            else if (IsSpeakV2SpeakV2Flushed)
            {
                speakV2SpeakV2Flushed?.Invoke(SpeakV2SpeakV2Flushed!);
            }
            else if (IsSpeakV2SpeakV2SessionMetadata)
            {
                speakV2SpeakV2SessionMetadata?.Invoke(SpeakV2SpeakV2SessionMetadata!);
            }
            else if (IsSpeakV2SpeakV2Warning)
            {
                speakV2SpeakV2Warning?.Invoke(SpeakV2SpeakV2Warning!);
            }
            else if (IsSpeakV2SpeakV2Error)
            {
                speakV2SpeakV2Error?.Invoke(SpeakV2SpeakV2Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<byte[]>? speakV2SpeakV2Audio = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Connected>? speakV2SpeakV2Connected = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted>? speakV2SpeakV2SpeechStarted = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata>? speakV2SpeakV2SpeechMetadata = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed>? speakV2SpeakV2Flushed = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata>? speakV2SpeakV2SessionMetadata = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Warning>? speakV2SpeakV2Warning = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV2SpeakV2Error>? speakV2SpeakV2Error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakV2SpeakV2Audio)
            {
                speakV2SpeakV2Audio?.Invoke(SpeakV2SpeakV2Audio!);
            }
            else if (IsSpeakV2SpeakV2Connected)
            {
                speakV2SpeakV2Connected?.Invoke(SpeakV2SpeakV2Connected!);
            }
            else if (IsSpeakV2SpeakV2SpeechStarted)
            {
                speakV2SpeakV2SpeechStarted?.Invoke(SpeakV2SpeakV2SpeechStarted!);
            }
            else if (IsSpeakV2SpeakV2SpeechMetadata)
            {
                speakV2SpeakV2SpeechMetadata?.Invoke(SpeakV2SpeakV2SpeechMetadata!);
            }
            else if (IsSpeakV2SpeakV2Flushed)
            {
                speakV2SpeakV2Flushed?.Invoke(SpeakV2SpeakV2Flushed!);
            }
            else if (IsSpeakV2SpeakV2SessionMetadata)
            {
                speakV2SpeakV2SessionMetadata?.Invoke(SpeakV2SpeakV2SessionMetadata!);
            }
            else if (IsSpeakV2SpeakV2Warning)
            {
                speakV2SpeakV2Warning?.Invoke(SpeakV2SpeakV2Warning!);
            }
            else if (IsSpeakV2SpeakV2Error)
            {
                speakV2SpeakV2Error?.Invoke(SpeakV2SpeakV2Error!);
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
                SpeakV2SpeakV2Connected,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Connected),
                SpeakV2SpeakV2SpeechStarted,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted),
                SpeakV2SpeakV2SpeechMetadata,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata),
                SpeakV2SpeakV2Flushed,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Flushed),
                SpeakV2SpeakV2SessionMetadata,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata),
                SpeakV2SpeakV2Warning,
                typeof(global::Deepgram.Realtime.SpeakV2SpeakV2Warning),
                SpeakV2SpeakV2Error,
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Connected?>.Default.Equals(SpeakV2SpeakV2Connected, other.SpeakV2SpeakV2Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechStarted?>.Default.Equals(SpeakV2SpeakV2SpeechStarted, other.SpeakV2SpeakV2SpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SpeechMetadata?>.Default.Equals(SpeakV2SpeakV2SpeechMetadata, other.SpeakV2SpeakV2SpeechMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Flushed?>.Default.Equals(SpeakV2SpeakV2Flushed, other.SpeakV2SpeakV2Flushed) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2SessionMetadata?>.Default.Equals(SpeakV2SpeakV2SessionMetadata, other.SpeakV2SpeakV2SessionMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Warning?>.Default.Equals(SpeakV2SpeakV2Warning, other.SpeakV2SpeakV2Warning) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV2SpeakV2Error?>.Default.Equals(SpeakV2SpeakV2Error, other.SpeakV2SpeakV2Error) 
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
