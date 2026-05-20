#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetModelV1Response : global::System.IEquatable<GetModelV1Response>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.GetModelV1Response0? GetModelV1Response0 { get; init; }
#else
        public global::Deepgram.GetModelV1Response0? GetModelV1Response0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetModelV1Response0))]
#endif
        public bool IsGetModelV1Response0 => GetModelV1Response0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetModelV1Response0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.GetModelV1Response0? value)
        {
            value = GetModelV1Response0;
            return IsGetModelV1Response0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.GetModelV1Response0 PickGetModelV1Response0() => IsGetModelV1Response0
            ? GetModelV1Response0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetModelV1Response0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.GetModelV1Response1? GetModelV1Response1 { get; init; }
#else
        public global::Deepgram.GetModelV1Response1? GetModelV1Response1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetModelV1Response1))]
#endif
        public bool IsGetModelV1Response1 => GetModelV1Response1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetModelV1Response1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.GetModelV1Response1? value)
        {
            value = GetModelV1Response1;
            return IsGetModelV1Response1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.GetModelV1Response1 PickGetModelV1Response1() => IsGetModelV1Response1
            ? GetModelV1Response1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetModelV1Response1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetModelV1Response(global::Deepgram.GetModelV1Response0 value) => new GetModelV1Response((global::Deepgram.GetModelV1Response0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.GetModelV1Response0?(GetModelV1Response @this) => @this.GetModelV1Response0;

        /// <summary>
        /// 
        /// </summary>
        public GetModelV1Response(global::Deepgram.GetModelV1Response0? value)
        {
            GetModelV1Response0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetModelV1Response FromGetModelV1Response0(global::Deepgram.GetModelV1Response0? value) => new GetModelV1Response(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetModelV1Response(global::Deepgram.GetModelV1Response1 value) => new GetModelV1Response((global::Deepgram.GetModelV1Response1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.GetModelV1Response1?(GetModelV1Response @this) => @this.GetModelV1Response1;

        /// <summary>
        /// 
        /// </summary>
        public GetModelV1Response(global::Deepgram.GetModelV1Response1? value)
        {
            GetModelV1Response1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetModelV1Response FromGetModelV1Response1(global::Deepgram.GetModelV1Response1? value) => new GetModelV1Response(value);

        /// <summary>
        /// 
        /// </summary>
        public GetModelV1Response(
            global::Deepgram.GetModelV1Response0? getModelV1Response0,
            global::Deepgram.GetModelV1Response1? getModelV1Response1
            )
        {
            GetModelV1Response0 = getModelV1Response0;
            GetModelV1Response1 = getModelV1Response1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetModelV1Response1 as object ??
            GetModelV1Response0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GetModelV1Response0?.ToString() ??
            GetModelV1Response1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGetModelV1Response0 && !IsGetModelV1Response1 || !IsGetModelV1Response0 && IsGetModelV1Response1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.GetModelV1Response0, TResult>? getModelV1Response0 = null,
            global::System.Func<global::Deepgram.GetModelV1Response1, TResult>? getModelV1Response1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetModelV1Response0 && getModelV1Response0 != null)
            {
                return getModelV1Response0(GetModelV1Response0!);
            }
            else if (IsGetModelV1Response1 && getModelV1Response1 != null)
            {
                return getModelV1Response1(GetModelV1Response1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.GetModelV1Response0>? getModelV1Response0 = null,

            global::System.Action<global::Deepgram.GetModelV1Response1>? getModelV1Response1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetModelV1Response0)
            {
                getModelV1Response0?.Invoke(GetModelV1Response0!);
            }
            else if (IsGetModelV1Response1)
            {
                getModelV1Response1?.Invoke(GetModelV1Response1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.GetModelV1Response0>? getModelV1Response0 = null,
            global::System.Action<global::Deepgram.GetModelV1Response1>? getModelV1Response1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetModelV1Response0)
            {
                getModelV1Response0?.Invoke(GetModelV1Response0!);
            }
            else if (IsGetModelV1Response1)
            {
                getModelV1Response1?.Invoke(GetModelV1Response1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GetModelV1Response0,
                typeof(global::Deepgram.GetModelV1Response0),
                GetModelV1Response1,
                typeof(global::Deepgram.GetModelV1Response1),
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
        public bool Equals(GetModelV1Response other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.GetModelV1Response0?>.Default.Equals(GetModelV1Response0, other.GetModelV1Response0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.GetModelV1Response1?>.Default.Equals(GetModelV1Response1, other.GetModelV1Response1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetModelV1Response obj1, GetModelV1Response obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetModelV1Response>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetModelV1Response obj1, GetModelV1Response obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetModelV1Response o && Equals(o);
        }
    }
}
