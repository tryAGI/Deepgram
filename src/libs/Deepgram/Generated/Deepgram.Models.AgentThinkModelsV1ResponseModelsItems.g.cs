#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentThinkModelsV1ResponseModelsItems : global::System.IEquatable<AgentThinkModelsV1ResponseModelsItems>
    {
        /// <summary>
        /// OpenAI models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems0? AgentThinkModelsV1ResponseModelsItems0 { get; init; }
#else
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems0? AgentThinkModelsV1ResponseModelsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinkModelsV1ResponseModelsItems0))]
#endif
        public bool IsAgentThinkModelsV1ResponseModelsItems0 => AgentThinkModelsV1ResponseModelsItems0 != null;

        /// <summary>
        /// Anthropic models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems1? AgentThinkModelsV1ResponseModelsItems1 { get; init; }
#else
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems1? AgentThinkModelsV1ResponseModelsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinkModelsV1ResponseModelsItems1))]
#endif
        public bool IsAgentThinkModelsV1ResponseModelsItems1 => AgentThinkModelsV1ResponseModelsItems1 != null;

        /// <summary>
        /// Google models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems2? AgentThinkModelsV1ResponseModelsItems2 { get; init; }
#else
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems2? AgentThinkModelsV1ResponseModelsItems2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinkModelsV1ResponseModelsItems2))]
#endif
        public bool IsAgentThinkModelsV1ResponseModelsItems2 => AgentThinkModelsV1ResponseModelsItems2 != null;

        /// <summary>
        /// Groq models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems3? AgentThinkModelsV1ResponseModelsItems3 { get; init; }
#else
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems3? AgentThinkModelsV1ResponseModelsItems3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinkModelsV1ResponseModelsItems3))]
#endif
        public bool IsAgentThinkModelsV1ResponseModelsItems3 => AgentThinkModelsV1ResponseModelsItems3 != null;

        /// <summary>
        /// AWS Bedrock models (custom models accepted)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems4? AgentThinkModelsV1ResponseModelsItems4 { get; init; }
#else
        public global::Deepgram.AgentThinkModelsV1ResponseModelsItems4? AgentThinkModelsV1ResponseModelsItems4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinkModelsV1ResponseModelsItems4))]
#endif
        public bool IsAgentThinkModelsV1ResponseModelsItems4 => AgentThinkModelsV1ResponseModelsItems4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0 value) => new AgentThinkModelsV1ResponseModelsItems((global::Deepgram.AgentThinkModelsV1ResponseModelsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.AgentThinkModelsV1ResponseModelsItems0?(AgentThinkModelsV1ResponseModelsItems @this) => @this.AgentThinkModelsV1ResponseModelsItems0;

        /// <summary>
        /// 
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0? value)
        {
            AgentThinkModelsV1ResponseModelsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1 value) => new AgentThinkModelsV1ResponseModelsItems((global::Deepgram.AgentThinkModelsV1ResponseModelsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.AgentThinkModelsV1ResponseModelsItems1?(AgentThinkModelsV1ResponseModelsItems @this) => @this.AgentThinkModelsV1ResponseModelsItems1;

        /// <summary>
        /// 
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1? value)
        {
            AgentThinkModelsV1ResponseModelsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2 value) => new AgentThinkModelsV1ResponseModelsItems((global::Deepgram.AgentThinkModelsV1ResponseModelsItems2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.AgentThinkModelsV1ResponseModelsItems2?(AgentThinkModelsV1ResponseModelsItems @this) => @this.AgentThinkModelsV1ResponseModelsItems2;

        /// <summary>
        /// 
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2? value)
        {
            AgentThinkModelsV1ResponseModelsItems2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3 value) => new AgentThinkModelsV1ResponseModelsItems((global::Deepgram.AgentThinkModelsV1ResponseModelsItems3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.AgentThinkModelsV1ResponseModelsItems3?(AgentThinkModelsV1ResponseModelsItems @this) => @this.AgentThinkModelsV1ResponseModelsItems3;

        /// <summary>
        /// 
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3? value)
        {
            AgentThinkModelsV1ResponseModelsItems3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4 value) => new AgentThinkModelsV1ResponseModelsItems((global::Deepgram.AgentThinkModelsV1ResponseModelsItems4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.AgentThinkModelsV1ResponseModelsItems4?(AgentThinkModelsV1ResponseModelsItems @this) => @this.AgentThinkModelsV1ResponseModelsItems4;

        /// <summary>
        /// 
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4? value)
        {
            AgentThinkModelsV1ResponseModelsItems4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentThinkModelsV1ResponseModelsItems(
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems0? agentThinkModelsV1ResponseModelsItems0,
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems1? agentThinkModelsV1ResponseModelsItems1,
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems2? agentThinkModelsV1ResponseModelsItems2,
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems3? agentThinkModelsV1ResponseModelsItems3,
            global::Deepgram.AgentThinkModelsV1ResponseModelsItems4? agentThinkModelsV1ResponseModelsItems4
            )
        {
            AgentThinkModelsV1ResponseModelsItems0 = agentThinkModelsV1ResponseModelsItems0;
            AgentThinkModelsV1ResponseModelsItems1 = agentThinkModelsV1ResponseModelsItems1;
            AgentThinkModelsV1ResponseModelsItems2 = agentThinkModelsV1ResponseModelsItems2;
            AgentThinkModelsV1ResponseModelsItems3 = agentThinkModelsV1ResponseModelsItems3;
            AgentThinkModelsV1ResponseModelsItems4 = agentThinkModelsV1ResponseModelsItems4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentThinkModelsV1ResponseModelsItems4 as object ??
            AgentThinkModelsV1ResponseModelsItems3 as object ??
            AgentThinkModelsV1ResponseModelsItems2 as object ??
            AgentThinkModelsV1ResponseModelsItems1 as object ??
            AgentThinkModelsV1ResponseModelsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentThinkModelsV1ResponseModelsItems0?.ToString() ??
            AgentThinkModelsV1ResponseModelsItems1?.ToString() ??
            AgentThinkModelsV1ResponseModelsItems2?.ToString() ??
            AgentThinkModelsV1ResponseModelsItems3?.ToString() ??
            AgentThinkModelsV1ResponseModelsItems4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentThinkModelsV1ResponseModelsItems0 && !IsAgentThinkModelsV1ResponseModelsItems1 && !IsAgentThinkModelsV1ResponseModelsItems2 && !IsAgentThinkModelsV1ResponseModelsItems3 && !IsAgentThinkModelsV1ResponseModelsItems4 || !IsAgentThinkModelsV1ResponseModelsItems0 && IsAgentThinkModelsV1ResponseModelsItems1 && !IsAgentThinkModelsV1ResponseModelsItems2 && !IsAgentThinkModelsV1ResponseModelsItems3 && !IsAgentThinkModelsV1ResponseModelsItems4 || !IsAgentThinkModelsV1ResponseModelsItems0 && !IsAgentThinkModelsV1ResponseModelsItems1 && IsAgentThinkModelsV1ResponseModelsItems2 && !IsAgentThinkModelsV1ResponseModelsItems3 && !IsAgentThinkModelsV1ResponseModelsItems4 || !IsAgentThinkModelsV1ResponseModelsItems0 && !IsAgentThinkModelsV1ResponseModelsItems1 && !IsAgentThinkModelsV1ResponseModelsItems2 && IsAgentThinkModelsV1ResponseModelsItems3 && !IsAgentThinkModelsV1ResponseModelsItems4 || !IsAgentThinkModelsV1ResponseModelsItems0 && !IsAgentThinkModelsV1ResponseModelsItems1 && !IsAgentThinkModelsV1ResponseModelsItems2 && !IsAgentThinkModelsV1ResponseModelsItems3 && IsAgentThinkModelsV1ResponseModelsItems4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.AgentThinkModelsV1ResponseModelsItems0?, TResult>? agentThinkModelsV1ResponseModelsItems0 = null,
            global::System.Func<global::Deepgram.AgentThinkModelsV1ResponseModelsItems1?, TResult>? agentThinkModelsV1ResponseModelsItems1 = null,
            global::System.Func<global::Deepgram.AgentThinkModelsV1ResponseModelsItems2?, TResult>? agentThinkModelsV1ResponseModelsItems2 = null,
            global::System.Func<global::Deepgram.AgentThinkModelsV1ResponseModelsItems3?, TResult>? agentThinkModelsV1ResponseModelsItems3 = null,
            global::System.Func<global::Deepgram.AgentThinkModelsV1ResponseModelsItems4?, TResult>? agentThinkModelsV1ResponseModelsItems4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentThinkModelsV1ResponseModelsItems0 && agentThinkModelsV1ResponseModelsItems0 != null)
            {
                return agentThinkModelsV1ResponseModelsItems0(AgentThinkModelsV1ResponseModelsItems0!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems1 && agentThinkModelsV1ResponseModelsItems1 != null)
            {
                return agentThinkModelsV1ResponseModelsItems1(AgentThinkModelsV1ResponseModelsItems1!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems2 && agentThinkModelsV1ResponseModelsItems2 != null)
            {
                return agentThinkModelsV1ResponseModelsItems2(AgentThinkModelsV1ResponseModelsItems2!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems3 && agentThinkModelsV1ResponseModelsItems3 != null)
            {
                return agentThinkModelsV1ResponseModelsItems3(AgentThinkModelsV1ResponseModelsItems3!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems4 && agentThinkModelsV1ResponseModelsItems4 != null)
            {
                return agentThinkModelsV1ResponseModelsItems4(AgentThinkModelsV1ResponseModelsItems4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.AgentThinkModelsV1ResponseModelsItems0?>? agentThinkModelsV1ResponseModelsItems0 = null,
            global::System.Action<global::Deepgram.AgentThinkModelsV1ResponseModelsItems1?>? agentThinkModelsV1ResponseModelsItems1 = null,
            global::System.Action<global::Deepgram.AgentThinkModelsV1ResponseModelsItems2?>? agentThinkModelsV1ResponseModelsItems2 = null,
            global::System.Action<global::Deepgram.AgentThinkModelsV1ResponseModelsItems3?>? agentThinkModelsV1ResponseModelsItems3 = null,
            global::System.Action<global::Deepgram.AgentThinkModelsV1ResponseModelsItems4?>? agentThinkModelsV1ResponseModelsItems4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentThinkModelsV1ResponseModelsItems0)
            {
                agentThinkModelsV1ResponseModelsItems0?.Invoke(AgentThinkModelsV1ResponseModelsItems0!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems1)
            {
                agentThinkModelsV1ResponseModelsItems1?.Invoke(AgentThinkModelsV1ResponseModelsItems1!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems2)
            {
                agentThinkModelsV1ResponseModelsItems2?.Invoke(AgentThinkModelsV1ResponseModelsItems2!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems3)
            {
                agentThinkModelsV1ResponseModelsItems3?.Invoke(AgentThinkModelsV1ResponseModelsItems3!);
            }
            else if (IsAgentThinkModelsV1ResponseModelsItems4)
            {
                agentThinkModelsV1ResponseModelsItems4?.Invoke(AgentThinkModelsV1ResponseModelsItems4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentThinkModelsV1ResponseModelsItems0,
                typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0),
                AgentThinkModelsV1ResponseModelsItems1,
                typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1),
                AgentThinkModelsV1ResponseModelsItems2,
                typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2),
                AgentThinkModelsV1ResponseModelsItems3,
                typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3),
                AgentThinkModelsV1ResponseModelsItems4,
                typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4),
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
        public bool Equals(AgentThinkModelsV1ResponseModelsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.AgentThinkModelsV1ResponseModelsItems0?>.Default.Equals(AgentThinkModelsV1ResponseModelsItems0, other.AgentThinkModelsV1ResponseModelsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.AgentThinkModelsV1ResponseModelsItems1?>.Default.Equals(AgentThinkModelsV1ResponseModelsItems1, other.AgentThinkModelsV1ResponseModelsItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.AgentThinkModelsV1ResponseModelsItems2?>.Default.Equals(AgentThinkModelsV1ResponseModelsItems2, other.AgentThinkModelsV1ResponseModelsItems2) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.AgentThinkModelsV1ResponseModelsItems3?>.Default.Equals(AgentThinkModelsV1ResponseModelsItems3, other.AgentThinkModelsV1ResponseModelsItems3) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.AgentThinkModelsV1ResponseModelsItems4?>.Default.Equals(AgentThinkModelsV1ResponseModelsItems4, other.AgentThinkModelsV1ResponseModelsItems4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentThinkModelsV1ResponseModelsItems obj1, AgentThinkModelsV1ResponseModelsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentThinkModelsV1ResponseModelsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentThinkModelsV1ResponseModelsItems obj1, AgentThinkModelsV1ResponseModelsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentThinkModelsV1ResponseModelsItems o && Equals(o);
        }
    }
}
