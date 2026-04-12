#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak : global::System.IEquatable<ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.SpeakSettingsV1? SpeakSettingsV1 { get; init; }
#else
        public global::Deepgram.Realtime.SpeakSettingsV1? SpeakSettingsV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakSettingsV1))]
#endif
        public bool IsSpeakSettingsV1 => SpeakSettingsV1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>? ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>? ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1))]
#endif
        public bool IsChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 => ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak(global::Deepgram.Realtime.SpeakSettingsV1 value) => new ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak((global::Deepgram.Realtime.SpeakSettingsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.SpeakSettingsV1?(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak @this) => @this.SpeakSettingsV1;

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak(global::Deepgram.Realtime.SpeakSettingsV1? value)
        {
            SpeakSettingsV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak(
            global::Deepgram.Realtime.SpeakSettingsV1? speakSettingsV1,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>? channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1
            )
        {
            SpeakSettingsV1 = speakSettingsV1;
            ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 = channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 as object ??
            SpeakSettingsV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpeakSettingsV1?.ToString() ??
            ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpeakSettingsV1 && !IsChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 || !IsSpeakSettingsV1 && IsChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.SpeakSettingsV1?, TResult>? speakSettingsV1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>?, TResult>? channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakSettingsV1 && speakSettingsV1 != null)
            {
                return speakSettingsV1(SpeakSettingsV1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 && channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 != null)
            {
                return channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.SpeakSettingsV1?>? speakSettingsV1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>?>? channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeakSettingsV1)
            {
                speakSettingsV1?.Invoke(SpeakSettingsV1!);
            }
            else if (IsChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1)
            {
                channelsAgentV1MessagesAgentV1UpdateSpeakSpeak1?.Invoke(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeakSettingsV1,
                typeof(global::Deepgram.Realtime.SpeakSettingsV1),
                ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1,
                typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>),
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
        public bool Equals(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.SpeakSettingsV1?>.Default.Equals(SpeakSettingsV1, other.SpeakSettingsV1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Deepgram.Realtime.SpeakSettingsV1>?>.Default.Equals(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1, other.ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak obj1, ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak obj1, ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelsAgentV1MessagesAgentV1UpdateSpeakSpeak o && Equals(o);
        }
    }
}
