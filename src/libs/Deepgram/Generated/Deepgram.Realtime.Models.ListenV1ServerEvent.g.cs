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
        public bool TryPickListenV1ListenV1Results(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV1ListenV1Results? value)
        {
            value = ListenV1ListenV1Results;
            return IsListenV1ListenV1Results;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV1ListenV1Results PickListenV1ListenV1Results() => ListenV1ListenV1Results is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1ListenV1Results' but the value was {ToString()}.");

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
        public bool TryPickListenV1ListenV1Metadata(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV1ListenV1Metadata? value)
        {
            value = ListenV1ListenV1Metadata;
            return IsListenV1ListenV1Metadata;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV1ListenV1Metadata PickListenV1ListenV1Metadata() => ListenV1ListenV1Metadata is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1ListenV1Metadata' but the value was {ToString()}.");

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
        public bool TryPickListenV1ListenV1UtteranceEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? value)
        {
            value = ListenV1ListenV1UtteranceEnd;
            return IsListenV1ListenV1UtteranceEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd PickListenV1ListenV1UtteranceEnd() => ListenV1ListenV1UtteranceEnd is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1ListenV1UtteranceEnd' but the value was {ToString()}.");

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
        public bool TryPickListenV1ListenV1SpeechStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? value)
        {
            value = ListenV1ListenV1SpeechStarted;
            return IsListenV1ListenV1SpeechStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted PickListenV1ListenV1SpeechStarted() => ListenV1ListenV1SpeechStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1ListenV1SpeechStarted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1ListenV1Error? ListenV1ListenV1Error { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1ListenV1Error? ListenV1ListenV1Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1ListenV1Error))]
#endif
        public bool IsListenV1ListenV1Error => ListenV1ListenV1Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListenV1ListenV1Error(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV1ListenV1Error? value)
        {
            value = ListenV1ListenV1Error;
            return IsListenV1ListenV1Error;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV1ListenV1Error PickListenV1ListenV1Error() => ListenV1ListenV1Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1ListenV1Error' but the value was {ToString()}.");
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
        public static ListenV1ServerEvent FromListenV1ListenV1Results(global::Deepgram.Realtime.ListenV1ListenV1Results? value) => new ListenV1ServerEvent(value);

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
        public static ListenV1ServerEvent FromListenV1ListenV1Metadata(global::Deepgram.Realtime.ListenV1ListenV1Metadata? value) => new ListenV1ServerEvent(value);

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
        public static ListenV1ServerEvent FromListenV1ListenV1UtteranceEnd(global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? value) => new ListenV1ServerEvent(value);

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
        public static ListenV1ServerEvent FromListenV1ListenV1SpeechStarted(global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? value) => new ListenV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1Error value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1ListenV1Error?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1ListenV1Error?(ListenV1ServerEvent @this) => @this.ListenV1ListenV1Error;

        /// <summary>
        ///
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ListenV1Error? value)
        {
            ListenV1ListenV1Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListenV1ServerEvent FromListenV1ListenV1Error(global::Deepgram.Realtime.ListenV1ListenV1Error? value) => new ListenV1ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ListenV1ServerEvent(
            global::Deepgram.Realtime.ListenV1ListenV1Results? listenV1ListenV1Results,
            global::Deepgram.Realtime.ListenV1ListenV1Metadata? listenV1ListenV1Metadata,
            global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd? listenV1ListenV1UtteranceEnd,
            global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted? listenV1ListenV1SpeechStarted,
            global::Deepgram.Realtime.ListenV1ListenV1Error? listenV1ListenV1Error
            )
        {
            ListenV1ListenV1Results = listenV1ListenV1Results;
            ListenV1ListenV1Metadata = listenV1ListenV1Metadata;
            ListenV1ListenV1UtteranceEnd = listenV1ListenV1UtteranceEnd;
            ListenV1ListenV1SpeechStarted = listenV1ListenV1SpeechStarted;
            ListenV1ListenV1Error = listenV1ListenV1Error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListenV1ListenV1Error as object ??
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
            ListenV1ListenV1SpeechStarted?.ToString() ??
            ListenV1ListenV1Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted && !IsListenV1ListenV1Error || !IsListenV1ListenV1Results && IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted && !IsListenV1ListenV1Error || !IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted && !IsListenV1ListenV1Error || !IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && IsListenV1ListenV1SpeechStarted && !IsListenV1ListenV1Error || !IsListenV1ListenV1Results && !IsListenV1ListenV1Metadata && !IsListenV1ListenV1UtteranceEnd && !IsListenV1ListenV1SpeechStarted && IsListenV1ListenV1Error;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1Results, TResult>? listenV1ListenV1Results = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1Metadata, TResult>? listenV1ListenV1Metadata = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd, TResult>? listenV1ListenV1UtteranceEnd = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted, TResult>? listenV1ListenV1SpeechStarted = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1ListenV1Error, TResult>? listenV1ListenV1Error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV1ListenV1Results is { } __value0 && listenV1ListenV1Results != null)
            {
                return listenV1ListenV1Results(__value0);
            }
            else if (ListenV1ListenV1Metadata is { } __value1 && listenV1ListenV1Metadata != null)
            {
                return listenV1ListenV1Metadata(__value1);
            }
            else if (ListenV1ListenV1UtteranceEnd is { } __value2 && listenV1ListenV1UtteranceEnd != null)
            {
                return listenV1ListenV1UtteranceEnd(__value2);
            }
            else if (ListenV1ListenV1SpeechStarted is { } __value3 && listenV1ListenV1SpeechStarted != null)
            {
                return listenV1ListenV1SpeechStarted(__value3);
            }
            else if (ListenV1ListenV1Error is { } __value4 && listenV1ListenV1Error != null)
            {
                return listenV1ListenV1Error(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Results>? listenV1ListenV1Results = null,

            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Metadata>? listenV1ListenV1Metadata = null,

            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd>? listenV1ListenV1UtteranceEnd = null,

            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted>? listenV1ListenV1SpeechStarted = null,

            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Error>? listenV1ListenV1Error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV1ListenV1Results is { } __value0)
            {
                listenV1ListenV1Results?.Invoke(__value0);
            }
            else if (ListenV1ListenV1Metadata is { } __value1)
            {
                listenV1ListenV1Metadata?.Invoke(__value1);
            }
            else if (ListenV1ListenV1UtteranceEnd is { } __value2)
            {
                listenV1ListenV1UtteranceEnd?.Invoke(__value2);
            }
            else if (ListenV1ListenV1SpeechStarted is { } __value3)
            {
                listenV1ListenV1SpeechStarted?.Invoke(__value3);
            }
            else if (ListenV1ListenV1Error is { } __value4)
            {
                listenV1ListenV1Error?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Results>? listenV1ListenV1Results = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Metadata>? listenV1ListenV1Metadata = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1UtteranceEnd>? listenV1ListenV1UtteranceEnd = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted>? listenV1ListenV1SpeechStarted = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1ListenV1Error>? listenV1ListenV1Error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV1ListenV1Results is { } __value0)
            {
                listenV1ListenV1Results?.Invoke(__value0);
            }
            else if (ListenV1ListenV1Metadata is { } __value1)
            {
                listenV1ListenV1Metadata?.Invoke(__value1);
            }
            else if (ListenV1ListenV1UtteranceEnd is { } __value2)
            {
                listenV1ListenV1UtteranceEnd?.Invoke(__value2);
            }
            else if (ListenV1ListenV1SpeechStarted is { } __value3)
            {
                listenV1ListenV1SpeechStarted?.Invoke(__value3);
            }
            else if (ListenV1ListenV1Error is { } __value4)
            {
                listenV1ListenV1Error?.Invoke(__value4);
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
                ListenV1ListenV1Error,
                typeof(global::Deepgram.Realtime.ListenV1ListenV1Error),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ListenV1SpeechStarted?>.Default.Equals(ListenV1ListenV1SpeechStarted, other.ListenV1ListenV1SpeechStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ListenV1Error?>.Default.Equals(ListenV1ListenV1Error, other.ListenV1ListenV1Error)
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
