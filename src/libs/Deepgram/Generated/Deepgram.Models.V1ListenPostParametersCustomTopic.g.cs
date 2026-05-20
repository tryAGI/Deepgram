#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersCustomTopic : global::System.IEquatable<V1ListenPostParametersCustomTopic>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersCustomTopicVariant1 { get; init; }
#else
        public string? V1ListenPostParametersCustomTopicVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersCustomTopicVariant1))]
#endif
        public bool IsV1ListenPostParametersCustomTopicVariant1 => V1ListenPostParametersCustomTopicVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersCustomTopicVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersCustomTopicVariant1;
            return IsV1ListenPostParametersCustomTopicVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ListenPostParametersCustomTopicVariant1() => IsV1ListenPostParametersCustomTopicVariant1
            ? V1ListenPostParametersCustomTopicVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersCustomTopicVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersCustomTopicVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersCustomTopicVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersCustomTopicVariant2))]
#endif
        public bool IsV1ListenPostParametersCustomTopicVariant2 => V1ListenPostParametersCustomTopicVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersCustomTopicVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersCustomTopicVariant2;
            return IsV1ListenPostParametersCustomTopicVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ListenPostParametersCustomTopicVariant2() => IsV1ListenPostParametersCustomTopicVariant2
            ? V1ListenPostParametersCustomTopicVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ListenPostParametersCustomTopicVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersCustomTopic(string value) => new V1ListenPostParametersCustomTopic((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersCustomTopic @this) => @this.V1ListenPostParametersCustomTopicVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersCustomTopic(string? value)
        {
            V1ListenPostParametersCustomTopicVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ListenPostParametersCustomTopic FromV1ListenPostParametersCustomTopicVariant1(string? value) => new V1ListenPostParametersCustomTopic(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersCustomTopic(
            string? v1ListenPostParametersCustomTopicVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersCustomTopicVariant2
            )
        {
            V1ListenPostParametersCustomTopicVariant1 = v1ListenPostParametersCustomTopicVariant1;
            V1ListenPostParametersCustomTopicVariant2 = v1ListenPostParametersCustomTopicVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersCustomTopicVariant2 as object ??
            V1ListenPostParametersCustomTopicVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersCustomTopicVariant1?.ToString() ??
            V1ListenPostParametersCustomTopicVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersCustomTopicVariant1 && !IsV1ListenPostParametersCustomTopicVariant2 || !IsV1ListenPostParametersCustomTopicVariant1 && IsV1ListenPostParametersCustomTopicVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersCustomTopicVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersCustomTopicVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersCustomTopicVariant1 && v1ListenPostParametersCustomTopicVariant1 != null)
            {
                return v1ListenPostParametersCustomTopicVariant1(V1ListenPostParametersCustomTopicVariant1!);
            }
            else if (IsV1ListenPostParametersCustomTopicVariant2 && v1ListenPostParametersCustomTopicVariant2 != null)
            {
                return v1ListenPostParametersCustomTopicVariant2(V1ListenPostParametersCustomTopicVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersCustomTopicVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersCustomTopicVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersCustomTopicVariant1)
            {
                v1ListenPostParametersCustomTopicVariant1?.Invoke(V1ListenPostParametersCustomTopicVariant1!);
            }
            else if (IsV1ListenPostParametersCustomTopicVariant2)
            {
                v1ListenPostParametersCustomTopicVariant2?.Invoke(V1ListenPostParametersCustomTopicVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersCustomTopicVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersCustomTopicVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersCustomTopicVariant1)
            {
                v1ListenPostParametersCustomTopicVariant1?.Invoke(V1ListenPostParametersCustomTopicVariant1!);
            }
            else if (IsV1ListenPostParametersCustomTopicVariant2)
            {
                v1ListenPostParametersCustomTopicVariant2?.Invoke(V1ListenPostParametersCustomTopicVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersCustomTopicVariant1,
                typeof(string),
                V1ListenPostParametersCustomTopicVariant2,
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
        public bool Equals(V1ListenPostParametersCustomTopic other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersCustomTopicVariant1, other.V1ListenPostParametersCustomTopicVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersCustomTopicVariant2, other.V1ListenPostParametersCustomTopicVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersCustomTopic obj1, V1ListenPostParametersCustomTopic obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersCustomTopic>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersCustomTopic obj1, V1ListenPostParametersCustomTopic obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersCustomTopic o && Equals(o);
        }
    }
}
