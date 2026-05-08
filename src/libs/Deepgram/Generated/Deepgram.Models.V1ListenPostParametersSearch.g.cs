#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersSearch : global::System.IEquatable<V1ListenPostParametersSearch>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersSearchVariant1 { get; init; }
#else
        public string? V1ListenPostParametersSearchVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersSearchVariant1))]
#endif
        public bool IsV1ListenPostParametersSearchVariant1 => V1ListenPostParametersSearchVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersSearchVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersSearchVariant1;
            return IsV1ListenPostParametersSearchVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersSearchVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersSearchVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersSearchVariant2))]
#endif
        public bool IsV1ListenPostParametersSearchVariant2 => V1ListenPostParametersSearchVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersSearchVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersSearchVariant2;
            return IsV1ListenPostParametersSearchVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersSearch(string value) => new V1ListenPostParametersSearch((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersSearch @this) => @this.V1ListenPostParametersSearchVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersSearch(string? value)
        {
            V1ListenPostParametersSearchVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersSearch(
            string? v1ListenPostParametersSearchVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersSearchVariant2
            )
        {
            V1ListenPostParametersSearchVariant1 = v1ListenPostParametersSearchVariant1;
            V1ListenPostParametersSearchVariant2 = v1ListenPostParametersSearchVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersSearchVariant2 as object ??
            V1ListenPostParametersSearchVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersSearchVariant1?.ToString() ??
            V1ListenPostParametersSearchVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersSearchVariant1 && !IsV1ListenPostParametersSearchVariant2 || !IsV1ListenPostParametersSearchVariant1 && IsV1ListenPostParametersSearchVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersSearchVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersSearchVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersSearchVariant1 && v1ListenPostParametersSearchVariant1 != null)
            {
                return v1ListenPostParametersSearchVariant1(V1ListenPostParametersSearchVariant1!);
            }
            else if (IsV1ListenPostParametersSearchVariant2 && v1ListenPostParametersSearchVariant2 != null)
            {
                return v1ListenPostParametersSearchVariant2(V1ListenPostParametersSearchVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersSearchVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersSearchVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersSearchVariant1)
            {
                v1ListenPostParametersSearchVariant1?.Invoke(V1ListenPostParametersSearchVariant1!);
            }
            else if (IsV1ListenPostParametersSearchVariant2)
            {
                v1ListenPostParametersSearchVariant2?.Invoke(V1ListenPostParametersSearchVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersSearchVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersSearchVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersSearchVariant1)
            {
                v1ListenPostParametersSearchVariant1?.Invoke(V1ListenPostParametersSearchVariant1!);
            }
            else if (IsV1ListenPostParametersSearchVariant2)
            {
                v1ListenPostParametersSearchVariant2?.Invoke(V1ListenPostParametersSearchVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersSearchVariant1,
                typeof(string),
                V1ListenPostParametersSearchVariant2,
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
        public bool Equals(V1ListenPostParametersSearch other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersSearchVariant1, other.V1ListenPostParametersSearchVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersSearchVariant2, other.V1ListenPostParametersSearchVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersSearch obj1, V1ListenPostParametersSearch obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersSearch>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersSearch obj1, V1ListenPostParametersSearch obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersSearch o && Equals(o);
        }
    }
}
