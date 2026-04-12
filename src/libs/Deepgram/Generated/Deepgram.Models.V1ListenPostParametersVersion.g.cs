#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersVersion : global::System.IEquatable<V1ListenPostParametersVersion>
    {
        /// <summary>
        /// Use the latest version of a model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1ListenPostParametersVersion0? V1ListenPostParametersVersion0 { get; init; }
#else
        public global::Deepgram.V1ListenPostParametersVersion0? V1ListenPostParametersVersion0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersVersion0))]
#endif
        public bool IsV1ListenPostParametersVersion0 => V1ListenPostParametersVersion0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersVersionVariant2 { get; init; }
#else
        public string? V1ListenPostParametersVersionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersVersionVariant2))]
#endif
        public bool IsV1ListenPostParametersVersionVariant2 => V1ListenPostParametersVersionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersVersion(global::Deepgram.V1ListenPostParametersVersion0 value) => new V1ListenPostParametersVersion((global::Deepgram.V1ListenPostParametersVersion0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1ListenPostParametersVersion0?(V1ListenPostParametersVersion @this) => @this.V1ListenPostParametersVersion0;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersVersion(global::Deepgram.V1ListenPostParametersVersion0? value)
        {
            V1ListenPostParametersVersion0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersVersion(string value) => new V1ListenPostParametersVersion((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersVersion @this) => @this.V1ListenPostParametersVersionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersVersion(string? value)
        {
            V1ListenPostParametersVersionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersVersion(
            global::Deepgram.V1ListenPostParametersVersion0? v1ListenPostParametersVersion0,
            string? v1ListenPostParametersVersionVariant2
            )
        {
            V1ListenPostParametersVersion0 = v1ListenPostParametersVersion0;
            V1ListenPostParametersVersionVariant2 = v1ListenPostParametersVersionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersVersionVariant2 as object ??
            V1ListenPostParametersVersion0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersVersion0?.ToValueString() ??
            V1ListenPostParametersVersionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersVersion0 && !IsV1ListenPostParametersVersionVariant2 || !IsV1ListenPostParametersVersion0 && IsV1ListenPostParametersVersionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1ListenPostParametersVersion0?, TResult>? v1ListenPostParametersVersion0 = null,
            global::System.Func<string?, TResult>? v1ListenPostParametersVersionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersVersion0 && v1ListenPostParametersVersion0 != null)
            {
                return v1ListenPostParametersVersion0(V1ListenPostParametersVersion0!);
            }
            else if (IsV1ListenPostParametersVersionVariant2 && v1ListenPostParametersVersionVariant2 != null)
            {
                return v1ListenPostParametersVersionVariant2(V1ListenPostParametersVersionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1ListenPostParametersVersion0?>? v1ListenPostParametersVersion0 = null,
            global::System.Action<string?>? v1ListenPostParametersVersionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersVersion0)
            {
                v1ListenPostParametersVersion0?.Invoke(V1ListenPostParametersVersion0!);
            }
            else if (IsV1ListenPostParametersVersionVariant2)
            {
                v1ListenPostParametersVersionVariant2?.Invoke(V1ListenPostParametersVersionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersVersion0,
                typeof(global::Deepgram.V1ListenPostParametersVersion0),
                V1ListenPostParametersVersionVariant2,
                typeof(string),
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
        public bool Equals(V1ListenPostParametersVersion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1ListenPostParametersVersion0?>.Default.Equals(V1ListenPostParametersVersion0, other.V1ListenPostParametersVersion0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersVersionVariant2, other.V1ListenPostParametersVersionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersVersion obj1, V1ListenPostParametersVersion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersVersion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersVersion obj1, V1ListenPostParametersVersion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersVersion o && Equals(o);
        }
    }
}
