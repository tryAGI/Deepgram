#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// One or more BCP-47 language codes to bias the model toward specific languages. Only supported when model is flux-general-multi. Without hints, the model auto-detects the spoken language. See the Language Prompting guide for details.
    /// </summary>
    public readonly partial struct DeepgramListenProviderV2LanguageHint : global::System.IEquatable<DeepgramListenProviderV2LanguageHint>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DeepgramListenProviderV2LanguageHintVariant1 { get; init; }
#else
        public string? DeepgramListenProviderV2LanguageHintVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepgramListenProviderV2LanguageHintVariant1))]
#endif
        public bool IsDeepgramListenProviderV2LanguageHintVariant1 => DeepgramListenProviderV2LanguageHintVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepgramListenProviderV2LanguageHintVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DeepgramListenProviderV2LanguageHintVariant1;
            return IsDeepgramListenProviderV2LanguageHintVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickDeepgramListenProviderV2LanguageHintVariant1() => IsDeepgramListenProviderV2LanguageHintVariant1
            ? DeepgramListenProviderV2LanguageHintVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepgramListenProviderV2LanguageHintVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? DeepgramListenProviderV2LanguageHintVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? DeepgramListenProviderV2LanguageHintVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepgramListenProviderV2LanguageHintVariant2))]
#endif
        public bool IsDeepgramListenProviderV2LanguageHintVariant2 => DeepgramListenProviderV2LanguageHintVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepgramListenProviderV2LanguageHintVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = DeepgramListenProviderV2LanguageHintVariant2;
            return IsDeepgramListenProviderV2LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickDeepgramListenProviderV2LanguageHintVariant2() => IsDeepgramListenProviderV2LanguageHintVariant2
            ? DeepgramListenProviderV2LanguageHintVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepgramListenProviderV2LanguageHintVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeepgramListenProviderV2LanguageHint(string value) => new DeepgramListenProviderV2LanguageHint((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DeepgramListenProviderV2LanguageHint @this) => @this.DeepgramListenProviderV2LanguageHintVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DeepgramListenProviderV2LanguageHint(string? value)
        {
            DeepgramListenProviderV2LanguageHintVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DeepgramListenProviderV2LanguageHint FromDeepgramListenProviderV2LanguageHintVariant1(string? value) => new DeepgramListenProviderV2LanguageHint(value);

        /// <summary>
        /// 
        /// </summary>
        public DeepgramListenProviderV2LanguageHint(
            string? deepgramListenProviderV2LanguageHintVariant1,
            global::System.Collections.Generic.IList<string>? deepgramListenProviderV2LanguageHintVariant2
            )
        {
            DeepgramListenProviderV2LanguageHintVariant1 = deepgramListenProviderV2LanguageHintVariant1;
            DeepgramListenProviderV2LanguageHintVariant2 = deepgramListenProviderV2LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeepgramListenProviderV2LanguageHintVariant2 as object ??
            DeepgramListenProviderV2LanguageHintVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DeepgramListenProviderV2LanguageHintVariant1?.ToString() ??
            DeepgramListenProviderV2LanguageHintVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeepgramListenProviderV2LanguageHintVariant1 && !IsDeepgramListenProviderV2LanguageHintVariant2 || !IsDeepgramListenProviderV2LanguageHintVariant1 && IsDeepgramListenProviderV2LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? deepgramListenProviderV2LanguageHintVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? deepgramListenProviderV2LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramListenProviderV2LanguageHintVariant1 && deepgramListenProviderV2LanguageHintVariant1 != null)
            {
                return deepgramListenProviderV2LanguageHintVariant1(DeepgramListenProviderV2LanguageHintVariant1!);
            }
            else if (IsDeepgramListenProviderV2LanguageHintVariant2 && deepgramListenProviderV2LanguageHintVariant2 != null)
            {
                return deepgramListenProviderV2LanguageHintVariant2(DeepgramListenProviderV2LanguageHintVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? deepgramListenProviderV2LanguageHintVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? deepgramListenProviderV2LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramListenProviderV2LanguageHintVariant1)
            {
                deepgramListenProviderV2LanguageHintVariant1?.Invoke(DeepgramListenProviderV2LanguageHintVariant1!);
            }
            else if (IsDeepgramListenProviderV2LanguageHintVariant2)
            {
                deepgramListenProviderV2LanguageHintVariant2?.Invoke(DeepgramListenProviderV2LanguageHintVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? deepgramListenProviderV2LanguageHintVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? deepgramListenProviderV2LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramListenProviderV2LanguageHintVariant1)
            {
                deepgramListenProviderV2LanguageHintVariant1?.Invoke(DeepgramListenProviderV2LanguageHintVariant1!);
            }
            else if (IsDeepgramListenProviderV2LanguageHintVariant2)
            {
                deepgramListenProviderV2LanguageHintVariant2?.Invoke(DeepgramListenProviderV2LanguageHintVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeepgramListenProviderV2LanguageHintVariant1,
                typeof(string),
                DeepgramListenProviderV2LanguageHintVariant2,
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
        public bool Equals(DeepgramListenProviderV2LanguageHint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DeepgramListenProviderV2LanguageHintVariant1, other.DeepgramListenProviderV2LanguageHintVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(DeepgramListenProviderV2LanguageHintVariant2, other.DeepgramListenProviderV2LanguageHintVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DeepgramListenProviderV2LanguageHint obj1, DeepgramListenProviderV2LanguageHint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeepgramListenProviderV2LanguageHint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DeepgramListenProviderV2LanguageHint obj1, DeepgramListenProviderV2LanguageHint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeepgramListenProviderV2LanguageHint o && Equals(o);
        }
    }
}
