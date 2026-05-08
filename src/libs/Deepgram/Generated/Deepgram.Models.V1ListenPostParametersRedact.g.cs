#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersRedact : global::System.IEquatable<V1ListenPostParametersRedact>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersRedactVariant1 { get; init; }
#else
        public string? V1ListenPostParametersRedactVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersRedactVariant1))]
#endif
        public bool IsV1ListenPostParametersRedactVariant1 => V1ListenPostParametersRedactVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersRedactVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersRedactVariant1;
            return IsV1ListenPostParametersRedactVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>? V1ListenPostParametersRedact1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>? V1ListenPostParametersRedact1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersRedact1))]
#endif
        public bool IsV1ListenPostParametersRedact1 => V1ListenPostParametersRedact1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersRedact1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>? value)
        {
            value = V1ListenPostParametersRedact1;
            return IsV1ListenPostParametersRedact1;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersRedact(string value) => new V1ListenPostParametersRedact((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersRedact @this) => @this.V1ListenPostParametersRedactVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersRedact(string? value)
        {
            V1ListenPostParametersRedactVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersRedact(
            string? v1ListenPostParametersRedactVariant1,
            global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>? v1ListenPostParametersRedact1
            )
        {
            V1ListenPostParametersRedactVariant1 = v1ListenPostParametersRedactVariant1;
            V1ListenPostParametersRedact1 = v1ListenPostParametersRedact1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersRedact1 as object ??
            V1ListenPostParametersRedactVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersRedactVariant1?.ToString() ??
            V1ListenPostParametersRedact1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersRedactVariant1 && !IsV1ListenPostParametersRedact1 || !IsV1ListenPostParametersRedactVariant1 && IsV1ListenPostParametersRedact1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? v1ListenPostParametersRedactVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>, TResult>? v1ListenPostParametersRedact1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersRedactVariant1 && v1ListenPostParametersRedactVariant1 != null)
            {
                return v1ListenPostParametersRedactVariant1(V1ListenPostParametersRedactVariant1!);
            }
            else if (IsV1ListenPostParametersRedact1 && v1ListenPostParametersRedact1 != null)
            {
                return v1ListenPostParametersRedact1(V1ListenPostParametersRedact1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? v1ListenPostParametersRedactVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>>? v1ListenPostParametersRedact1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersRedactVariant1)
            {
                v1ListenPostParametersRedactVariant1?.Invoke(V1ListenPostParametersRedactVariant1!);
            }
            else if (IsV1ListenPostParametersRedact1)
            {
                v1ListenPostParametersRedact1?.Invoke(V1ListenPostParametersRedact1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? v1ListenPostParametersRedactVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>>? v1ListenPostParametersRedact1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersRedactVariant1)
            {
                v1ListenPostParametersRedactVariant1?.Invoke(V1ListenPostParametersRedactVariant1!);
            }
            else if (IsV1ListenPostParametersRedact1)
            {
                v1ListenPostParametersRedact1?.Invoke(V1ListenPostParametersRedact1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersRedactVariant1,
                typeof(string),
                V1ListenPostParametersRedact1,
                typeof(global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>),
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
        public bool Equals(V1ListenPostParametersRedact other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersRedactVariant1, other.V1ListenPostParametersRedactVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>?>.Default.Equals(V1ListenPostParametersRedact1, other.V1ListenPostParametersRedact1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersRedact obj1, V1ListenPostParametersRedact obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersRedact>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersRedact obj1, V1ListenPostParametersRedact obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersRedact o && Equals(o);
        }
    }
}
