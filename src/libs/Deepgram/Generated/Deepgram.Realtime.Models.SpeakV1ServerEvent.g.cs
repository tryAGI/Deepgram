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
        public global::Deepgram.Realtime.SpeakV1MetadataEvent? Metadata { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1MetadataEvent? Metadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Metadata))]
#endif
        public bool IsMetadata => Metadata != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV1ControlEvent? Control { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1ControlEvent? Control { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Control))]
#endif
        public bool IsControl => Control != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakV1WarningEvent? Warning { get; init; }
#else
        public global::Deepgram.Realtime.SpeakV1WarningEvent? Warning { get; }
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
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1MetadataEvent value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1MetadataEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1MetadataEvent?(SpeakV1ServerEvent @this) => @this.Metadata;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1MetadataEvent? value)
        {
            Metadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1ControlEvent value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1ControlEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1ControlEvent?(SpeakV1ServerEvent @this) => @this.Control;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1ControlEvent? value)
        {
            Control = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1WarningEvent value) => new SpeakV1ServerEvent((global::Deepgram.Realtime.SpeakV1WarningEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakV1WarningEvent?(SpeakV1ServerEvent @this) => @this.Warning;

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(global::Deepgram.Realtime.SpeakV1WarningEvent? value)
        {
            Warning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SpeakV1ServerEvent(
            global::Deepgram.Realtime.SpeakV1MetadataEvent? metadata,
            global::Deepgram.Realtime.SpeakV1ControlEvent? control,
            global::Deepgram.Realtime.SpeakV1WarningEvent? warning
            )
        {
            Metadata = metadata;
            Control = control;
            Warning = warning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Warning as object ??
            Control as object ??
            Metadata as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Metadata?.ToString() ??
            Control?.ToString() ??
            Warning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMetadata && !IsControl && !IsWarning || !IsMetadata && IsControl && !IsWarning || !IsMetadata && !IsControl && IsWarning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.SpeakV1MetadataEvent?, TResult>? metadata = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV1ControlEvent?, TResult>? control = null,
            global::System.Func<global::Deepgram.Realtime.SpeakV1WarningEvent?, TResult>? warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadata && metadata != null)
            {
                return metadata(Metadata!);
            }
            else if (IsControl && control != null)
            {
                return control(Control!);
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
            global::System.Action<global::Deepgram.Realtime.SpeakV1MetadataEvent?>? metadata = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV1ControlEvent?>? control = null,
            global::System.Action<global::Deepgram.Realtime.SpeakV1WarningEvent?>? warning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadata)
            {
                metadata?.Invoke(Metadata!);
            }
            else if (IsControl)
            {
                control?.Invoke(Control!);
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
                Metadata,
                typeof(global::Deepgram.Realtime.SpeakV1MetadataEvent),
                Control,
                typeof(global::Deepgram.Realtime.SpeakV1ControlEvent),
                Warning,
                typeof(global::Deepgram.Realtime.SpeakV1WarningEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1MetadataEvent?>.Default.Equals(Metadata, other.Metadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1ControlEvent?>.Default.Equals(Control, other.Control) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakV1WarningEvent?>.Default.Equals(Warning, other.Warning) 
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
