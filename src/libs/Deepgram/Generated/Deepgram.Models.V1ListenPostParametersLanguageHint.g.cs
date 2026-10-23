#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct V1ListenPostParametersLanguageHint : global::System.IEquatable<V1ListenPostParametersLanguageHint>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersLanguageHintVariant1 { get; init; }
#else
        public string? V1ListenPostParametersLanguageHintVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersLanguageHintVariant1))]
#endif
        public bool IsV1ListenPostParametersLanguageHintVariant1 => V1ListenPostParametersLanguageHintVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickV1ListenPostParametersLanguageHintVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersLanguageHintVariant1;
            return IsV1ListenPostParametersLanguageHintVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickV1ListenPostParametersLanguageHintVariant1() => V1ListenPostParametersLanguageHintVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersLanguageHintVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersLanguageHintVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersLanguageHintVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersLanguageHintVariant2))]
#endif
        public bool IsV1ListenPostParametersLanguageHintVariant2 => V1ListenPostParametersLanguageHintVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickV1ListenPostParametersLanguageHintVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersLanguageHintVariant2;
            return IsV1ListenPostParametersLanguageHintVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ListenPostParametersLanguageHintVariant2() => V1ListenPostParametersLanguageHintVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersLanguageHintVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator V1ListenPostParametersLanguageHint(string value) => new V1ListenPostParametersLanguageHint((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersLanguageHint @this) => @this.V1ListenPostParametersLanguageHintVariant1;

        /// <summary>
        ///
        /// </summary>
        public V1ListenPostParametersLanguageHint(string? value)
        {
            V1ListenPostParametersLanguageHintVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V1ListenPostParametersLanguageHint FromV1ListenPostParametersLanguageHintVariant1(string? value) => new V1ListenPostParametersLanguageHint(value);

        /// <summary>
        ///
        /// </summary>
        public V1ListenPostParametersLanguageHint(
            string? v1ListenPostParametersLanguageHintVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersLanguageHintVariant2
            )
        {
            V1ListenPostParametersLanguageHintVariant1 = v1ListenPostParametersLanguageHintVariant1;
            V1ListenPostParametersLanguageHintVariant2 = v1ListenPostParametersLanguageHintVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            V1ListenPostParametersLanguageHintVariant2 as object ??
            V1ListenPostParametersLanguageHintVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersLanguageHintVariant1?.ToString() ??
            V1ListenPostParametersLanguageHintVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersLanguageHintVariant1 && !IsV1ListenPostParametersLanguageHintVariant2 || !IsV1ListenPostParametersLanguageHintVariant1 && IsV1ListenPostParametersLanguageHintVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersLanguageHintVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersLanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (V1ListenPostParametersLanguageHintVariant1 is { } __value0 && v1ListenPostParametersLanguageHintVariant1 != null)
            {
                return v1ListenPostParametersLanguageHintVariant1(__value0);
            }
            else if (V1ListenPostParametersLanguageHintVariant2 is { } __value1 && v1ListenPostParametersLanguageHintVariant2 != null)
            {
                return v1ListenPostParametersLanguageHintVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersLanguageHintVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersLanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (V1ListenPostParametersLanguageHintVariant1 is { } __value0)
            {
                v1ListenPostParametersLanguageHintVariant1?.Invoke(__value0);
            }
            else if (V1ListenPostParametersLanguageHintVariant2 is { } __value1)
            {
                v1ListenPostParametersLanguageHintVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersLanguageHintVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersLanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (V1ListenPostParametersLanguageHintVariant1 is { } __value0)
            {
                v1ListenPostParametersLanguageHintVariant1?.Invoke(__value0);
            }
            else if (V1ListenPostParametersLanguageHintVariant2 is { } __value1)
            {
                v1ListenPostParametersLanguageHintVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersLanguageHintVariant1,
                typeof(string),
                V1ListenPostParametersLanguageHintVariant2,
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
        public bool Equals(V1ListenPostParametersLanguageHint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersLanguageHintVariant1, other.V1ListenPostParametersLanguageHintVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersLanguageHintVariant2, other.V1ListenPostParametersLanguageHintVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(V1ListenPostParametersLanguageHint obj1, V1ListenPostParametersLanguageHint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersLanguageHint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(V1ListenPostParametersLanguageHint obj1, V1ListenPostParametersLanguageHint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersLanguageHint o && Equals(o);
        }
    }
}
