#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1SettingsAgent : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1SettingsAgent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0? ChannelsAgentV1MessagesAgentV1SettingsAgent0 { get; init; }
#else
        public global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0? ChannelsAgentV1MessagesAgentV1SettingsAgent0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgent0))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgent0 => ChannelsAgentV1MessagesAgentV1SettingsAgent0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Guid? Guid { get; init; }
#else
        public global::System.Guid? Guid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Guid))]
#endif
        public bool IsGuid => Guid != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgent(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgent((global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0?(ChannelsAgentV1MessagesAgentV1SettingsAgent @this) => @this.ChannelsAgentV1MessagesAgentV1SettingsAgent0;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgent(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0? value)
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgent0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgent(global::System.Guid value) => new ChannelsAgentV1MessagesAgentV1SettingsAgent((global::System.Guid?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Guid?(ChannelsAgentV1MessagesAgentV1SettingsAgent @this) => @this.Guid;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgent(global::System.Guid? value)
        {
            Guid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgent(
            global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0? channelsAgentV1MessagesAgentV1SettingsAgent0,
            global::System.Guid? guid
            )
        {
            ChannelsAgentV1MessagesAgentV1SettingsAgent0 = channelsAgentV1MessagesAgentV1SettingsAgent0;
            Guid = guid;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Guid as object ??
            ChannelsAgentV1MessagesAgentV1SettingsAgent0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChannelsAgentV1MessagesAgentV1SettingsAgent0?.ToString() ??
            Guid?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChannelsAgentV1MessagesAgentV1SettingsAgent0 && !IsGuid || !IsChannelsAgentV1MessagesAgentV1SettingsAgent0 && IsGuid;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0?, TResult>? channelsAgentV1MessagesAgentV1SettingsAgent0 = null,
            global::System.Func<global::System.Guid?, TResult>? guid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgent0 && channelsAgentV1MessagesAgentV1SettingsAgent0 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgent0(ChannelsAgentV1MessagesAgentV1SettingsAgent0!);
            }
            else if (IsGuid && guid != null)
            {
                return guid(Guid!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0?>? channelsAgentV1MessagesAgentV1SettingsAgent0 = null,
            global::System.Action<global::System.Guid?>? guid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChannelsAgentV1MessagesAgentV1SettingsAgent0)
            {
                channelsAgentV1MessagesAgentV1SettingsAgent0?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgent0!);
            }
            else if (IsGuid)
            {
                guid?.Invoke(Guid!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChannelsAgentV1MessagesAgentV1SettingsAgent0,
                typeof(global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0),
                Guid,
                typeof(global::System.Guid),
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1SettingsAgent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ChannelsAgentV1MessagesAgentV1SettingsAgent0?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgent0, other.ChannelsAgentV1MessagesAgentV1SettingsAgent0) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Guid?>.Default.Equals(Guid, other.Guid) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1SettingsAgent obj1, ChannelsAgentV1MessagesAgentV1SettingsAgent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1SettingsAgent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1SettingsAgent obj1, ChannelsAgentV1MessagesAgentV1SettingsAgent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1SettingsAgent o && Equals(o);
        }
    }
}
