#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersTag : global::System.IEquatable<V1ListenPostParametersTag>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersTagVariant1 { get; init; }
#else
        public string? V1ListenPostParametersTagVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersTagVariant1))]
#endif
        public bool IsV1ListenPostParametersTagVariant1 => V1ListenPostParametersTagVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersTagVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersTagVariant1;
            return IsV1ListenPostParametersTagVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ListenPostParametersTagVariant1() => IsV1ListenPostParametersTagVariant1
            ? V1ListenPostParametersTagVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersTagVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersTagVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersTagVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersTagVariant2))]
#endif
        public bool IsV1ListenPostParametersTagVariant2 => V1ListenPostParametersTagVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersTagVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersTagVariant2;
            return IsV1ListenPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ListenPostParametersTagVariant2() => IsV1ListenPostParametersTagVariant2
            ? V1ListenPostParametersTagVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersTagVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersTag(string value) => new V1ListenPostParametersTag((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersTag @this) => @this.V1ListenPostParametersTagVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersTag(string? value)
        {
            V1ListenPostParametersTagVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ListenPostParametersTag FromV1ListenPostParametersTagVariant1(string? value) => new V1ListenPostParametersTag(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersTag(
            string? v1ListenPostParametersTagVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersTagVariant2
            )
        {
            V1ListenPostParametersTagVariant1 = v1ListenPostParametersTagVariant1;
            V1ListenPostParametersTagVariant2 = v1ListenPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersTagVariant2 as object ??
            V1ListenPostParametersTagVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersTagVariant1?.ToString() ??
            V1ListenPostParametersTagVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersTagVariant1 && !IsV1ListenPostParametersTagVariant2 || !IsV1ListenPostParametersTagVariant1 && IsV1ListenPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersTagVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersTagVariant1 && v1ListenPostParametersTagVariant1 != null)
            {
                return v1ListenPostParametersTagVariant1(V1ListenPostParametersTagVariant1!);
            }
            else if (IsV1ListenPostParametersTagVariant2 && v1ListenPostParametersTagVariant2 != null)
            {
                return v1ListenPostParametersTagVariant2(V1ListenPostParametersTagVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersTagVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersTagVariant1)
            {
                v1ListenPostParametersTagVariant1?.Invoke(V1ListenPostParametersTagVariant1!);
            }
            else if (IsV1ListenPostParametersTagVariant2)
            {
                v1ListenPostParametersTagVariant2?.Invoke(V1ListenPostParametersTagVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersTagVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersTagVariant1)
            {
                v1ListenPostParametersTagVariant1?.Invoke(V1ListenPostParametersTagVariant1!);
            }
            else if (IsV1ListenPostParametersTagVariant2)
            {
                v1ListenPostParametersTagVariant2?.Invoke(V1ListenPostParametersTagVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersTagVariant1,
                typeof(string),
                V1ListenPostParametersTagVariant2,
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
        public bool Equals(V1ListenPostParametersTag other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersTagVariant1, other.V1ListenPostParametersTagVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersTagVariant2, other.V1ListenPostParametersTagVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersTag obj1, V1ListenPostParametersTag obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersTag>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersTag obj1, V1ListenPostParametersTag obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersTag o && Equals(o);
        }
    }
}
