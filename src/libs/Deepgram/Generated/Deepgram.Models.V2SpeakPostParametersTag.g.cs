#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2SpeakPostParametersTag : global::System.IEquatable<V2SpeakPostParametersTag>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V2SpeakPostParametersTagVariant1 { get; init; }
#else
        public string? V2SpeakPostParametersTagVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersTagVariant1))]
#endif
        public bool IsV2SpeakPostParametersTagVariant1 => V2SpeakPostParametersTagVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersTagVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V2SpeakPostParametersTagVariant1;
            return IsV2SpeakPostParametersTagVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickV2SpeakPostParametersTagVariant1() => IsV2SpeakPostParametersTagVariant1
            ? V2SpeakPostParametersTagVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersTagVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V2SpeakPostParametersTagVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V2SpeakPostParametersTagVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2SpeakPostParametersTagVariant2))]
#endif
        public bool IsV2SpeakPostParametersTagVariant2 => V2SpeakPostParametersTagVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2SpeakPostParametersTagVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V2SpeakPostParametersTagVariant2;
            return IsV2SpeakPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickV2SpeakPostParametersTagVariant2() => IsV2SpeakPostParametersTagVariant2
            ? V2SpeakPostParametersTagVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2SpeakPostParametersTagVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2SpeakPostParametersTag(string value) => new V2SpeakPostParametersTag((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V2SpeakPostParametersTag @this) => @this.V2SpeakPostParametersTagVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersTag(string? value)
        {
            V2SpeakPostParametersTagVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2SpeakPostParametersTag FromV2SpeakPostParametersTagVariant1(string? value) => new V2SpeakPostParametersTag(value);

        /// <summary>
        /// 
        /// </summary>
        public V2SpeakPostParametersTag(
            string? v2SpeakPostParametersTagVariant1,
            global::System.Collections.Generic.IList<string>? v2SpeakPostParametersTagVariant2
            )
        {
            V2SpeakPostParametersTagVariant1 = v2SpeakPostParametersTagVariant1;
            V2SpeakPostParametersTagVariant2 = v2SpeakPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V2SpeakPostParametersTagVariant2 as object ??
            V2SpeakPostParametersTagVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V2SpeakPostParametersTagVariant1?.ToString() ??
            V2SpeakPostParametersTagVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV2SpeakPostParametersTagVariant1 && !IsV2SpeakPostParametersTagVariant2 || !IsV2SpeakPostParametersTagVariant1 && IsV2SpeakPostParametersTagVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v2SpeakPostParametersTagVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v2SpeakPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersTagVariant1 && v2SpeakPostParametersTagVariant1 != null)
            {
                return v2SpeakPostParametersTagVariant1(V2SpeakPostParametersTagVariant1!);
            }
            else if (IsV2SpeakPostParametersTagVariant2 && v2SpeakPostParametersTagVariant2 != null)
            {
                return v2SpeakPostParametersTagVariant2(V2SpeakPostParametersTagVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v2SpeakPostParametersTagVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v2SpeakPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersTagVariant1)
            {
                v2SpeakPostParametersTagVariant1?.Invoke(V2SpeakPostParametersTagVariant1!);
            }
            else if (IsV2SpeakPostParametersTagVariant2)
            {
                v2SpeakPostParametersTagVariant2?.Invoke(V2SpeakPostParametersTagVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v2SpeakPostParametersTagVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v2SpeakPostParametersTagVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV2SpeakPostParametersTagVariant1)
            {
                v2SpeakPostParametersTagVariant1?.Invoke(V2SpeakPostParametersTagVariant1!);
            }
            else if (IsV2SpeakPostParametersTagVariant2)
            {
                v2SpeakPostParametersTagVariant2?.Invoke(V2SpeakPostParametersTagVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V2SpeakPostParametersTagVariant1,
                typeof(string),
                V2SpeakPostParametersTagVariant2,
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
        public bool Equals(V2SpeakPostParametersTag other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V2SpeakPostParametersTagVariant1, other.V2SpeakPostParametersTagVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V2SpeakPostParametersTagVariant2, other.V2SpeakPostParametersTagVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2SpeakPostParametersTag obj1, V2SpeakPostParametersTag obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2SpeakPostParametersTag>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2SpeakPostParametersTag obj1, V2SpeakPostParametersTag obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2SpeakPostParametersTag o && Equals(o);
        }
    }
}
