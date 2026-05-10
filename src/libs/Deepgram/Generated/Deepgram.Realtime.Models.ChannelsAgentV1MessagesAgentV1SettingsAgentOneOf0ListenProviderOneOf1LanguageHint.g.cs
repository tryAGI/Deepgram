#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// One or more BCP-47 language codes to bias the model toward specific languages. Only supported when model is flux-general-multi. Without hints, the model auto-detects the spoken language. See the Language Prompting guide for details.
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 { get; init; }
#else
        public string? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 => ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1;
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1() => IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1
            ? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 => ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2;
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2() => IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2
            ? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint(string value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint(string? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint FromChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1(string? value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint(value);

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint(
            string? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1,
            global::System.Collections.Generic.IList<string>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2
            )
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 = channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1;
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 = channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 as object ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1?.ToString() ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 && !IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 || !IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 && IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1,
                typeof(string),
                ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2,
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1, other.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2, other.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHintVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProviderOneOf1LanguageHint o && Equals(o);
        }
    }
}
