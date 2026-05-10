#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ReadPostParametersCustomIntent : global::System.IEquatable<V1ReadPostParametersCustomIntent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ReadPostParametersCustomIntentVariant1 { get; init; }
#else
        public string? V1ReadPostParametersCustomIntentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersCustomIntentVariant1))]
#endif
        public bool IsV1ReadPostParametersCustomIntentVariant1 => V1ReadPostParametersCustomIntentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ReadPostParametersCustomIntentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ReadPostParametersCustomIntentVariant1;
            return IsV1ReadPostParametersCustomIntentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ReadPostParametersCustomIntentVariant1() => IsV1ReadPostParametersCustomIntentVariant1
            ? V1ReadPostParametersCustomIntentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ReadPostParametersCustomIntentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ReadPostParametersCustomIntentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ReadPostParametersCustomIntentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersCustomIntentVariant2))]
#endif
        public bool IsV1ReadPostParametersCustomIntentVariant2 => V1ReadPostParametersCustomIntentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ReadPostParametersCustomIntentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ReadPostParametersCustomIntentVariant2;
            return IsV1ReadPostParametersCustomIntentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ReadPostParametersCustomIntentVariant2() => IsV1ReadPostParametersCustomIntentVariant2
            ? V1ReadPostParametersCustomIntentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ReadPostParametersCustomIntentVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ReadPostParametersCustomIntent(string value) => new V1ReadPostParametersCustomIntent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ReadPostParametersCustomIntent @this) => @this.V1ReadPostParametersCustomIntentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersCustomIntent(string? value)
        {
            V1ReadPostParametersCustomIntentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ReadPostParametersCustomIntent FromV1ReadPostParametersCustomIntentVariant1(string? value) => new V1ReadPostParametersCustomIntent(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersCustomIntent(
            string? v1ReadPostParametersCustomIntentVariant1,
            global::System.Collections.Generic.IList<string>? v1ReadPostParametersCustomIntentVariant2
            )
        {
            V1ReadPostParametersCustomIntentVariant1 = v1ReadPostParametersCustomIntentVariant1;
            V1ReadPostParametersCustomIntentVariant2 = v1ReadPostParametersCustomIntentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ReadPostParametersCustomIntentVariant2 as object ??
            V1ReadPostParametersCustomIntentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ReadPostParametersCustomIntentVariant1?.ToString() ??
            V1ReadPostParametersCustomIntentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ReadPostParametersCustomIntentVariant1 && !IsV1ReadPostParametersCustomIntentVariant2 || !IsV1ReadPostParametersCustomIntentVariant1 && IsV1ReadPostParametersCustomIntentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ReadPostParametersCustomIntentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ReadPostParametersCustomIntentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersCustomIntentVariant1 && v1ReadPostParametersCustomIntentVariant1 != null)
            {
                return v1ReadPostParametersCustomIntentVariant1(V1ReadPostParametersCustomIntentVariant1!);
            }
            else if (IsV1ReadPostParametersCustomIntentVariant2 && v1ReadPostParametersCustomIntentVariant2 != null)
            {
                return v1ReadPostParametersCustomIntentVariant2(V1ReadPostParametersCustomIntentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ReadPostParametersCustomIntentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ReadPostParametersCustomIntentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersCustomIntentVariant1)
            {
                v1ReadPostParametersCustomIntentVariant1?.Invoke(V1ReadPostParametersCustomIntentVariant1!);
            }
            else if (IsV1ReadPostParametersCustomIntentVariant2)
            {
                v1ReadPostParametersCustomIntentVariant2?.Invoke(V1ReadPostParametersCustomIntentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ReadPostParametersCustomIntentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ReadPostParametersCustomIntentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersCustomIntentVariant1)
            {
                v1ReadPostParametersCustomIntentVariant1?.Invoke(V1ReadPostParametersCustomIntentVariant1!);
            }
            else if (IsV1ReadPostParametersCustomIntentVariant2)
            {
                v1ReadPostParametersCustomIntentVariant2?.Invoke(V1ReadPostParametersCustomIntentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ReadPostParametersCustomIntentVariant1,
                typeof(string),
                V1ReadPostParametersCustomIntentVariant2,
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
        public bool Equals(V1ReadPostParametersCustomIntent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ReadPostParametersCustomIntentVariant1, other.V1ReadPostParametersCustomIntentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ReadPostParametersCustomIntentVariant2, other.V1ReadPostParametersCustomIntentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ReadPostParametersCustomIntent obj1, V1ReadPostParametersCustomIntent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ReadPostParametersCustomIntent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ReadPostParametersCustomIntent obj1, V1ReadPostParametersCustomIntent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ReadPostParametersCustomIntent o && Equals(o);
        }
    }
}
