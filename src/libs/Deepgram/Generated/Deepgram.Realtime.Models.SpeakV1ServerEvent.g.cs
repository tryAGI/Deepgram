#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SpeakV1ServerEvent : global::System.IEquatable<SpeakV1ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? SpeakV1SpeakV1Audio { get; init; }
#else
        public byte[]? SpeakV1SpeakV1Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV1SpeakV1Audio))]
#endif
        public bool IsSpeakV1SpeakV1Audio => SpeakV1SpeakV1Audio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV1SpeakV1Audio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out byte[]? value)
        {
            value = SpeakV1SpeakV1Audio;
            return IsSpeakV1SpeakV1Audio;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] PickSpeakV1SpeakV1Audio() => IsSpeakV1SpeakV1Audio
            ? SpeakV1SpeakV1Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV1SpeakV1Audio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? SpeakV1SpeakV1Metadata { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? SpeakV1SpeakV1Metadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV1SpeakV1Metadata))]
#endif
        public bool IsSpeakV1SpeakV1Metadata => SpeakV1SpeakV1Metadata != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV1SpeakV1Metadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? value)
        {
            value = SpeakV1SpeakV1Metadata;
            return IsSpeakV1SpeakV1Metadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV1SpeakV1Metadata PickSpeakV1SpeakV1Metadata() => IsSpeakV1SpeakV1Metadata
            ? SpeakV1SpeakV1Metadata!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV1SpeakV1Metadata' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? SpeakV1SpeakV1Flushed { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? SpeakV1SpeakV1Flushed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV1SpeakV1Flushed))]
#endif
        public bool IsSpeakV1SpeakV1Flushed => SpeakV1SpeakV1Flushed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV1SpeakV1Flushed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? value)
        {
            value = SpeakV1SpeakV1Flushed;
            return IsSpeakV1SpeakV1Flushed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV1SpeakV1Flushed PickSpeakV1SpeakV1Flushed() => IsSpeakV1SpeakV1Flushed
            ? SpeakV1SpeakV1Flushed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV1SpeakV1Flushed' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? SpeakV1SpeakV1Cleared { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? SpeakV1SpeakV1Cleared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV1SpeakV1Cleared))]
#endif
        public bool IsSpeakV1SpeakV1Cleared => SpeakV1SpeakV1Cleared != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV1SpeakV1Cleared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? value)
        {
            value = SpeakV1SpeakV1Cleared;
            return IsSpeakV1SpeakV1Cleared;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV1SpeakV1Cleared PickSpeakV1SpeakV1Cleared() => IsSpeakV1SpeakV1Cleared
            ? SpeakV1SpeakV1Cleared!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV1SpeakV1Cleared' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV1SpeakV1Warning? SpeakV1SpeakV1Warning { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1SpeakV1Warning? SpeakV1SpeakV1Warning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakV1SpeakV1Warning))]
#endif
        public bool IsSpeakV1SpeakV1Warning => SpeakV1SpeakV1Warning != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpeakV1SpeakV1Warning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.SpeakV1SpeakV1Warning? value)
        {
            value = SpeakV1SpeakV1Warning;
            return IsSpeakV1SpeakV1Warning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.SpeakV1SpeakV1Warning PickSpeakV1SpeakV1Warning() => IsSpeakV1SpeakV1Warning
            ? SpeakV1SpeakV1Warning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeakV1SpeakV1Warning' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(byte[] value) => new SpeakV1ServerEvent((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(SpeakV1ServerEvent @this) => @this.SpeakV1SpeakV1Audio;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(byte[]? value)
        {
            SpeakV1SpeakV1Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeakV1ServerEvent FromSpeakV1SpeakV1Audio(byte[]? value) => new SpeakV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1SpeakV1Metadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1SpeakV1Metadata?(SpeakV1ServerEvent @this) => @this.SpeakV1SpeakV1Metadata;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? value)
        {
            SpeakV1SpeakV1Metadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeakV1ServerEvent FromSpeakV1SpeakV1Metadata(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? value) => new SpeakV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1SpeakV1Flushed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1SpeakV1Flushed?(SpeakV1ServerEvent @this) => @this.SpeakV1SpeakV1Flushed;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? value)
        {
            SpeakV1SpeakV1Flushed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeakV1ServerEvent FromSpeakV1SpeakV1Flushed(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? value) => new SpeakV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1SpeakV1Cleared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1SpeakV1Cleared?(SpeakV1ServerEvent @this) => @this.SpeakV1SpeakV1Cleared;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? value)
        {
            SpeakV1SpeakV1Cleared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeakV1ServerEvent FromSpeakV1SpeakV1Cleared(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? value) => new SpeakV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Warning value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1SpeakV1Warning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1SpeakV1Warning?(SpeakV1ServerEvent @this) => @this.SpeakV1SpeakV1Warning;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1SpeakV1Warning? value)
        {
            SpeakV1SpeakV1Warning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpeakV1ServerEvent FromSpeakV1SpeakV1Warning(global::Deepgram.Realtime.SpeakV1SpeakV1Warning? value) => new SpeakV1ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(
            byte[]? speakV1SpeakV1Audio,
            global::Deepgram.Realtime.SpeakV1SpeakV1Metadata? speakV1SpeakV1Metadata,
            global::Deepgram.Realtime.SpeakV1SpeakV1Flushed? speakV1SpeakV1Flushed,
            global::Deepgram.Realtime.SpeakV1SpeakV1Cleared? speakV1SpeakV1Cleared,
            global::Deepgram.Realtime.SpeakV1SpeakV1Warning? speakV1SpeakV1Warning
            )
        {
            SpeakV1SpeakV1Audio = speakV1SpeakV1Audio;
            SpeakV1SpeakV1Metadata = speakV1SpeakV1Metadata;
            SpeakV1SpeakV1Flushed = speakV1SpeakV1Flushed;
            SpeakV1SpeakV1Cleared = speakV1SpeakV1Cleared;
            SpeakV1SpeakV1Warning = speakV1SpeakV1Warning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeakV1SpeakV1Warning as object ??
            SpeakV1SpeakV1Cleared as object ??
            SpeakV1SpeakV1Flushed as object ??
            SpeakV1SpeakV1Metadata as object ??
            SpeakV1SpeakV1Audio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpeakV1SpeakV1Audio?.ToString() ??
            SpeakV1SpeakV1Metadata?.ToString() ??
            SpeakV1SpeakV1Flushed?.ToString() ??
            SpeakV1SpeakV1Cleared?.ToString() ??
            SpeakV1SpeakV1Warning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpeakV1SpeakV1Audio && !IsSpeakV1SpeakV1Metadata && !IsSpeakV1SpeakV1Flushed && !IsSpeakV1SpeakV1Cleared && !IsSpeakV1SpeakV1Warning || !IsSpeakV1SpeakV1Audio && IsSpeakV1SpeakV1Metadata && !IsSpeakV1SpeakV1Flushed && !IsSpeakV1SpeakV1Cleared && !IsSpeakV1SpeakV1Warning || !IsSpeakV1SpeakV1Audio && !IsSpeakV1SpeakV1Metadata && IsSpeakV1SpeakV1Flushed && !IsSpeakV1SpeakV1Cleared && !IsSpeakV1SpeakV1Warning || !IsSpeakV1SpeakV1Audio && !IsSpeakV1SpeakV1Metadata && !IsSpeakV1SpeakV1Flushed && IsSpeakV1SpeakV1Cleared && !IsSpeakV1SpeakV1Warning || !IsSpeakV1SpeakV1Audio && !IsSpeakV1SpeakV1Metadata && !IsSpeakV1SpeakV1Flushed && !IsSpeakV1SpeakV1Cleared && IsSpeakV1SpeakV1Warning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[], TResult>? speakV1SpeakV1Audio = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata, TResult>? speakV1SpeakV1Metadata = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed, TResult>? speakV1SpeakV1Flushed = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared, TResult>? speakV1SpeakV1Cleared = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV1SpeakV1Warning, TResult>? speakV1SpeakV1Warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakV1SpeakV1Audio && speakV1SpeakV1Audio != null)
            {
                return speakV1SpeakV1Audio(SpeakV1SpeakV1Audio!);
            }
            else if (IsSpeakV1SpeakV1Metadata && speakV1SpeakV1Metadata != null)
            {
                return speakV1SpeakV1Metadata(SpeakV1SpeakV1Metadata!);
            }
            else if (IsSpeakV1SpeakV1Flushed && speakV1SpeakV1Flushed != null)
            {
                return speakV1SpeakV1Flushed(SpeakV1SpeakV1Flushed!);
            }
            else if (IsSpeakV1SpeakV1Cleared && speakV1SpeakV1Cleared != null)
            {
                return speakV1SpeakV1Cleared(SpeakV1SpeakV1Cleared!);
            }
            else if (IsSpeakV1SpeakV1Warning && speakV1SpeakV1Warning != null)
            {
                return speakV1SpeakV1Warning(SpeakV1SpeakV1Warning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]>? speakV1SpeakV1Audio = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata>? speakV1SpeakV1Metadata = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed>? speakV1SpeakV1Flushed = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared>? speakV1SpeakV1Cleared = null,

            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Warning>? speakV1SpeakV1Warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakV1SpeakV1Audio)
            {
                speakV1SpeakV1Audio?.Invoke(SpeakV1SpeakV1Audio!);
            }
            else if (IsSpeakV1SpeakV1Metadata)
            {
                speakV1SpeakV1Metadata?.Invoke(SpeakV1SpeakV1Metadata!);
            }
            else if (IsSpeakV1SpeakV1Flushed)
            {
                speakV1SpeakV1Flushed?.Invoke(SpeakV1SpeakV1Flushed!);
            }
            else if (IsSpeakV1SpeakV1Cleared)
            {
                speakV1SpeakV1Cleared?.Invoke(SpeakV1SpeakV1Cleared!);
            }
            else if (IsSpeakV1SpeakV1Warning)
            {
                speakV1SpeakV1Warning?.Invoke(SpeakV1SpeakV1Warning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<byte[]>? speakV1SpeakV1Audio = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata>? speakV1SpeakV1Metadata = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed>? speakV1SpeakV1Flushed = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared>? speakV1SpeakV1Cleared = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV1SpeakV1Warning>? speakV1SpeakV1Warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakV1SpeakV1Audio)
            {
                speakV1SpeakV1Audio?.Invoke(SpeakV1SpeakV1Audio!);
            }
            else if (IsSpeakV1SpeakV1Metadata)
            {
                speakV1SpeakV1Metadata?.Invoke(SpeakV1SpeakV1Metadata!);
            }
            else if (IsSpeakV1SpeakV1Flushed)
            {
                speakV1SpeakV1Flushed?.Invoke(SpeakV1SpeakV1Flushed!);
            }
            else if (IsSpeakV1SpeakV1Cleared)
            {
                speakV1SpeakV1Cleared?.Invoke(SpeakV1SpeakV1Cleared!);
            }
            else if (IsSpeakV1SpeakV1Warning)
            {
                speakV1SpeakV1Warning?.Invoke(SpeakV1SpeakV1Warning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeakV1SpeakV1Audio,
                typeof(byte[]),
                SpeakV1SpeakV1Metadata,
                typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Metadata),
                SpeakV1SpeakV1Flushed,
                typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Flushed),
                SpeakV1SpeakV1Cleared,
                typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Cleared),
                SpeakV1SpeakV1Warning,
                typeof(global::Deepgram.Realtime.SpeakV1SpeakV1Warning),
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
        public bool Equals(SpeakV1ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(SpeakV1SpeakV1Audio, other.SpeakV1SpeakV1Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1SpeakV1Metadata?>.Default.Equals(SpeakV1SpeakV1Metadata, other.SpeakV1SpeakV1Metadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1SpeakV1Flushed?>.Default.Equals(SpeakV1SpeakV1Flushed, other.SpeakV1SpeakV1Flushed) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1SpeakV1Cleared?>.Default.Equals(SpeakV1SpeakV1Cleared, other.SpeakV1SpeakV1Cleared) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1SpeakV1Warning?>.Default.Equals(SpeakV1SpeakV1Warning, other.SpeakV1SpeakV1Warning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpeakV1ServerEvent obj1, SpeakV1ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeakV1ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpeakV1ServerEvent obj1, SpeakV1ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeakV1ServerEvent o && Equals(o);
        }
    }
}
