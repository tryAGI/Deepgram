#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ThinkSettingsV1? ThinkSettingsV1 { get; init; }
#else
        public global::Deepgram.Realtime.ThinkSettingsV1? ThinkSettingsV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkSettingsV1))]
#endif
        public bool IsThinkSettingsV1 => ThinkSettingsV1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinkSettingsV1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ThinkSettingsV1? value)
        {
            value = ThinkSettingsV1;
            return IsThinkSettingsV1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.ThinkSettingsV1 PickThinkSettingsV1() => IsThinkSettingsV1
            ? ThinkSettingsV1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkSettingsV1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 => ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>? value)
        {
            value = ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1;
            return IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1> PickChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1() => IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1
            ? ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think(global::Deepgram.Realtime.ThinkSettingsV1 value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think((global::Deepgram.Realtime.ThinkSettingsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ThinkSettingsV1?(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think @this) => @this.ThinkSettingsV1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think(global::Deepgram.Realtime.ThinkSettingsV1? value)
        {
            ThinkSettingsV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think FromThinkSettingsV1(global::Deepgram.Realtime.ThinkSettingsV1? value) => new ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think(value);

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think(
            global::Deepgram.Realtime.ThinkSettingsV1? thinkSettingsV1,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1
            )
        {
            ThinkSettingsV1 = thinkSettingsV1;
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 as object ??
            ThinkSettingsV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ThinkSettingsV1?.ToString() ??
            ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThinkSettingsV1 && !IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 || !IsThinkSettingsV1 && IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ThinkSettingsV1, TResult>? thinkSettingsV1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>, TResult>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkSettingsV1 && thinkSettingsV1 != null)
            {
                return thinkSettingsV1(ThinkSettingsV1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 && channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 != null)
            {
                return channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ThinkSettingsV1>? thinkSettingsV1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkSettingsV1)
            {
                thinkSettingsV1?.Invoke(ThinkSettingsV1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.ThinkSettingsV1>? thinkSettingsV1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>>? channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkSettingsV1)
            {
                thinkSettingsV1?.Invoke(ThinkSettingsV1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1)
            {
                channelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1?.Invoke(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ThinkSettingsV1,
                typeof(global::Deepgram.Realtime.ThinkSettingsV1),
                ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1,
                typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>),
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ThinkSettingsV1?>.Default.Equals(ThinkSettingsV1, other.ThinkSettingsV1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Deepgram.Realtime.ThinkSettingsV1>?>.Default.Equals(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1, other.ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think obj1, ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1SettingsAgentOneOf0Think o && Equals(o);
        }
    }
}
