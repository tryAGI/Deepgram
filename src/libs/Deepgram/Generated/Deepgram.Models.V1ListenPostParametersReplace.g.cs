#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersReplace : global::System.IEquatable<V1ListenPostParametersReplace>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersReplaceVariant1 { get; init; }
#else
        public string? V1ListenPostParametersReplaceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersReplaceVariant1))]
#endif
        public bool IsV1ListenPostParametersReplaceVariant1 => V1ListenPostParametersReplaceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersReplaceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersReplaceVariant1;
            return IsV1ListenPostParametersReplaceVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ListenPostParametersReplaceVariant1() => IsV1ListenPostParametersReplaceVariant1
            ? V1ListenPostParametersReplaceVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersReplaceVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersReplaceVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersReplaceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersReplaceVariant2))]
#endif
        public bool IsV1ListenPostParametersReplaceVariant2 => V1ListenPostParametersReplaceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersReplaceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersReplaceVariant2;
            return IsV1ListenPostParametersReplaceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ListenPostParametersReplaceVariant2() => IsV1ListenPostParametersReplaceVariant2
            ? V1ListenPostParametersReplaceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersReplaceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersReplace(string value) => new V1ListenPostParametersReplace((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersReplace @this) => @this.V1ListenPostParametersReplaceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersReplace(string? value)
        {
            V1ListenPostParametersReplaceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ListenPostParametersReplace FromV1ListenPostParametersReplaceVariant1(string? value) => new V1ListenPostParametersReplace(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersReplace(
            string? v1ListenPostParametersReplaceVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersReplaceVariant2
            )
        {
            V1ListenPostParametersReplaceVariant1 = v1ListenPostParametersReplaceVariant1;
            V1ListenPostParametersReplaceVariant2 = v1ListenPostParametersReplaceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersReplaceVariant2 as object ??
            V1ListenPostParametersReplaceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersReplaceVariant1?.ToString() ??
            V1ListenPostParametersReplaceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersReplaceVariant1 && !IsV1ListenPostParametersReplaceVariant2 || !IsV1ListenPostParametersReplaceVariant1 && IsV1ListenPostParametersReplaceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersReplaceVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersReplaceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersReplaceVariant1 && v1ListenPostParametersReplaceVariant1 != null)
            {
                return v1ListenPostParametersReplaceVariant1(V1ListenPostParametersReplaceVariant1!);
            }
            else if (IsV1ListenPostParametersReplaceVariant2 && v1ListenPostParametersReplaceVariant2 != null)
            {
                return v1ListenPostParametersReplaceVariant2(V1ListenPostParametersReplaceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersReplaceVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersReplaceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersReplaceVariant1)
            {
                v1ListenPostParametersReplaceVariant1?.Invoke(V1ListenPostParametersReplaceVariant1!);
            }
            else if (IsV1ListenPostParametersReplaceVariant2)
            {
                v1ListenPostParametersReplaceVariant2?.Invoke(V1ListenPostParametersReplaceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersReplaceVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersReplaceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersReplaceVariant1)
            {
                v1ListenPostParametersReplaceVariant1?.Invoke(V1ListenPostParametersReplaceVariant1!);
            }
            else if (IsV1ListenPostParametersReplaceVariant2)
            {
                v1ListenPostParametersReplaceVariant2?.Invoke(V1ListenPostParametersReplaceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersReplaceVariant1,
                typeof(string),
                V1ListenPostParametersReplaceVariant2,
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
        public bool Equals(V1ListenPostParametersReplace other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersReplaceVariant1, other.V1ListenPostParametersReplaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersReplaceVariant2, other.V1ListenPostParametersReplaceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersReplace obj1, V1ListenPostParametersReplace obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersReplace>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersReplace obj1, V1ListenPostParametersReplace obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersReplace o && Equals(o);
        }
    }
}
