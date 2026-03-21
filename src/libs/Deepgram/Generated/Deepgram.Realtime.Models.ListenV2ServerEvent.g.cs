#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListenV2ServerEvent : global::System.IEquatable<ListenV2ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Sent at the start of each connection, indicating the connection is active.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2ConnectedPayload? Connected { get; init; }
#else
        public global::Deepgram.Realtime.V2ConnectedPayload? Connected { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connected))]
#endif
        public bool IsConnected => Connected != null;

        /// <summary>
        /// Describes the current turn and latest transcription state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2TurnInfoPayload? TurnInfo { get; init; }
#else
        public global::Deepgram.Realtime.V2TurnInfoPayload? TurnInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnInfo))]
#endif
        public bool IsTurnInfo => TurnInfo != null;

        /// <summary>
        /// Sent when a Configure message was successfully applied.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2ConfigureSuccessPayload? ConfigureSuccess { get; init; }
#else
        public global::Deepgram.Realtime.V2ConfigureSuccessPayload? ConfigureSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureSuccess))]
#endif
        public bool IsConfigureSuccess => ConfigureSuccess != null;

        /// <summary>
        /// Indicates that a Configure message was rejected.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2ConfigureFailurePayload? ConfigureFailure { get; init; }
#else
        public global::Deepgram.Realtime.V2ConfigureFailurePayload? ConfigureFailure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureFailure))]
#endif
        public bool IsConfigureFailure => ConfigureFailure != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2ConnectedPayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2ConnectedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2ConnectedPayload?(ListenV2ServerEvent @this) => @this.Connected;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2ConnectedPayload? value)
        {
            Connected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2TurnInfoPayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2TurnInfoPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2TurnInfoPayload?(ListenV2ServerEvent @this) => @this.TurnInfo;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2TurnInfoPayload? value)
        {
            TurnInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureSuccessPayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2ConfigureSuccessPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2ConfigureSuccessPayload?(ListenV2ServerEvent @this) => @this.ConfigureSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureSuccessPayload? value)
        {
            ConfigureSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureFailurePayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2ConfigureFailurePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2ConfigureFailurePayload?(ListenV2ServerEvent @this) => @this.ConfigureFailure;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureFailurePayload? value)
        {
            ConfigureFailure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(
            global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType? type,
            global::Deepgram.Realtime.V2ConnectedPayload? connected,
            global::Deepgram.Realtime.V2TurnInfoPayload? turnInfo,
            global::Deepgram.Realtime.V2ConfigureSuccessPayload? configureSuccess,
            global::Deepgram.Realtime.V2ConfigureFailurePayload? configureFailure
            )
        {
            Type = type;

            Connected = connected;
            TurnInfo = turnInfo;
            ConfigureSuccess = configureSuccess;
            ConfigureFailure = configureFailure;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConfigureFailure as object ??
            ConfigureSuccess as object ??
            TurnInfo as object ??
            Connected as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Connected?.ToString() ??
            TurnInfo?.ToString() ??
            ConfigureSuccess?.ToString() ??
            ConfigureFailure?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConnected && !IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure || !IsConnected && IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure || !IsConnected && !IsTurnInfo && IsConfigureSuccess && !IsConfigureFailure || !IsConnected && !IsTurnInfo && !IsConfigureSuccess && IsConfigureFailure;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.V2ConnectedPayload?, TResult>? connected = null,
            global::System.Func<global::Deepgram.Realtime.V2TurnInfoPayload?, TResult>? turnInfo = null,
            global::System.Func<global::Deepgram.Realtime.V2ConfigureSuccessPayload?, TResult>? configureSuccess = null,
            global::System.Func<global::Deepgram.Realtime.V2ConfigureFailurePayload?, TResult>? configureFailure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnected && connected != null)
            {
                return connected(Connected!);
            }
            else if (IsTurnInfo && turnInfo != null)
            {
                return turnInfo(TurnInfo!);
            }
            else if (IsConfigureSuccess && configureSuccess != null)
            {
                return configureSuccess(ConfigureSuccess!);
            }
            else if (IsConfigureFailure && configureFailure != null)
            {
                return configureFailure(ConfigureFailure!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.V2ConnectedPayload?>? connected = null,
            global::System.Action<global::Deepgram.Realtime.V2TurnInfoPayload?>? turnInfo = null,
            global::System.Action<global::Deepgram.Realtime.V2ConfigureSuccessPayload?>? configureSuccess = null,
            global::System.Action<global::Deepgram.Realtime.V2ConfigureFailurePayload?>? configureFailure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnected)
            {
                connected?.Invoke(Connected!);
            }
            else if (IsTurnInfo)
            {
                turnInfo?.Invoke(TurnInfo!);
            }
            else if (IsConfigureSuccess)
            {
                configureSuccess?.Invoke(ConfigureSuccess!);
            }
            else if (IsConfigureFailure)
            {
                configureFailure?.Invoke(ConfigureFailure!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Connected,
                typeof(global::Deepgram.Realtime.V2ConnectedPayload),
                TurnInfo,
                typeof(global::Deepgram.Realtime.V2TurnInfoPayload),
                ConfigureSuccess,
                typeof(global::Deepgram.Realtime.V2ConfigureSuccessPayload),
                ConfigureFailure,
                typeof(global::Deepgram.Realtime.V2ConfigureFailurePayload),
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
        public bool Equals(ListenV2ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2ConnectedPayload?>.Default.Equals(Connected, other.Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2TurnInfoPayload?>.Default.Equals(TurnInfo, other.TurnInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2ConfigureSuccessPayload?>.Default.Equals(ConfigureSuccess, other.ConfigureSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2ConfigureFailurePayload?>.Default.Equals(ConfigureFailure, other.ConfigureFailure) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListenV2ServerEvent obj1, ListenV2ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV2ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListenV2ServerEvent obj1, ListenV2ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV2ServerEvent o && Equals(o);
        }
    }
}
