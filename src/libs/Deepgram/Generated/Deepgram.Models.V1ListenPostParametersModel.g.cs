#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersModel : global::System.IEquatable<V1ListenPostParametersModel>
    {
        /// <summary>
        /// Our public models available to all accounts
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.V1ListenPostParametersModel0? V1ListenPostParametersModel0 { get; init; }
#else
        public global::Deepgram.V1ListenPostParametersModel0? V1ListenPostParametersModel0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersModel0))]
#endif
        public bool IsV1ListenPostParametersModel0 => V1ListenPostParametersModel0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersModel0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.V1ListenPostParametersModel0? value)
        {
            value = V1ListenPostParametersModel0;
            return IsV1ListenPostParametersModel0;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? V1ListenPostParametersModelVariant2 { get; init; }
#else
        public string? V1ListenPostParametersModelVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersModelVariant2))]
#endif
        public bool IsV1ListenPostParametersModelVariant2 => V1ListenPostParametersModelVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersModelVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = V1ListenPostParametersModelVariant2;
            return IsV1ListenPostParametersModelVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersModel(global::Deepgram.V1ListenPostParametersModel0 value) => new V1ListenPostParametersModel((global::Deepgram.V1ListenPostParametersModel0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.V1ListenPostParametersModel0?(V1ListenPostParametersModel @this) => @this.V1ListenPostParametersModel0;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersModel(global::Deepgram.V1ListenPostParametersModel0? value)
        {
            V1ListenPostParametersModel0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersModel(string value) => new V1ListenPostParametersModel((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(V1ListenPostParametersModel @this) => @this.V1ListenPostParametersModelVariant2;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersModel(string? value)
        {
            V1ListenPostParametersModelVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersModel(
            global::Deepgram.V1ListenPostParametersModel0? v1ListenPostParametersModel0,
            string? v1ListenPostParametersModelVariant2
            )
        {
            V1ListenPostParametersModel0 = v1ListenPostParametersModel0;
            V1ListenPostParametersModelVariant2 = v1ListenPostParametersModelVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersModelVariant2 as object ??
            V1ListenPostParametersModel0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersModel0?.ToValueString() ??
            V1ListenPostParametersModelVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersModel0 && !IsV1ListenPostParametersModelVariant2 || !IsV1ListenPostParametersModel0 && IsV1ListenPostParametersModelVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.V1ListenPostParametersModel0?, TResult>? v1ListenPostParametersModel0 = null,
            global::System.Func<string, TResult>? v1ListenPostParametersModelVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersModel0 && v1ListenPostParametersModel0 != null)
            {
                return v1ListenPostParametersModel0(V1ListenPostParametersModel0!);
            }
            else if (IsV1ListenPostParametersModelVariant2 && v1ListenPostParametersModelVariant2 != null)
            {
                return v1ListenPostParametersModelVariant2(V1ListenPostParametersModelVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.V1ListenPostParametersModel0?>? v1ListenPostParametersModel0 = null,

            global::System.Action<string>? v1ListenPostParametersModelVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersModel0)
            {
                v1ListenPostParametersModel0?.Invoke(V1ListenPostParametersModel0!);
            }
            else if (IsV1ListenPostParametersModelVariant2)
            {
                v1ListenPostParametersModelVariant2?.Invoke(V1ListenPostParametersModelVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.V1ListenPostParametersModel0?>? v1ListenPostParametersModel0 = null,
            global::System.Action<string>? v1ListenPostParametersModelVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersModel0)
            {
                v1ListenPostParametersModel0?.Invoke(V1ListenPostParametersModel0!);
            }
            else if (IsV1ListenPostParametersModelVariant2)
            {
                v1ListenPostParametersModelVariant2?.Invoke(V1ListenPostParametersModelVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersModel0,
                typeof(global::Deepgram.V1ListenPostParametersModel0),
                V1ListenPostParametersModelVariant2,
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
        public bool Equals(V1ListenPostParametersModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.V1ListenPostParametersModel0?>.Default.Equals(V1ListenPostParametersModel0, other.V1ListenPostParametersModel0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(V1ListenPostParametersModelVariant2, other.V1ListenPostParametersModelVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersModel obj1, V1ListenPostParametersModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersModel obj1, V1ListenPostParametersModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersModel o && Equals(o);
        }
    }
}
