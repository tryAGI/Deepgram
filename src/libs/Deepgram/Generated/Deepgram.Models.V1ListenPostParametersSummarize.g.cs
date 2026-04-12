#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersSummarize : global::System.IEquatable<V1ListenPostParametersSummarize>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1ListenPostParametersSummarize0? V1ListenPostParametersSummarize0 { get; init; }
#else
        public global::Deepgram.V1ListenPostParametersSummarize0? V1ListenPostParametersSummarize0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersSummarize0))]
#endif
        public bool IsV1ListenPostParametersSummarize0 => V1ListenPostParametersSummarize0 != null;

        /// <summary>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? V1ListenPostParametersSummarizeVariant2 { get; init; }
#else
        public bool? V1ListenPostParametersSummarizeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersSummarizeVariant2))]
#endif
        public bool IsV1ListenPostParametersSummarizeVariant2 => V1ListenPostParametersSummarizeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersSummarize(global::Deepgram.V1ListenPostParametersSummarize0 value) => new V1ListenPostParametersSummarize((global::Deepgram.V1ListenPostParametersSummarize0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1ListenPostParametersSummarize0?(V1ListenPostParametersSummarize @this) => @this.V1ListenPostParametersSummarize0;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersSummarize(global::Deepgram.V1ListenPostParametersSummarize0? value)
        {
            V1ListenPostParametersSummarize0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersSummarize(bool value) => new V1ListenPostParametersSummarize((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(V1ListenPostParametersSummarize @this) => @this.V1ListenPostParametersSummarizeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersSummarize(bool? value)
        {
            V1ListenPostParametersSummarizeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersSummarize(
            global::Deepgram.V1ListenPostParametersSummarize0? v1ListenPostParametersSummarize0,
            bool? v1ListenPostParametersSummarizeVariant2
            )
        {
            V1ListenPostParametersSummarize0 = v1ListenPostParametersSummarize0;
            V1ListenPostParametersSummarizeVariant2 = v1ListenPostParametersSummarizeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersSummarizeVariant2 as object ??
            V1ListenPostParametersSummarize0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersSummarize0?.ToValueString() ??
            V1ListenPostParametersSummarizeVariant2?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersSummarize0 && !IsV1ListenPostParametersSummarizeVariant2 || !IsV1ListenPostParametersSummarize0 && IsV1ListenPostParametersSummarizeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1ListenPostParametersSummarize0?, TResult>? v1ListenPostParametersSummarize0 = null,
            global::System.Func<bool?, TResult>? v1ListenPostParametersSummarizeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersSummarize0 && v1ListenPostParametersSummarize0 != null)
            {
                return v1ListenPostParametersSummarize0(V1ListenPostParametersSummarize0!);
            }
            else if (IsV1ListenPostParametersSummarizeVariant2 && v1ListenPostParametersSummarizeVariant2 != null)
            {
                return v1ListenPostParametersSummarizeVariant2(V1ListenPostParametersSummarizeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1ListenPostParametersSummarize0?>? v1ListenPostParametersSummarize0 = null,
            global::System.Action<bool?>? v1ListenPostParametersSummarizeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersSummarize0)
            {
                v1ListenPostParametersSummarize0?.Invoke(V1ListenPostParametersSummarize0!);
            }
            else if (IsV1ListenPostParametersSummarizeVariant2)
            {
                v1ListenPostParametersSummarizeVariant2?.Invoke(V1ListenPostParametersSummarizeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersSummarize0,
                typeof(global::Deepgram.V1ListenPostParametersSummarize0),
                V1ListenPostParametersSummarizeVariant2,
                typeof(bool),
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
        public bool Equals(V1ListenPostParametersSummarize other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1ListenPostParametersSummarize0?>.Default.Equals(V1ListenPostParametersSummarize0, other.V1ListenPostParametersSummarize0) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(V1ListenPostParametersSummarizeVariant2, other.V1ListenPostParametersSummarizeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersSummarize obj1, V1ListenPostParametersSummarize obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersSummarize>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersSummarize obj1, V1ListenPostParametersSummarize obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersSummarize o && Equals(o);
        }
    }
}
