#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Specifies the number of characters retained in context between user messages, agent responses, and function calls. This setting is only configurable when a custom think endpoint is used
    /// </summary>
    public readonly partial struct ThinkSettingsV1ContextLength : global::System.IEquatable<ThinkSettingsV1ContextLength>
    {
        /// <summary>
        /// Agent will not discard context regardless of length
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ThinkSettingsV1ContextLength0? ThinkSettingsV1ContextLength0 { get; init; }
#else
        public global::Deepgram.Realtime.ThinkSettingsV1ContextLength0? ThinkSettingsV1ContextLength0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkSettingsV1ContextLength0))]
#endif
        public bool IsThinkSettingsV1ContextLength0 => ThinkSettingsV1ContextLength0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinkSettingsV1ContextLength0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ThinkSettingsV1ContextLength0? value)
        {
            value = ThinkSettingsV1ContextLength0;
            return IsThinkSettingsV1ContextLength0;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ThinkSettingsV1ContextLengthVariant2 { get; init; }
#else
        public double? ThinkSettingsV1ContextLengthVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkSettingsV1ContextLengthVariant2))]
#endif
        public bool IsThinkSettingsV1ContextLengthVariant2 => ThinkSettingsV1ContextLengthVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinkSettingsV1ContextLengthVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = ThinkSettingsV1ContextLengthVariant2;
            return IsThinkSettingsV1ContextLengthVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1ContextLength(global::Deepgram.Realtime.ThinkSettingsV1ContextLength0 value) => new ThinkSettingsV1ContextLength((global::Deepgram.Realtime.ThinkSettingsV1ContextLength0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ThinkSettingsV1ContextLength0?(ThinkSettingsV1ContextLength @this) => @this.ThinkSettingsV1ContextLength0;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1ContextLength(global::Deepgram.Realtime.ThinkSettingsV1ContextLength0? value)
        {
            ThinkSettingsV1ContextLength0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkSettingsV1ContextLength(double value) => new ThinkSettingsV1ContextLength((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ThinkSettingsV1ContextLength @this) => @this.ThinkSettingsV1ContextLengthVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1ContextLength(double? value)
        {
            ThinkSettingsV1ContextLengthVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ThinkSettingsV1ContextLength(
            global::Deepgram.Realtime.ThinkSettingsV1ContextLength0? thinkSettingsV1ContextLength0,
            double? thinkSettingsV1ContextLengthVariant2
            )
        {
            ThinkSettingsV1ContextLength0 = thinkSettingsV1ContextLength0;
            ThinkSettingsV1ContextLengthVariant2 = thinkSettingsV1ContextLengthVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThinkSettingsV1ContextLengthVariant2 as object ??
            ThinkSettingsV1ContextLength0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ThinkSettingsV1ContextLength0?.ToValueString() ??
            ThinkSettingsV1ContextLengthVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThinkSettingsV1ContextLength0 && !IsThinkSettingsV1ContextLengthVariant2 || !IsThinkSettingsV1ContextLength0 && IsThinkSettingsV1ContextLengthVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ThinkSettingsV1ContextLength0?, TResult>? thinkSettingsV1ContextLength0 = null,
            global::System.Func<double?, TResult>? thinkSettingsV1ContextLengthVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkSettingsV1ContextLength0 && thinkSettingsV1ContextLength0 != null)
            {
                return thinkSettingsV1ContextLength0(ThinkSettingsV1ContextLength0!);
            }
            else if (IsThinkSettingsV1ContextLengthVariant2 && thinkSettingsV1ContextLengthVariant2 != null)
            {
                return thinkSettingsV1ContextLengthVariant2(ThinkSettingsV1ContextLengthVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ThinkSettingsV1ContextLength0?>? thinkSettingsV1ContextLength0 = null,

            global::System.Action<double?>? thinkSettingsV1ContextLengthVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkSettingsV1ContextLength0)
            {
                thinkSettingsV1ContextLength0?.Invoke(ThinkSettingsV1ContextLength0!);
            }
            else if (IsThinkSettingsV1ContextLengthVariant2)
            {
                thinkSettingsV1ContextLengthVariant2?.Invoke(ThinkSettingsV1ContextLengthVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.ThinkSettingsV1ContextLength0?>? thinkSettingsV1ContextLength0 = null,
            global::System.Action<double?>? thinkSettingsV1ContextLengthVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkSettingsV1ContextLength0)
            {
                thinkSettingsV1ContextLength0?.Invoke(ThinkSettingsV1ContextLength0!);
            }
            else if (IsThinkSettingsV1ContextLengthVariant2)
            {
                thinkSettingsV1ContextLengthVariant2?.Invoke(ThinkSettingsV1ContextLengthVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ThinkSettingsV1ContextLength0,
                typeof(global::Deepgram.Realtime.ThinkSettingsV1ContextLength0),
                ThinkSettingsV1ContextLengthVariant2,
                typeof(double),
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
        public bool Equals(ThinkSettingsV1ContextLength other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ThinkSettingsV1ContextLength0?>.Default.Equals(ThinkSettingsV1ContextLength0, other.ThinkSettingsV1ContextLength0) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ThinkSettingsV1ContextLengthVariant2, other.ThinkSettingsV1ContextLengthVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThinkSettingsV1ContextLength obj1, ThinkSettingsV1ContextLength obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThinkSettingsV1ContextLength>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThinkSettingsV1ContextLength obj1, ThinkSettingsV1ContextLength obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThinkSettingsV1ContextLength o && Equals(o);
        }
    }
}
