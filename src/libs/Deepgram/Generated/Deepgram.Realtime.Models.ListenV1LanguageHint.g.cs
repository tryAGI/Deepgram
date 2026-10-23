#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Biases language detection toward one or more languages on Nova-3 multilingual (`model=nova-3&amp;language=multi`); ignored with any other `language`. Repeat the parameter to pass several codes, for example `language_hint=en&amp;language_hint=es`. A code that is not in the [Nova-3 multilingual list](/docs/models-languages-overview#nova-3) rejects the WebSocket connection with HTTP 400. See [Nova-3 Language Prompting](/docs/nova-3-language-prompting).
    /// </summary>
    public readonly partial struct ListenV1LanguageHint : global::System.IEquatable<ListenV1LanguageHint>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ListenV1LanguageHintVariant1 { get; init; }
#else
        public string? ListenV1LanguageHintVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1LanguageHintVariant1))]
#endif
        public bool IsListenV1LanguageHintVariant1 => ListenV1LanguageHintVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListenV1LanguageHintVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ListenV1LanguageHintVariant1;
            return IsListenV1LanguageHintVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickListenV1LanguageHintVariant1() => ListenV1LanguageHintVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1LanguageHintVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ListenV1LanguageHintVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ListenV1LanguageHintVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1LanguageHintVariant2))]
#endif
        public bool IsListenV1LanguageHintVariant2 => ListenV1LanguageHintVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListenV1LanguageHintVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = ListenV1LanguageHintVariant2;
            return IsListenV1LanguageHintVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickListenV1LanguageHintVariant2() => ListenV1LanguageHintVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV1LanguageHintVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListenV1LanguageHint(string value) => new ListenV1LanguageHint((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ListenV1LanguageHint @this) => @this.ListenV1LanguageHintVariant1;

        /// <summary>
        ///
        /// </summary>
        public ListenV1LanguageHint(string? value)
        {
            ListenV1LanguageHintVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListenV1LanguageHint FromListenV1LanguageHintVariant1(string? value) => new ListenV1LanguageHint(value);

        /// <summary>
        ///
        /// </summary>
        public ListenV1LanguageHint(
            string? listenV1LanguageHintVariant1,
            global::System.Collections.Generic.IList<string>? listenV1LanguageHintVariant2
            )
        {
            ListenV1LanguageHintVariant1 = listenV1LanguageHintVariant1;
            ListenV1LanguageHintVariant2 = listenV1LanguageHintVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListenV1LanguageHintVariant2 as object ??
            ListenV1LanguageHintVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ListenV1LanguageHintVariant1?.ToString() ??
            ListenV1LanguageHintVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsListenV1LanguageHintVariant1 && !IsListenV1LanguageHintVariant2 || !IsListenV1LanguageHintVariant1 && IsListenV1LanguageHintVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? listenV1LanguageHintVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? listenV1LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV1LanguageHintVariant1 is { } __value0 && listenV1LanguageHintVariant1 != null)
            {
                return listenV1LanguageHintVariant1(__value0);
            }
            else if (ListenV1LanguageHintVariant2 is { } __value1 && listenV1LanguageHintVariant2 != null)
            {
                return listenV1LanguageHintVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? listenV1LanguageHintVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? listenV1LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV1LanguageHintVariant1 is { } __value0)
            {
                listenV1LanguageHintVariant1?.Invoke(__value0);
            }
            else if (ListenV1LanguageHintVariant2 is { } __value1)
            {
                listenV1LanguageHintVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? listenV1LanguageHintVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? listenV1LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV1LanguageHintVariant1 is { } __value0)
            {
                listenV1LanguageHintVariant1?.Invoke(__value0);
            }
            else if (ListenV1LanguageHintVariant2 is { } __value1)
            {
                listenV1LanguageHintVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenV1LanguageHintVariant1,
                typeof(string),
                ListenV1LanguageHintVariant2,
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
        public bool Equals(ListenV1LanguageHint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ListenV1LanguageHintVariant1, other.ListenV1LanguageHintVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ListenV1LanguageHintVariant2, other.ListenV1LanguageHintVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListenV1LanguageHint obj1, ListenV1LanguageHint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV1LanguageHint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListenV1LanguageHint obj1, ListenV1LanguageHint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV1LanguageHint o && Equals(o);
        }
    }
}
