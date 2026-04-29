#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// A history message is either a conversational message or a function call
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems>
    {
        /// <summary>
        /// Conversation text as part of the conversation history
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0? ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0? ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 => ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 != null;

        /// <summary>
        /// Client-side or server-side function call request and response as part of the conversation history
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1? ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1? ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 => ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0? channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0,
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1? channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1
            )
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 = channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0;
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 = channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 as object ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?.ToString() ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 && !IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 || !IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 && IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 = null,
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 && channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 && channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?>? channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0 = null,
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?>? channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0),
                ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1),
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0, other.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1, other.ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1SettingsAgentContextMessagesItems o && Equals(o);
        }
    }
}
