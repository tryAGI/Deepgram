#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// A history message is either a conversational message or a function call
    /// </summary>
    public readonly partial struct AgentV1AgentV1History : global::System.IEquatable<AgentV1AgentV1History>
    {
        /// <summary>
        /// Conversation text as part of the conversation history
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1History0? AgentV1AgentV1History0 { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1History0? AgentV1AgentV1History0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1History0))]
#endif
        public bool IsAgentV1AgentV1History0 => AgentV1AgentV1History0 != null;

        /// <summary>
        /// Client-side or server-side function call request and response as part of the conversation history
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.AgentV1AgentV1History1? AgentV1AgentV1History1 { get; init; }
#else
        public global::Deepgram.Realtime.AgentV1AgentV1History1? AgentV1AgentV1History1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentV1AgentV1History1))]
#endif
        public bool IsAgentV1AgentV1History1 => AgentV1AgentV1History1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1AgentV1History(global::Deepgram.Realtime.AgentV1AgentV1History0 value) => new AgentV1AgentV1History((global::Deepgram.Realtime.AgentV1AgentV1History0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1History0?(AgentV1AgentV1History @this) => @this.AgentV1AgentV1History0;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1AgentV1History(global::Deepgram.Realtime.AgentV1AgentV1History0? value)
        {
            AgentV1AgentV1History0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1AgentV1History(global::Deepgram.Realtime.AgentV1AgentV1History1 value) => new AgentV1AgentV1History((global::Deepgram.Realtime.AgentV1AgentV1History1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.AgentV1AgentV1History1?(AgentV1AgentV1History @this) => @this.AgentV1AgentV1History1;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1AgentV1History(global::Deepgram.Realtime.AgentV1AgentV1History1? value)
        {
            AgentV1AgentV1History1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentV1AgentV1History(
            global::Deepgram.Realtime.AgentV1AgentV1History0? agentV1AgentV1History0,
            global::Deepgram.Realtime.AgentV1AgentV1History1? agentV1AgentV1History1
            )
        {
            AgentV1AgentV1History0 = agentV1AgentV1History0;
            AgentV1AgentV1History1 = agentV1AgentV1History1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentV1AgentV1History1 as object ??
            AgentV1AgentV1History0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentV1AgentV1History0?.ToString() ??
            AgentV1AgentV1History1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentV1AgentV1History0 && !IsAgentV1AgentV1History1 || !IsAgentV1AgentV1History0 && IsAgentV1AgentV1History1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1History0?, TResult>? agentV1AgentV1History0 = null,
            global::System.Func<global::Deepgram.Realtime.AgentV1AgentV1History1?, TResult>? agentV1AgentV1History1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentV1AgentV1History0 && agentV1AgentV1History0 != null)
            {
                return agentV1AgentV1History0(AgentV1AgentV1History0!);
            }
            else if (IsAgentV1AgentV1History1 && agentV1AgentV1History1 != null)
            {
                return agentV1AgentV1History1(AgentV1AgentV1History1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1History0?>? agentV1AgentV1History0 = null,
            global::System.Action<global::Deepgram.Realtime.AgentV1AgentV1History1?>? agentV1AgentV1History1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentV1AgentV1History0)
            {
                agentV1AgentV1History0?.Invoke(AgentV1AgentV1History0!);
            }
            else if (IsAgentV1AgentV1History1)
            {
                agentV1AgentV1History1?.Invoke(AgentV1AgentV1History1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentV1AgentV1History0,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1History0),
                AgentV1AgentV1History1,
                typeof(global::Deepgram.Realtime.AgentV1AgentV1History1),
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
        public bool Equals(AgentV1AgentV1History other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1History0?>.Default.Equals(AgentV1AgentV1History0, other.AgentV1AgentV1History0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.AgentV1AgentV1History1?>.Default.Equals(AgentV1AgentV1History1, other.AgentV1AgentV1History1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentV1AgentV1History obj1, AgentV1AgentV1History obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentV1AgentV1History>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentV1AgentV1History obj1, AgentV1AgentV1History obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentV1AgentV1History o && Equals(o);
        }
    }
}
