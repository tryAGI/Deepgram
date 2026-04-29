#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Language hints constrain and prioritize language detection for the<br/>
    /// flux-general-multi model. Pass multiple language_hint query parameters<br/>
    /// to specify multiple language codes. Empty values are rejected.<br/>
    /// Only valid when model is flux-general-multi.
    /// </summary>
    public readonly partial struct ListenV2LanguageHint : global::System.IEquatable<ListenV2LanguageHint>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ListenV2LanguageHintVariant1 { get; init; }
#else
        public string? ListenV2LanguageHintVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2LanguageHintVariant1))]
#endif
        public bool IsListenV2LanguageHintVariant1 => ListenV2LanguageHintVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ListenV2LanguageHintVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ListenV2LanguageHintVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2LanguageHintVariant2))]
#endif
        public bool IsListenV2LanguageHintVariant2 => ListenV2LanguageHintVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2LanguageHint(string value) => new ListenV2LanguageHint((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ListenV2LanguageHint @this) => @this.ListenV2LanguageHintVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2LanguageHint(string? value)
        {
            ListenV2LanguageHintVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV2LanguageHint(
            string? listenV2LanguageHintVariant1,
            global::System.Collections.Generic.IList<string>? listenV2LanguageHintVariant2
            )
        {
            ListenV2LanguageHintVariant1 = listenV2LanguageHintVariant1;
            ListenV2LanguageHintVariant2 = listenV2LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListenV2LanguageHintVariant2 as object ??
            ListenV2LanguageHintVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListenV2LanguageHintVariant1?.ToString() ??
            ListenV2LanguageHintVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListenV2LanguageHintVariant1 && !IsListenV2LanguageHintVariant2 || !IsListenV2LanguageHintVariant1 && IsListenV2LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? listenV2LanguageHintVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? listenV2LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2LanguageHintVariant1 && listenV2LanguageHintVariant1 != null)
            {
                return listenV2LanguageHintVariant1(ListenV2LanguageHintVariant1!);
            }
            else if (IsListenV2LanguageHintVariant2 && listenV2LanguageHintVariant2 != null)
            {
                return listenV2LanguageHintVariant2(ListenV2LanguageHintVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? listenV2LanguageHintVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? listenV2LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2LanguageHintVariant1)
            {
                listenV2LanguageHintVariant1?.Invoke(ListenV2LanguageHintVariant1!);
            }
            else if (IsListenV2LanguageHintVariant2)
            {
                listenV2LanguageHintVariant2?.Invoke(ListenV2LanguageHintVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenV2LanguageHintVariant1,
                typeof(string),
                ListenV2LanguageHintVariant2,
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
        public bool Equals(ListenV2LanguageHint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ListenV2LanguageHintVariant1, other.ListenV2LanguageHintVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ListenV2LanguageHintVariant2, other.ListenV2LanguageHintVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListenV2LanguageHint obj1, ListenV2LanguageHint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV2LanguageHint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListenV2LanguageHint obj1, ListenV2LanguageHint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV2LanguageHint o && Equals(o);
        }
    }
}
