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
        public global::Deepgram.GetModelV1ResponseVariant1? GetModelV1ResponseVariant1 { get; init; }
#else
        public global::Deepgram.GetModelV1ResponseVariant1? GetModelV1ResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetModelV1ResponseVariant1))]
#endif
        public bool IsGetModelV1ResponseVariant1 => GetModelV1ResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.GetModelV1ResponseVariant2? GetModelV1ResponseVariant2 { get; init; }
#else
        public global::Deepgram.GetModelV1ResponseVariant2? GetModelV1ResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetModelV1ResponseVariant2))]
#endif
        public bool IsGetModelV1ResponseVariant2 => GetModelV1ResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetModelV1Response(global::Deepgram.GetModelV1ResponseVariant1 value) => new GetModelV1Response((global::Deepgram.GetModelV1ResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.GetModelV1ResponseVariant1?(GetModelV1Response @this) => @this.GetModelV1ResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GetModelV1Response(global::Deepgram.GetModelV1ResponseVariant1? value)
        {
            GetModelV1ResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetModelV1Response(global::Deepgram.GetModelV1ResponseVariant2 value) => new GetModelV1Response((global::Deepgram.GetModelV1ResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.GetModelV1ResponseVariant2?(GetModelV1Response @this) => @this.GetModelV1ResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetModelV1Response(global::Deepgram.GetModelV1ResponseVariant2? value)
        {
            GetModelV1ResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetModelV1Response(
            global::Deepgram.GetModelV1ResponseVariant1? getModelV1ResponseVariant1,
            global::Deepgram.GetModelV1ResponseVariant2? getModelV1ResponseVariant2
            )
        {
            GetModelV1ResponseVariant1 = getModelV1ResponseVariant1;
            GetModelV1ResponseVariant2 = getModelV1ResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetModelV1ResponseVariant2 as object ??
            GetModelV1ResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GetModelV1ResponseVariant1?.ToString() ??
            GetModelV1ResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGetModelV1ResponseVariant1 && !IsGetModelV1ResponseVariant2 || !IsGetModelV1ResponseVariant1 && IsGetModelV1ResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.GetModelV1ResponseVariant1?, TResult>? getModelV1ResponseVariant1 = null,
            global::System.Func<global::Deepgram.GetModelV1ResponseVariant2?, TResult>? getModelV1ResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetModelV1ResponseVariant1 && getModelV1ResponseVariant1 != null)
            {
                return getModelV1ResponseVariant1(GetModelV1ResponseVariant1!);
            }
            else if (IsGetModelV1ResponseVariant2 && getModelV1ResponseVariant2 != null)
            {
                return getModelV1ResponseVariant2(GetModelV1ResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.GetModelV1ResponseVariant1?>? getModelV1ResponseVariant1 = null,
            global::System.Action<global::Deepgram.GetModelV1ResponseVariant2?>? getModelV1ResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGetModelV1ResponseVariant1)
            {
                getModelV1ResponseVariant1?.Invoke(GetModelV1ResponseVariant1!);
            }
            else if (IsGetModelV1ResponseVariant2)
            {
                getModelV1ResponseVariant2?.Invoke(GetModelV1ResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GetModelV1ResponseVariant1,
                typeof(global::Deepgram.GetModelV1ResponseVariant1),
                GetModelV1ResponseVariant2,
                typeof(global::Deepgram.GetModelV1ResponseVariant2),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.GetModelV1ResponseVariant1?>.Default.Equals(GetModelV1ResponseVariant1, other.GetModelV1ResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.GetModelV1ResponseVariant2?>.Default.Equals(GetModelV1ResponseVariant2, other.GetModelV1ResponseVariant2) 
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
