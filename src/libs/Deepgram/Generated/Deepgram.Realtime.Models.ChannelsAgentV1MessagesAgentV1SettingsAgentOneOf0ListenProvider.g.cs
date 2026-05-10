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
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 => ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0? value)
        {
            value = ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0;
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 PickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0() => IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0
            ? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 => ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1? value)
        {
            value = ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1;
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 PickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1() => IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1
            ? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0?(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider FromChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0? value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1?(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider FromChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1? value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(value);

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1
            )
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 = channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0;
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 = channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 as object ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0?.ToString() ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 && !IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 || !IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 && IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 = null,
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 = null,

            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0 = null,
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0),
                ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0, other.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1, other.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0ListenProvider1) 
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
