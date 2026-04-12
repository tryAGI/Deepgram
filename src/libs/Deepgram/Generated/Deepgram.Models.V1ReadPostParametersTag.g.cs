#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ReadPostParametersTag : global::System.IEquatable<V1ReadPostParametersTag>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ReadPostParametersTagVariant1 { get; init; }
#else
        public string? V1ReadPostParametersTagVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersTagVariant1))]
#endif
        public bool IsV1ReadPostParametersTagVariant1 => V1ReadPostParametersTagVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ReadPostParametersTagVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ReadPostParametersTagVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersTagVariant2))]
#endif
        public bool IsV1ReadPostParametersTagVariant2 => V1ReadPostParametersTagVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ReadPostParametersTag(string value) => new V1ReadPostParametersTag((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ReadPostParametersTag @this) => @this.V1ReadPostParametersTagVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersTag(string? value)
        {
            V1ReadPostParametersTagVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersTag(
            string? v1ReadPostParametersTagVariant1,
            global::System.Collections.Generic.IList<string>? v1ReadPostParametersTagVariant2
            )
        {
            V1ReadPostParametersTagVariant1 = v1ReadPostParametersTagVariant1;
            V1ReadPostParametersTagVariant2 = v1ReadPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ReadPostParametersTagVariant2 as object ??
            V1ReadPostParametersTagVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ReadPostParametersTagVariant1?.ToString() ??
            V1ReadPostParametersTagVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ReadPostParametersTagVariant1 && !IsV1ReadPostParametersTagVariant2 || !IsV1ReadPostParametersTagVariant1 && IsV1ReadPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? v1ReadPostParametersTagVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? v1ReadPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersTagVariant1 && v1ReadPostParametersTagVariant1 != null)
            {
                return v1ReadPostParametersTagVariant1(V1ReadPostParametersTagVariant1!);
            }
            else if (IsV1ReadPostParametersTagVariant2 && v1ReadPostParametersTagVariant2 != null)
            {
                return v1ReadPostParametersTagVariant2(V1ReadPostParametersTagVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? v1ReadPostParametersTagVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? v1ReadPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersTagVariant1)
            {
                v1ReadPostParametersTagVariant1?.Invoke(V1ReadPostParametersTagVariant1!);
            }
            else if (IsV1ReadPostParametersTagVariant2)
            {
                v1ReadPostParametersTagVariant2?.Invoke(V1ReadPostParametersTagVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ReadPostParametersTagVariant1,
                typeof(string),
                V1ReadPostParametersTagVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(V1ReadPostParametersTag other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ReadPostParametersTagVariant1, other.V1ReadPostParametersTagVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ReadPostParametersTagVariant2, other.V1ReadPostParametersTagVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ReadPostParametersTag obj1, V1ReadPostParametersTag obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ReadPostParametersTag>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ReadPostParametersTag obj1, V1ReadPostParametersTag obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ReadPostParametersTag o && Equals(o);
        }
    }
}
