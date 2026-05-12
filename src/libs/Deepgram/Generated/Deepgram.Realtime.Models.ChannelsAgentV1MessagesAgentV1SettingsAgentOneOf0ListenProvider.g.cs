#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.DeepgramListenProviderV1? DeepgramListenProviderV1 { get; init; }
#else
        public global::Deepgram.Realtime.DeepgramListenProviderV1? DeepgramListenProviderV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepgramListenProviderV1))]
#endif
        public bool IsDeepgramListenProviderV1 => DeepgramListenProviderV1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepgramListenProviderV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.DeepgramListenProviderV1? value)
        {
            value = DeepgramListenProviderV1;
            return IsDeepgramListenProviderV1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.DeepgramListenProviderV1 PickDeepgramListenProviderV1() => IsDeepgramListenProviderV1
            ? DeepgramListenProviderV1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepgramListenProviderV1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.DeepgramListenProviderV2? DeepgramListenProviderV2 { get; init; }
#else
        public global::Deepgram.Realtime.DeepgramListenProviderV2? DeepgramListenProviderV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepgramListenProviderV2))]
#endif
        public bool IsDeepgramListenProviderV2 => DeepgramListenProviderV2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeepgramListenProviderV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.DeepgramListenProviderV2? value)
        {
            value = DeepgramListenProviderV2;
            return IsDeepgramListenProviderV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.DeepgramListenProviderV2 PickDeepgramListenProviderV2() => IsDeepgramListenProviderV2
            ? DeepgramListenProviderV2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepgramListenProviderV2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.DeepgramListenProviderV1 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider((global::Deepgram.Realtime.DeepgramListenProviderV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.DeepgramListenProviderV1?(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider @this) => @this.DeepgramListenProviderV1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.DeepgramListenProviderV1? value)
        {
            DeepgramListenProviderV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider FromDeepgramListenProviderV1(global::Deepgram.Realtime.DeepgramListenProviderV1? value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.DeepgramListenProviderV2 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider((global::Deepgram.Realtime.DeepgramListenProviderV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.DeepgramListenProviderV2?(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider @this) => @this.DeepgramListenProviderV2;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.DeepgramListenProviderV2? value)
        {
            DeepgramListenProviderV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider FromDeepgramListenProviderV2(global::Deepgram.Realtime.DeepgramListenProviderV2? value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(value);

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(
            global::Deepgram.Realtime.DeepgramListenProviderV1? deepgramListenProviderV1,
            global::Deepgram.Realtime.DeepgramListenProviderV2? deepgramListenProviderV2
            )
        {
            DeepgramListenProviderV1 = deepgramListenProviderV1;
            DeepgramListenProviderV2 = deepgramListenProviderV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeepgramListenProviderV2 as object ??
            DeepgramListenProviderV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DeepgramListenProviderV1?.ToString() ??
            DeepgramListenProviderV2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeepgramListenProviderV1 && !IsDeepgramListenProviderV2 || !IsDeepgramListenProviderV1 && IsDeepgramListenProviderV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.DeepgramListenProviderV1, TResult>? deepgramListenProviderV1 = null,
            global::System.Func<global::Deepgram.Realtime.DeepgramListenProviderV2, TResult>? deepgramListenProviderV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramListenProviderV1 && deepgramListenProviderV1 != null)
            {
                return deepgramListenProviderV1(DeepgramListenProviderV1!);
            }
            else if (IsDeepgramListenProviderV2 && deepgramListenProviderV2 != null)
            {
                return deepgramListenProviderV2(DeepgramListenProviderV2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.DeepgramListenProviderV1>? deepgramListenProviderV1 = null,

            global::System.Action<global::Deepgram.Realtime.DeepgramListenProviderV2>? deepgramListenProviderV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramListenProviderV1)
            {
                deepgramListenProviderV1?.Invoke(DeepgramListenProviderV1!);
            }
            else if (IsDeepgramListenProviderV2)
            {
                deepgramListenProviderV2?.Invoke(DeepgramListenProviderV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.DeepgramListenProviderV1>? deepgramListenProviderV1 = null,
            global::System.Action<global::Deepgram.Realtime.DeepgramListenProviderV2>? deepgramListenProviderV2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeepgramListenProviderV1)
            {
                deepgramListenProviderV1?.Invoke(DeepgramListenProviderV1!);
            }
            else if (IsDeepgramListenProviderV2)
            {
                deepgramListenProviderV2?.Invoke(DeepgramListenProviderV2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeepgramListenProviderV1,
                typeof(global::Deepgram.Realtime.DeepgramListenProviderV1),
                DeepgramListenProviderV2,
                typeof(global::Deepgram.Realtime.DeepgramListenProviderV2),
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.DeepgramListenProviderV1?>.Default.Equals(DeepgramListenProviderV1, other.DeepgramListenProviderV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.DeepgramListenProviderV2?>.Default.Equals(DeepgramListenProviderV2, other.DeepgramListenProviderV2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider o && Equals(o);
        }
    }
}
