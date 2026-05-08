#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersExtra : global::System.IEquatable<V1ListenPostParametersExtra>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersExtraVariant1 { get; init; }
#else
        public string? V1ListenPostParametersExtraVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersExtraVariant1))]
#endif
        public bool IsV1ListenPostParametersExtraVariant1 => V1ListenPostParametersExtraVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersExtraVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersExtraVariant1;
            return IsV1ListenPostParametersExtraVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersExtraVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersExtraVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersExtraVariant2))]
#endif
        public bool IsV1ListenPostParametersExtraVariant2 => V1ListenPostParametersExtraVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersExtraVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersExtraVariant2;
            return IsV1ListenPostParametersExtraVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersExtra(string value) => new V1ListenPostParametersExtra((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersExtra @this) => @this.V1ListenPostParametersExtraVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersExtra(string? value)
        {
            V1ListenPostParametersExtraVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersExtra(
            string? v1ListenPostParametersExtraVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersExtraVariant2
            )
        {
            V1ListenPostParametersExtraVariant1 = v1ListenPostParametersExtraVariant1;
            V1ListenPostParametersExtraVariant2 = v1ListenPostParametersExtraVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersExtraVariant2 as object ??
            V1ListenPostParametersExtraVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersExtraVariant1?.ToString() ??
            V1ListenPostParametersExtraVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersExtraVariant1 && !IsV1ListenPostParametersExtraVariant2 || !IsV1ListenPostParametersExtraVariant1 && IsV1ListenPostParametersExtraVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersExtraVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersExtraVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersExtraVariant1 && v1ListenPostParametersExtraVariant1 != null)
            {
                return v1ListenPostParametersExtraVariant1(V1ListenPostParametersExtraVariant1!);
            }
            else if (IsV1ListenPostParametersExtraVariant2 && v1ListenPostParametersExtraVariant2 != null)
            {
                return v1ListenPostParametersExtraVariant2(V1ListenPostParametersExtraVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersExtraVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersExtraVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersExtraVariant1)
            {
                v1ListenPostParametersExtraVariant1?.Invoke(V1ListenPostParametersExtraVariant1!);
            }
            else if (IsV1ListenPostParametersExtraVariant2)
            {
                v1ListenPostParametersExtraVariant2?.Invoke(V1ListenPostParametersExtraVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersExtraVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersExtraVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersExtraVariant1)
            {
                v1ListenPostParametersExtraVariant1?.Invoke(V1ListenPostParametersExtraVariant1!);
            }
            else if (IsV1ListenPostParametersExtraVariant2)
            {
                v1ListenPostParametersExtraVariant2?.Invoke(V1ListenPostParametersExtraVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersExtraVariant1,
                typeof(string),
                V1ListenPostParametersExtraVariant2,
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
        public bool Equals(V1ListenPostParametersExtra other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersExtraVariant1, other.V1ListenPostParametersExtraVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersExtraVariant2, other.V1ListenPostParametersExtraVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersExtra obj1, V1ListenPostParametersExtra obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersExtra>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersExtra obj1, V1ListenPostParametersExtra obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersExtra o && Equals(o);
        }
    }
}
