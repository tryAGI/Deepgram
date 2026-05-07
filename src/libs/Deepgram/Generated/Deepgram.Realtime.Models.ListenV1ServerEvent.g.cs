#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListenV1ServerEvent : global::System.IEquatable<ListenV1ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1ListenV1Results? ListenV1ListenV1Results { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1ListenV1Results? ListenV1ListenV1Results { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1ListenV1Results))]
#endif
        public bool IsListenV1ListenV1Results => ListenV1ListenV1Results != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1ListenV1Metadata? ListenV1ListenV1Metadata { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1ListenV1Metadata? ListenV1ListenV1Metadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1ListenV1Metadata))]
#endif
        public bool IsListenV1ListenV1Metadata => ListenV1ListenV1Metadata != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? ListenV1ListenV1UtteranceEnd { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? ListenV1ListenV1UtteranceEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1ListenV1UtteranceEnd))]
#endif
        public bool IsListenV1ListenV1UtteranceEnd => ListenV1ListenV1UtteranceEnd != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? ListenV1ListenV1SpeechStarted { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? ListenV1ListenV1SpeechStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1ListenV1SpeechStarted))]
#endif
        public bool IsListenV1ListenV1SpeechStarted => ListenV1ListenV1SpeechStarted != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1Results value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1ListenV1Results?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1ListenV1Results?(ListenV1ServerEvent @this) => @this.ListenV1ListenV1Results;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1Results? value)
        {
            ListenV1ListenV1Results = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1Metadata value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1ListenV1Metadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1ListenV1Metadata?(ListenV1ServerEvent @this) => @this.ListenV1ListenV1Metadata;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1Metadata? value)
        {
            ListenV1ListenV1Metadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd?(ListenV1ServerEvent @this) => @this.ListenV1ListenV1UtteranceEnd;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? value)
        {
            ListenV1ListenV1UtteranceEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?(ListenV1ServerEvent @this) => @this.ListenV1ListenV1SpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? value)
        {
            ListenV1ListenV1SpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(
            global::Deepgram.Realtime.ListenV1ListenV1Results? listenV1ListenV1Results,
            global::Deepgram.Realtime.ListenV1ListenV1Metadata? listenV1ListenV1Metadata,
            global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? listenV1ListenV1UtteranceEnd,
            global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? listenV1ListenV1SpeechStarted
            )
        {
            ListenV1ListenV1Results = listenV1ListenV1Results;
            ListenV1ListenV1Metadata = listenV1ListenV1Metadata;
            ListenV1ListenV1UtteranceEnd = listenV1ListenV1UtteranceEnd;
            ListenV1ListenV1SpeechStarted = listenV1ListenV1SpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListenV1ListenV1SpeechStarted as object ??
            ListenV1ListenV1UtteranceEnd as object ??
            ListenV1ListenV1Metadata as object ??
            ListenV1ListenV1Results as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListenV1ListenV1Results?.ToString() ??
            ListenV1ListenV1Metadata?.ToString() ??
            ListenV1ListenV1UtteranceEnd?.ToString() ??
            ListenV1ListenV1SpeechStarted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted || !IsListenV1ListenV1Results && IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted || !IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted || !IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && IsListenV1ListenV1SpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1Results?, TResult>? listenV1ListenV1Results = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1Metadata?, TResult>? listenV1ListenV1Metadata = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd?, TResult>? listenV1ListenV1UtteranceEnd = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?, TResult>? listenV1ListenV1SpeechStarted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV1ListenV1Results && listenV1ListenV1Results != null)
            {
                return listenV1ListenV1Results(ListenV1ListenV1Results!);
            }
            else if (IsListenV1ListenV1Metadata && listenV1ListenV1Metadata != null)
            {
                return listenV1ListenV1Metadata(ListenV1ListenV1Metadata!);
            }
            else if (IsListenV1ListenV1UtteranceEnd && listenV1ListenV1UtteranceEnd != null)
            {
                return listenV1ListenV1UtteranceEnd(ListenV1ListenV1UtteranceEnd!);
            }
            else if (IsListenV1ListenV1SpeechStarted && listenV1ListenV1SpeechStarted != null)
            {
                return listenV1ListenV1SpeechStarted(ListenV1ListenV1SpeechStarted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Results?>? listenV1ListenV1Results = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Metadata?>? listenV1ListenV1Metadata = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd?>? listenV1ListenV1UtteranceEnd = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?>? listenV1ListenV1SpeechStarted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV1ListenV1Results)
            {
                listenV1ListenV1Results?.Invoke(ListenV1ListenV1Results!);
            }
            else if (IsListenV1ListenV1Metadata)
            {
                listenV1ListenV1Metadata?.Invoke(ListenV1ListenV1Metadata!);
            }
            else if (IsListenV1ListenV1UtteranceEnd)
            {
                listenV1ListenV1UtteranceEnd?.Invoke(ListenV1ListenV1UtteranceEnd!);
            }
            else if (IsListenV1ListenV1SpeechStarted)
            {
                listenV1ListenV1SpeechStarted?.Invoke(ListenV1ListenV1SpeechStarted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenV1ListenV1Results,
                typeof(global::Deepgram.Realtime.ListenV1ListenV1Results),
                ListenV1ListenV1Metadata,
                typeof(global::Deepgram.Realtime.ListenV1ListenV1Metadata),
                ListenV1ListenV1UtteranceEnd,
                typeof(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd),
                ListenV1ListenV1SpeechStarted,
                typeof(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted),
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
        public bool Equals(ListenV1ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ListenV1Results?>.Default.Equals(ListenV1ListenV1Results, other.ListenV1ListenV1Results) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ListenV1Metadata?>.Default.Equals(ListenV1ListenV1Metadata, other.ListenV1ListenV1Metadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd?>.Default.Equals(ListenV1ListenV1UtteranceEnd, other.ListenV1ListenV1UtteranceEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?>.Default.Equals(ListenV1ListenV1SpeechStarted, other.ListenV1ListenV1SpeechStarted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListenV1ServerEvent obj1, ListenV1ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV1ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListenV1ServerEvent obj1, ListenV1ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV1ServerEvent o && Equals(o);
        }
    }
}
