#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ReadPostParametersCustomTopic : global::System.IEquatable<V1ReadPostParametersCustomTopic>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ReadPostParametersCustomTopicVariant1 { get; init; }
#else
        public string? V1ReadPostParametersCustomTopicVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersCustomTopicVariant1))]
#endif
        public bool IsV1ReadPostParametersCustomTopicVariant1 => V1ReadPostParametersCustomTopicVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ReadPostParametersCustomTopicVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ReadPostParametersCustomTopicVariant1;
            return IsV1ReadPostParametersCustomTopicVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV1ReadPostParametersCustomTopicVariant1() => IsV1ReadPostParametersCustomTopicVariant1
            ? V1ReadPostParametersCustomTopicVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ReadPostParametersCustomTopicVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ReadPostParametersCustomTopicVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ReadPostParametersCustomTopicVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ReadPostParametersCustomTopicVariant2))]
#endif
        public bool IsV1ReadPostParametersCustomTopicVariant2 => V1ReadPostParametersCustomTopicVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ReadPostParametersCustomTopicVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ReadPostParametersCustomTopicVariant2;
            return IsV1ReadPostParametersCustomTopicVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV1ReadPostParametersCustomTopicVariant2() => IsV1ReadPostParametersCustomTopicVariant2
            ? V1ReadPostParametersCustomTopicVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V1ReadPostParametersCustomTopicVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ReadPostParametersCustomTopic(string value) => new V1ReadPostParametersCustomTopic((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ReadPostParametersCustomTopic @this) => @this.V1ReadPostParametersCustomTopicVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersCustomTopic(string? value)
        {
            V1ReadPostParametersCustomTopicVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V1ReadPostParametersCustomTopic FromV1ReadPostParametersCustomTopicVariant1(string? value) => new V1ReadPostParametersCustomTopic(value);

        /// <summary>
        /// 
        /// </summary>
        public V1ReadPostParametersCustomTopic(
            string? v1ReadPostParametersCustomTopicVariant1,
            global::System.Collections.Generic.IList<string>? v1ReadPostParametersCustomTopicVariant2
            )
        {
            V1ReadPostParametersCustomTopicVariant1 = v1ReadPostParametersCustomTopicVariant1;
            V1ReadPostParametersCustomTopicVariant2 = v1ReadPostParametersCustomTopicVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ReadPostParametersCustomTopicVariant2 as object ??
            V1ReadPostParametersCustomTopicVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ReadPostParametersCustomTopicVariant1?.ToString() ??
            V1ReadPostParametersCustomTopicVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ReadPostParametersCustomTopicVariant1 && !IsV1ReadPostParametersCustomTopicVariant2 || !IsV1ReadPostParametersCustomTopicVariant1 && IsV1ReadPostParametersCustomTopicVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ReadPostParametersCustomTopicVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ReadPostParametersCustomTopicVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersCustomTopicVariant1 && v1ReadPostParametersCustomTopicVariant1 != null)
            {
                return v1ReadPostParametersCustomTopicVariant1(V1ReadPostParametersCustomTopicVariant1!);
            }
            else if (IsV1ReadPostParametersCustomTopicVariant2 && v1ReadPostParametersCustomTopicVariant2 != null)
            {
                return v1ReadPostParametersCustomTopicVariant2(V1ReadPostParametersCustomTopicVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ReadPostParametersCustomTopicVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ReadPostParametersCustomTopicVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersCustomTopicVariant1)
            {
                v1ReadPostParametersCustomTopicVariant1?.Invoke(V1ReadPostParametersCustomTopicVariant1!);
            }
            else if (IsV1ReadPostParametersCustomTopicVariant2)
            {
                v1ReadPostParametersCustomTopicVariant2?.Invoke(V1ReadPostParametersCustomTopicVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ReadPostParametersCustomTopicVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ReadPostParametersCustomTopicVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ReadPostParametersCustomTopicVariant1)
            {
                v1ReadPostParametersCustomTopicVariant1?.Invoke(V1ReadPostParametersCustomTopicVariant1!);
            }
            else if (IsV1ReadPostParametersCustomTopicVariant2)
            {
                v1ReadPostParametersCustomTopicVariant2?.Invoke(V1ReadPostParametersCustomTopicVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ReadPostParametersCustomTopicVariant1,
                typeof(string),
                V1ReadPostParametersCustomTopicVariant2,
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
        public bool Equals(V1ReadPostParametersCustomTopic other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ReadPostParametersCustomTopicVariant1, other.V1ReadPostParametersCustomTopicVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ReadPostParametersCustomTopicVariant2, other.V1ReadPostParametersCustomTopicVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ReadPostParametersCustomTopic obj1, V1ReadPostParametersCustomTopic obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ReadPostParametersCustomTopic>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ReadPostParametersCustomTopic obj1, V1ReadPostParametersCustomTopic obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ReadPostParametersCustomTopic o && Equals(o);
        }
    }
}
