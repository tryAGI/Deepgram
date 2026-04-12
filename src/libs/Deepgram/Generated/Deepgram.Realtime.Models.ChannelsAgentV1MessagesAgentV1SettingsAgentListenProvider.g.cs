#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0? ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0? ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 => ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1? ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1? ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 => ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1
            )
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0;
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 as object ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?.ToString() ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 && !IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 || !IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 && IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = null,
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 && channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 && channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?>? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0 = null,
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?>? channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0),
                ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1),
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0, other.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1, other.ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1SettingsAgentListenProvider o && Equals(o);
        }
    }
}
