#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ReadPostParametersSummarize : global::System.IEquatable<V1ReadPostParametersSummarize>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1ReadPostParametersSummarize0? V1ReadPostParametersSummarize0 { get; init; }
#else
        public global::Deepgram.V1ReadPostParametersSummarize0? V1ReadPostParametersSummarize0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersSummarize0))]
#endif
        public bool IsV1ReadPostParametersSummarize0 => V1ReadPostParametersSummarize0 != null;

        /// <summary>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? V1ReadPostParametersSummarizeVariant2 { get; init; }
#else
        public bool? V1ReadPostParametersSummarizeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersSummarizeVariant2))]
#endif
        public bool IsV1ReadPostParametersSummarizeVariant2 => V1ReadPostParametersSummarizeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ReadPostParametersSummarize(global::Deepgram.V1ReadPostParametersSummarize0 value) => new V1ReadPostParametersSummarize((global::Deepgram.V1ReadPostParametersSummarize0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1ReadPostParametersSummarize0?(V1ReadPostParametersSummarize @this) => @this.V1ReadPostParametersSummarize0;

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersSummarize(global::Deepgram.V1ReadPostParametersSummarize0? value)
        {
            V1ReadPostParametersSummarize0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ReadPostParametersSummarize(bool value) => new V1ReadPostParametersSummarize((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(V1ReadPostParametersSummarize @this) => @this.V1ReadPostParametersSummarizeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersSummarize(bool? value)
        {
            V1ReadPostParametersSummarizeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersSummarize(
            global::Deepgram.V1ReadPostParametersSummarize0? v1ReadPostParametersSummarize0,
            bool? v1ReadPostParametersSummarizeVariant2
            )
        {
            V1ReadPostParametersSummarize0 = v1ReadPostParametersSummarize0;
            V1ReadPostParametersSummarizeVariant2 = v1ReadPostParametersSummarizeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ReadPostParametersSummarizeVariant2 as object ??
            V1ReadPostParametersSummarize0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ReadPostParametersSummarize0?.ToValueString() ??
            V1ReadPostParametersSummarizeVariant2?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ReadPostParametersSummarize0 && !IsV1ReadPostParametersSummarizeVariant2 || !IsV1ReadPostParametersSummarize0 && IsV1ReadPostParametersSummarizeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1ReadPostParametersSummarize0?, TResult>? v1ReadPostParametersSummarize0 = null,
            global::System.Func<bool?, TResult>? v1ReadPostParametersSummarizeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersSummarize0 && v1ReadPostParametersSummarize0 != null)
            {
                return v1ReadPostParametersSummarize0(V1ReadPostParametersSummarize0!);
            }
            else if (IsV1ReadPostParametersSummarizeVariant2 && v1ReadPostParametersSummarizeVariant2 != null)
            {
                return v1ReadPostParametersSummarizeVariant2(V1ReadPostParametersSummarizeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1ReadPostParametersSummarize0?>? v1ReadPostParametersSummarize0 = null,
            global::System.Action<bool?>? v1ReadPostParametersSummarizeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersSummarize0)
            {
                v1ReadPostParametersSummarize0?.Invoke(V1ReadPostParametersSummarize0!);
            }
            else if (IsV1ReadPostParametersSummarizeVariant2)
            {
                v1ReadPostParametersSummarizeVariant2?.Invoke(V1ReadPostParametersSummarizeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ReadPostParametersSummarize0,
                typeof(global::Deepgram.V1ReadPostParametersSummarize0),
                V1ReadPostParametersSummarizeVariant2,
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
        public bool Equals(V1ReadPostParametersSummarize other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1ReadPostParametersSummarize0?>.Default.Equals(V1ReadPostParametersSummarize0, other.V1ReadPostParametersSummarize0) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(V1ReadPostParametersSummarizeVariant2, other.V1ReadPostParametersSummarizeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ReadPostParametersSummarize obj1, V1ReadPostParametersSummarize obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ReadPostParametersSummarize>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ReadPostParametersSummarize obj1, V1ReadPostParametersSummarize obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ReadPostParametersSummarize o && Equals(o);
        }
    }
}
