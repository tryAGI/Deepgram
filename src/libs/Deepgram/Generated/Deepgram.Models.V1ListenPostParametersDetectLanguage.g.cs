#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V1ListenPostParametersDetectLanguage : global::System.IEquatable<V1ListenPostParametersDetectLanguage>
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? V1ListenPostParametersDetectLanguageVariant1 { get; init; }
#else
        public bool? V1ListenPostParametersDetectLanguageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersDetectLanguageVariant1))]
#endif
        public bool IsV1ListenPostParametersDetectLanguageVariant1 => V1ListenPostParametersDetectLanguageVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersDetectLanguageVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = V1ListenPostParametersDetectLanguageVariant1;
            return IsV1ListenPostParametersDetectLanguageVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersDetectLanguageVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? V1ListenPostParametersDetectLanguageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V1ListenPostParametersDetectLanguageVariant2))]
#endif
        public bool IsV1ListenPostParametersDetectLanguageVariant2 => V1ListenPostParametersDetectLanguageVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV1ListenPostParametersDetectLanguageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = V1ListenPostParametersDetectLanguageVariant2;
            return IsV1ListenPostParametersDetectLanguageVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V1ListenPostParametersDetectLanguage(bool value) => new V1ListenPostParametersDetectLanguage((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(V1ListenPostParametersDetectLanguage @this) => @this.V1ListenPostParametersDetectLanguageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersDetectLanguage(bool? value)
        {
            V1ListenPostParametersDetectLanguageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public V1ListenPostParametersDetectLanguage(
            bool? v1ListenPostParametersDetectLanguageVariant1,
            global::System.Collections.Generic.IList<string>? v1ListenPostParametersDetectLanguageVariant2
            )
        {
            V1ListenPostParametersDetectLanguageVariant1 = v1ListenPostParametersDetectLanguageVariant1;
            V1ListenPostParametersDetectLanguageVariant2 = v1ListenPostParametersDetectLanguageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            V1ListenPostParametersDetectLanguageVariant2 as object ??
            V1ListenPostParametersDetectLanguageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            V1ListenPostParametersDetectLanguageVariant1?.ToString().ToLowerInvariant() ??
            V1ListenPostParametersDetectLanguageVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsV1ListenPostParametersDetectLanguageVariant1 && !IsV1ListenPostParametersDetectLanguageVariant2 || !IsV1ListenPostParametersDetectLanguageVariant1 && IsV1ListenPostParametersDetectLanguageVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? v1ListenPostParametersDetectLanguageVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? v1ListenPostParametersDetectLanguageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersDetectLanguageVariant1 && v1ListenPostParametersDetectLanguageVariant1 != null)
            {
                return v1ListenPostParametersDetectLanguageVariant1(V1ListenPostParametersDetectLanguageVariant1!);
            }
            else if (IsV1ListenPostParametersDetectLanguageVariant2 && v1ListenPostParametersDetectLanguageVariant2 != null)
            {
                return v1ListenPostParametersDetectLanguageVariant2(V1ListenPostParametersDetectLanguageVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? v1ListenPostParametersDetectLanguageVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersDetectLanguageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersDetectLanguageVariant1)
            {
                v1ListenPostParametersDetectLanguageVariant1?.Invoke(V1ListenPostParametersDetectLanguageVariant1!);
            }
            else if (IsV1ListenPostParametersDetectLanguageVariant2)
            {
                v1ListenPostParametersDetectLanguageVariant2?.Invoke(V1ListenPostParametersDetectLanguageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<bool?>? v1ListenPostParametersDetectLanguageVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? v1ListenPostParametersDetectLanguageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsV1ListenPostParametersDetectLanguageVariant1)
            {
                v1ListenPostParametersDetectLanguageVariant1?.Invoke(V1ListenPostParametersDetectLanguageVariant1!);
            }
            else if (IsV1ListenPostParametersDetectLanguageVariant2)
            {
                v1ListenPostParametersDetectLanguageVariant2?.Invoke(V1ListenPostParametersDetectLanguageVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                V1ListenPostParametersDetectLanguageVariant1,
                typeof(bool),
                V1ListenPostParametersDetectLanguageVariant2,
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
        public bool Equals(V1ListenPostParametersDetectLanguage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(V1ListenPostParametersDetectLanguageVariant1, other.V1ListenPostParametersDetectLanguageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(V1ListenPostParametersDetectLanguageVariant2, other.V1ListenPostParametersDetectLanguageVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V1ListenPostParametersDetectLanguage obj1, V1ListenPostParametersDetectLanguage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1ListenPostParametersDetectLanguage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V1ListenPostParametersDetectLanguage obj1, V1ListenPostParametersDetectLanguage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1ListenPostParametersDetectLanguage o && Equals(o);
        }
    }
}
