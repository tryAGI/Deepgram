#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersCustomIntent : global::System.IEquatable<V1ListenPostParametersCustomIntent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersCustomIntentVariant1 { get; init; }
#else
        public string? V1ListenPostParametersCustomIntentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersCustomIntentVariant1))]
#endif
        public bool IsV1ListenPostParametersCustomIntentVariant1 => V1ListenPostParametersCustomIntentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersCustomIntentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersCustomIntentVariant1;
            return IsV1ListenPostParametersCustomIntentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ListenPostParametersCustomIntentVariant1() => IsV1ListenPostParametersCustomIntentVariant1
            ? V1ListenPostParametersCustomIntentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersCustomIntentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersCustomIntentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersCustomIntentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersCustomIntentVariant2))]
#endif
        public bool IsV1ListenPostParametersCustomIntentVariant2 => V1ListenPostParametersCustomIntentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersCustomIntentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersCustomIntentVariant2;
            return IsV1ListenPostParametersCustomIntentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ListenPostParametersCustomIntentVariant2() => IsV1ListenPostParametersCustomIntentVariant2
            ? V1ListenPostParametersCustomIntentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersCustomIntentVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersCustomIntent(string value) => new V1ListenPostParametersCustomIntent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersCustomIntent @this) => @this.V1ListenPostParametersCustomIntentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersCustomIntent(string? value)
        {
            V1ListenPostParametersCustomIntentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ListenPostParametersCustomIntent FromV1ListenPostParametersCustomIntentVariant1(string? value) => new V1ListenPostParametersCustomIntent(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersCustomIntent(
            string? v1ListenPostParametersCustomIntentVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersCustomIntentVariant2
            )
        {
            V1ListenPostParametersCustomIntentVariant1 = v1ListenPostParametersCustomIntentVariant1;
            V1ListenPostParametersCustomIntentVariant2 = v1ListenPostParametersCustomIntentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersCustomIntentVariant2 as object ??
            V1ListenPostParametersCustomIntentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersCustomIntentVariant1?.ToString() ??
            V1ListenPostParametersCustomIntentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersCustomIntentVariant1 && !IsV1ListenPostParametersCustomIntentVariant2 || !IsV1ListenPostParametersCustomIntentVariant1 && IsV1ListenPostParametersCustomIntentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersCustomIntentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersCustomIntentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersCustomIntentVariant1 && v1ListenPostParametersCustomIntentVariant1 != null)
            {
                return v1ListenPostParametersCustomIntentVariant1(V1ListenPostParametersCustomIntentVariant1!);
            }
            else if (IsV1ListenPostParametersCustomIntentVariant2 && v1ListenPostParametersCustomIntentVariant2 != null)
            {
                return v1ListenPostParametersCustomIntentVariant2(V1ListenPostParametersCustomIntentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersCustomIntentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersCustomIntentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersCustomIntentVariant1)
            {
                v1ListenPostParametersCustomIntentVariant1?.Invoke(V1ListenPostParametersCustomIntentVariant1!);
            }
            else if (IsV1ListenPostParametersCustomIntentVariant2)
            {
                v1ListenPostParametersCustomIntentVariant2?.Invoke(V1ListenPostParametersCustomIntentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersCustomIntentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersCustomIntentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersCustomIntentVariant1)
            {
                v1ListenPostParametersCustomIntentVariant1?.Invoke(V1ListenPostParametersCustomIntentVariant1!);
            }
            else if (IsV1ListenPostParametersCustomIntentVariant2)
            {
                v1ListenPostParametersCustomIntentVariant2?.Invoke(V1ListenPostParametersCustomIntentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersCustomIntentVariant1,
                typeof(string),
                V1ListenPostParametersCustomIntentVariant2,
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
        public bool Equals(V1ListenPostParametersCustomIntent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersCustomIntentVariant1, other.V1ListenPostParametersCustomIntentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersCustomIntentVariant2, other.V1ListenPostParametersCustomIntentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersCustomIntent obj1, V1ListenPostParametersCustomIntent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersCustomIntent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersCustomIntent obj1, V1ListenPostParametersCustomIntent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersCustomIntent o && Equals(o);
        }
    }
}
