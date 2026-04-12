#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1SpeakPostParametersTag : global::System.IEquatable<V1SpeakPostParametersTag>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1SpeakPostParametersTagVariant1 { get; init; }
#else
        public string? V1SpeakPostParametersTagVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersTagVariant1))]
#endif
        public bool IsV1SpeakPostParametersTagVariant1 => V1SpeakPostParametersTagVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1SpeakPostParametersTagVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1SpeakPostParametersTagVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1SpeakPostParametersTagVariant2))]
#endif
        public bool IsV1SpeakPostParametersTagVariant2 => V1SpeakPostParametersTagVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1SpeakPostParametersTag(string value) => new V1SpeakPostParametersTag((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1SpeakPostParametersTag @this) => @this.V1SpeakPostParametersTagVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersTag(string? value)
        {
            V1SpeakPostParametersTagVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1SpeakPostParametersTag(
            string? v1SpeakPostParametersTagVariant1,
            global::System.Collections.Generic.IList<string>? v1SpeakPostParametersTagVariant2
            )
        {
            V1SpeakPostParametersTagVariant1 = v1SpeakPostParametersTagVariant1;
            V1SpeakPostParametersTagVariant2 = v1SpeakPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1SpeakPostParametersTagVariant2 as object ??
            V1SpeakPostParametersTagVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1SpeakPostParametersTagVariant1?.ToString() ??
            V1SpeakPostParametersTagVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1SpeakPostParametersTagVariant1 && !IsV1SpeakPostParametersTagVariant2 || !IsV1SpeakPostParametersTagVariant1 && IsV1SpeakPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? v1SpeakPostParametersTagVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? v1SpeakPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersTagVariant1 && v1SpeakPostParametersTagVariant1 != null)
            {
                return v1SpeakPostParametersTagVariant1(V1SpeakPostParametersTagVariant1!);
            }
            else if (IsV1SpeakPostParametersTagVariant2 && v1SpeakPostParametersTagVariant2 != null)
            {
                return v1SpeakPostParametersTagVariant2(V1SpeakPostParametersTagVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? v1SpeakPostParametersTagVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? v1SpeakPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1SpeakPostParametersTagVariant1)
            {
                v1SpeakPostParametersTagVariant1?.Invoke(V1SpeakPostParametersTagVariant1!);
            }
            else if (IsV1SpeakPostParametersTagVariant2)
            {
                v1SpeakPostParametersTagVariant2?.Invoke(V1SpeakPostParametersTagVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1SpeakPostParametersTagVariant1,
                typeof(string),
                V1SpeakPostParametersTagVariant2,
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
        public bool Equals(V1SpeakPostParametersTag other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1SpeakPostParametersTagVariant1, other.V1SpeakPostParametersTagVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1SpeakPostParametersTagVariant2, other.V1SpeakPostParametersTagVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1SpeakPostParametersTag obj1, V1SpeakPostParametersTag obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1SpeakPostParametersTag>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1SpeakPostParametersTag obj1, V1SpeakPostParametersTag obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1SpeakPostParametersTag o && Equals(o);
        }
    }
}
