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
        public global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1ResultsEvent? Results { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1ResultsEvent? Results { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Results))]
#endif
        public bool IsResults => Results != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1MetadataEvent? Metadata { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1MetadataEvent? Metadata { get; }
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
        public global::Deepgram.Realtime.ListenV1UtteranceEndEvent? UtteranceEnd { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1UtteranceEndEvent? UtteranceEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UtteranceEnd))]
#endif
        public bool IsUtteranceEnd => UtteranceEnd != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV1SpeechStartedEvent? SpeechStarted { get; init; }
#else
        public global::Deepgram.Realtime.ListenV1SpeechStartedEvent? SpeechStarted { get; }
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
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ResultsEvent value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1ResultsEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1ResultsEvent?(ListenV1ServerEvent @this) => @this.Results;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1ResultsEvent? value)
        {
            Results = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1MetadataEvent value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1MetadataEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1MetadataEvent?(ListenV1ServerEvent @this) => @this.Metadata;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1MetadataEvent? value)
        {
            Metadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1UtteranceEndEvent value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1UtteranceEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1UtteranceEndEvent?(ListenV1ServerEvent @this) => @this.UtteranceEnd;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1UtteranceEndEvent? value)
        {
            UtteranceEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1SpeechStartedEvent value) => new ListenV1ServerEvent((global::Deepgram.Realtime.ListenV1SpeechStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV1SpeechStartedEvent?(ListenV1ServerEvent @this) => @this.SpeechStarted;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(global::Deepgram.Realtime.ListenV1SpeechStartedEvent? value)
        {
            SpeechStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV1ServerEvent(
            global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType? type,
            global::Deepgram.Realtime.ListenV1ResultsEvent? results,
            global::Deepgram.Realtime.ListenV1MetadataEvent? metadata,
            global::Deepgram.Realtime.ListenV1UtteranceEndEvent? utteranceEnd,
            global::Deepgram.Realtime.ListenV1SpeechStartedEvent? speechStarted
            )
        {
            Type = type;

            Results = results;
            Metadata = metadata;
            UtteranceEnd = utteranceEnd;
            SpeechStarted = speechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeechStarted as object ??
            UtteranceEnd as object ??
            Metadata as object ??
            Results as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Results?.ToString() ??
            Metadata?.ToString() ??
            UtteranceEnd?.ToString() ??
            SpeechStarted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResults && !IsMetadata && !IsUtteranceEnd && !IsSpeechStarted || !IsResults && IsMetadata && !IsUtteranceEnd && !IsSpeechStarted || !IsResults && !IsMetadata && IsUtteranceEnd && !IsSpeechStarted || !IsResults && !IsMetadata && !IsUtteranceEnd && IsSpeechStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ListenV1ResultsEvent?, TResult>? results = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1MetadataEvent?, TResult>? metadata = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1UtteranceEndEvent?, TResult>? utteranceEnd = null,
            global::System.Func<global::Deepgram.Realtime.ListenV1SpeechStartedEvent?, TResult>? speechStarted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResults && results != null)
            {
                return results(Results!);
            }
            else if (IsMetadata && metadata != null)
            {
                return metadata(Metadata!);
            }
            else if (IsUtteranceEnd && utteranceEnd != null)
            {
                return utteranceEnd(UtteranceEnd!);
            }
            else if (IsSpeechStarted && speechStarted != null)
            {
                return speechStarted(SpeechStarted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ListenV1ResultsEvent?>? results = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1MetadataEvent?>? metadata = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1UtteranceEndEvent?>? utteranceEnd = null,
            global::System.Action<global::Deepgram.Realtime.ListenV1SpeechStartedEvent?>? speechStarted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResults)
            {
                results?.Invoke(Results!);
            }
            else if (IsMetadata)
            {
                metadata?.Invoke(Metadata!);
            }
            else if (IsUtteranceEnd)
            {
                utteranceEnd?.Invoke(UtteranceEnd!);
            }
            else if (IsSpeechStarted)
            {
                speechStarted?.Invoke(SpeechStarted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Results,
                typeof(global::Deepgram.Realtime.ListenV1ResultsEvent),
                Metadata,
                typeof(global::Deepgram.Realtime.ListenV1MetadataEvent),
                UtteranceEnd,
                typeof(global::Deepgram.Realtime.ListenV1UtteranceEndEvent),
                SpeechStarted,
                typeof(global::Deepgram.Realtime.ListenV1SpeechStartedEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1ResultsEvent?>.Default.Equals(Results, other.Results) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1MetadataEvent?>.Default.Equals(Metadata, other.Metadata) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1UtteranceEndEvent?>.Default.Equals(UtteranceEnd, other.UtteranceEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV1SpeechStartedEvent?>.Default.Equals(SpeechStarted, other.SpeechStarted) 
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
