#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersKeywords : global::System.IEquatable<V1ListenPostParametersKeywords>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersKeywordsVariant1 { get; init; }
#else
        public string? V1ListenPostParametersKeywordsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersKeywordsVariant1))]
#endif
        public bool IsV1ListenPostParametersKeywordsVariant1 => V1ListenPostParametersKeywordsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersKeywordsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersKeywordsVariant1;
            return IsV1ListenPostParametersKeywordsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ListenPostParametersKeywordsVariant1() => IsV1ListenPostParametersKeywordsVariant1
            ? V1ListenPostParametersKeywordsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersKeywordsVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersKeywordsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersKeywordsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersKeywordsVariant2))]
#endif
        public bool IsV1ListenPostParametersKeywordsVariant2 => V1ListenPostParametersKeywordsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersKeywordsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersKeywordsVariant2;
            return IsV1ListenPostParametersKeywordsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ListenPostParametersKeywordsVariant2() => IsV1ListenPostParametersKeywordsVariant2
            ? V1ListenPostParametersKeywordsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersKeywordsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersKeywords(string value) => new V1ListenPostParametersKeywords((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersKeywords @this) => @this.V1ListenPostParametersKeywordsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersKeywords(string? value)
        {
            V1ListenPostParametersKeywordsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ListenPostParametersKeywords FromV1ListenPostParametersKeywordsVariant1(string? value) => new V1ListenPostParametersKeywords(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersKeywords(
            string? v1ListenPostParametersKeywordsVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersKeywordsVariant2
            )
        {
            V1ListenPostParametersKeywordsVariant1 = v1ListenPostParametersKeywordsVariant1;
            V1ListenPostParametersKeywordsVariant2 = v1ListenPostParametersKeywordsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersKeywordsVariant2 as object ??
            V1ListenPostParametersKeywordsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersKeywordsVariant1?.ToString() ??
            V1ListenPostParametersKeywordsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersKeywordsVariant1 && !IsV1ListenPostParametersKeywordsVariant2 || !IsV1ListenPostParametersKeywordsVariant1 && IsV1ListenPostParametersKeywordsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersKeywordsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersKeywordsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersKeywordsVariant1 && v1ListenPostParametersKeywordsVariant1 != null)
            {
                return v1ListenPostParametersKeywordsVariant1(V1ListenPostParametersKeywordsVariant1!);
            }
            else if (IsV1ListenPostParametersKeywordsVariant2 && v1ListenPostParametersKeywordsVariant2 != null)
            {
                return v1ListenPostParametersKeywordsVariant2(V1ListenPostParametersKeywordsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersKeywordsVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersKeywordsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersKeywordsVariant1)
            {
                v1ListenPostParametersKeywordsVariant1?.Invoke(V1ListenPostParametersKeywordsVariant1!);
            }
            else if (IsV1ListenPostParametersKeywordsVariant2)
            {
                v1ListenPostParametersKeywordsVariant2?.Invoke(V1ListenPostParametersKeywordsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersKeywordsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersKeywordsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersKeywordsVariant1)
            {
                v1ListenPostParametersKeywordsVariant1?.Invoke(V1ListenPostParametersKeywordsVariant1!);
            }
            else if (IsV1ListenPostParametersKeywordsVariant2)
            {
                v1ListenPostParametersKeywordsVariant2?.Invoke(V1ListenPostParametersKeywordsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersKeywordsVariant1,
                typeof(string),
                V1ListenPostParametersKeywordsVariant2,
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
        public bool Equals(V1ListenPostParametersKeywords other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersKeywordsVariant1, other.V1ListenPostParametersKeywordsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersKeywordsVariant2, other.V1ListenPostParametersKeywordsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersKeywords obj1, V1ListenPostParametersKeywords obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersKeywords>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersKeywords obj1, V1ListenPostParametersKeywords obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersKeywords o && Equals(o);
        }
    }
}
