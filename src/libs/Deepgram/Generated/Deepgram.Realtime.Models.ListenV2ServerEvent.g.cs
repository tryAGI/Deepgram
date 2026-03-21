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
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ConnectedEvent? Connected { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ConnectedEvent? Connected { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connected))]
#endif
        public bool IsConnected => Connected != null;

        /// <summary>
        /// Describes the current turn and latest state of the turn
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2TurnInfoEvent? TurnInfo { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2TurnInfoEvent? TurnInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnInfo))]
#endif
        public bool IsTurnInfo => TurnInfo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent? ConfigureSuccess { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent? ConfigureSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureSuccess))]
#endif
        public bool IsConfigureSuccess => ConfigureSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ConfigureFailureEvent? ConfigureFailure { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ConfigureFailureEvent? ConfigureFailure { get; }
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
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2FatalErrorEvent? Error { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2FatalErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ConnectedEvent value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ConnectedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ConnectedEvent?(ListenV2ServerEvent @this) => @this.Connected;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ConnectedEvent? value)
        {
            Connected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2TurnInfoEvent value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2TurnInfoEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2TurnInfoEvent?(ListenV2ServerEvent @this) => @this.TurnInfo;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2TurnInfoEvent? value)
        {
            TurnInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent?(ListenV2ServerEvent @this) => @this.ConfigureSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent? value)
        {
            ConfigureSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ConfigureFailureEvent value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ConfigureFailureEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ConfigureFailureEvent?(ListenV2ServerEvent @this) => @this.ConfigureFailure;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ConfigureFailureEvent? value)
        {
            ConfigureFailure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2FatalErrorEvent value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2FatalErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2FatalErrorEvent?(ListenV2ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2FatalErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(
            global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType? type,
            global::Deepgram.Realtime.ListenV2ConnectedEvent? connected,
            global::Deepgram.Realtime.ListenV2TurnInfoEvent? turnInfo,
            global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent? configureSuccess,
            global::Deepgram.Realtime.ListenV2ConfigureFailureEvent? configureFailure,
            global::Deepgram.Realtime.ListenV2FatalErrorEvent? error
            )
        {
            Type = type;

            Connected = connected;
            TurnInfo = turnInfo;
            ConfigureSuccess = configureSuccess;
            ConfigureFailure = configureFailure;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
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
            ConfigureFailure?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConnected && !IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && !IsError || !IsConnected && IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && !IsError || !IsConnected && !IsTurnInfo && IsConfigureSuccess && !IsConfigureFailure && !IsError || !IsConnected && !IsTurnInfo && !IsConfigureSuccess && IsConfigureFailure && !IsError || !IsConnected && !IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ListenV2ConnectedEvent?, TResult>? connected = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2TurnInfoEvent?, TResult>? turnInfo = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent?, TResult>? configureSuccess = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ConfigureFailureEvent?, TResult>? configureFailure = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2FatalErrorEvent?, TResult>? error = null,
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
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ListenV2ConnectedEvent?>? connected = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2TurnInfoEvent?>? turnInfo = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent?>? configureSuccess = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ConfigureFailureEvent?>? configureFailure = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2FatalErrorEvent?>? error = null,
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
            else if (IsError)
            {
                error?.Invoke(Error!);
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
                typeof(global::Deepgram.Realtime.ListenV2ConnectedEvent),
                TurnInfo,
                typeof(global::Deepgram.Realtime.ListenV2TurnInfoEvent),
                ConfigureSuccess,
                typeof(global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent),
                ConfigureFailure,
                typeof(global::Deepgram.Realtime.ListenV2ConfigureFailureEvent),
                Error,
                typeof(global::Deepgram.Realtime.ListenV2FatalErrorEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ConnectedEvent?>.Default.Equals(Connected, other.Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2TurnInfoEvent?>.Default.Equals(TurnInfo, other.TurnInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ConfigureSuccessEvent?>.Default.Equals(ConfigureSuccess, other.ConfigureSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ConfigureFailureEvent?>.Default.Equals(ConfigureFailure, other.ConfigureFailure) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2FatalErrorEvent?>.Default.Equals(Error, other.Error) 
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
