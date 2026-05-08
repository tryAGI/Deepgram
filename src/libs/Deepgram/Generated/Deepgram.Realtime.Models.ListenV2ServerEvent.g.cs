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
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2Connected? ListenV2ListenV2Connected { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2Connected? ListenV2ListenV2Connected { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2ListenV2Connected))]
#endif
        public bool IsListenV2ListenV2Connected => ListenV2ListenV2Connected != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV2ListenV2Connected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2Connected? value)
        {
            value = ListenV2ListenV2Connected;
            return IsListenV2ListenV2Connected;
        }

        /// <summary>
        /// Describes the current turn and latest state of the turn
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? ListenV2ListenV2TurnInfo { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? ListenV2ListenV2TurnInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2ListenV2TurnInfo))]
#endif
        public bool IsListenV2ListenV2TurnInfo => ListenV2ListenV2TurnInfo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV2ListenV2TurnInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? value)
        {
            value = ListenV2ListenV2TurnInfo;
            return IsListenV2ListenV2TurnInfo;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? ListenV2ListenV2ConfigureSuccess { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? ListenV2ListenV2ConfigureSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2ListenV2ConfigureSuccess))]
#endif
        public bool IsListenV2ListenV2ConfigureSuccess => ListenV2ListenV2ConfigureSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV2ListenV2ConfigureSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? value)
        {
            value = ListenV2ListenV2ConfigureSuccess;
            return IsListenV2ListenV2ConfigureSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? ListenV2ListenV2ConfigureFailure { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? ListenV2ListenV2ConfigureFailure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2ListenV2ConfigureFailure))]
#endif
        public bool IsListenV2ListenV2ConfigureFailure => ListenV2ListenV2ConfigureFailure != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV2ListenV2ConfigureFailure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? value)
        {
            value = ListenV2ListenV2ConfigureFailure;
            return IsListenV2ListenV2ConfigureFailure;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2FatalError? ListenV2ListenV2FatalError { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2FatalError? ListenV2ListenV2FatalError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV2ListenV2FatalError))]
#endif
        public bool IsListenV2ListenV2FatalError => ListenV2ListenV2FatalError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV2ListenV2FatalError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2FatalError? value)
        {
            value = ListenV2ListenV2FatalError;
            return IsListenV2ListenV2FatalError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2Connected value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2Connected?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2Connected?(ListenV2ServerEvent @this) => @this.ListenV2ListenV2Connected;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2Connected? value)
        {
            ListenV2ListenV2Connected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?(ListenV2ServerEvent @this) => @this.ListenV2ListenV2TurnInfo;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? value)
        {
            ListenV2ListenV2TurnInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?(ListenV2ServerEvent @this) => @this.ListenV2ListenV2ConfigureSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? value)
        {
            ListenV2ListenV2ConfigureSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?(ListenV2ServerEvent @this) => @this.ListenV2ListenV2ConfigureFailure;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? value)
        {
            ListenV2ListenV2ConfigureFailure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2FatalError value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2FatalError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2FatalError?(ListenV2ServerEvent @this) => @this.ListenV2ListenV2FatalError;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2FatalError? value)
        {
            ListenV2ListenV2FatalError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(
            global::Deepgram.Realtime.ListenV2ListenV2Connected? listenV2ListenV2Connected,
            global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? listenV2ListenV2TurnInfo,
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? listenV2ListenV2ConfigureSuccess,
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? listenV2ListenV2ConfigureFailure,
            global::Deepgram.Realtime.ListenV2ListenV2FatalError? listenV2ListenV2FatalError
            )
        {
            ListenV2ListenV2Connected = listenV2ListenV2Connected;
            ListenV2ListenV2TurnInfo = listenV2ListenV2TurnInfo;
            ListenV2ListenV2ConfigureSuccess = listenV2ListenV2ConfigureSuccess;
            ListenV2ListenV2ConfigureFailure = listenV2ListenV2ConfigureFailure;
            ListenV2ListenV2FatalError = listenV2ListenV2FatalError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListenV2ListenV2FatalError as object ??
            ListenV2ListenV2ConfigureFailure as object ??
            ListenV2ListenV2ConfigureSuccess as object ??
            ListenV2ListenV2TurnInfo as object ??
            ListenV2ListenV2Connected as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListenV2ListenV2Connected?.ToString() ??
            ListenV2ListenV2TurnInfo?.ToString() ??
            ListenV2ListenV2ConfigureSuccess?.ToString() ??
            ListenV2ListenV2ConfigureFailure?.ToString() ??
            ListenV2ListenV2FatalError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListenV2ListenV2Connected && !IsListenV2ListenV2TurnInfo && !IsListenV2ListenV2ConfigureSuccess && !IsListenV2ListenV2ConfigureFailure && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && IsListenV2ListenV2TurnInfo && !IsListenV2ListenV2ConfigureSuccess && !IsListenV2ListenV2ConfigureFailure && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsListenV2ListenV2TurnInfo && IsListenV2ListenV2ConfigureSuccess && !IsListenV2ListenV2ConfigureFailure && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsListenV2ListenV2TurnInfo && !IsListenV2ListenV2ConfigureSuccess && IsListenV2ListenV2ConfigureFailure && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsListenV2ListenV2TurnInfo && !IsListenV2ListenV2ConfigureSuccess && !IsListenV2ListenV2ConfigureFailure && IsListenV2ListenV2FatalError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2Connected, TResult>? listenV2ListenV2Connected = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo, TResult>? listenV2ListenV2TurnInfo = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess, TResult>? listenV2ListenV2ConfigureSuccess = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure, TResult>? listenV2ListenV2ConfigureFailure = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2FatalError, TResult>? listenV2ListenV2FatalError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2ListenV2Connected && listenV2ListenV2Connected != null)
            {
                return listenV2ListenV2Connected(ListenV2ListenV2Connected!);
            }
            else if (IsListenV2ListenV2TurnInfo && listenV2ListenV2TurnInfo != null)
            {
                return listenV2ListenV2TurnInfo(ListenV2ListenV2TurnInfo!);
            }
            else if (IsListenV2ListenV2ConfigureSuccess && listenV2ListenV2ConfigureSuccess != null)
            {
                return listenV2ListenV2ConfigureSuccess(ListenV2ListenV2ConfigureSuccess!);
            }
            else if (IsListenV2ListenV2ConfigureFailure && listenV2ListenV2ConfigureFailure != null)
            {
                return listenV2ListenV2ConfigureFailure(ListenV2ListenV2ConfigureFailure!);
            }
            else if (IsListenV2ListenV2FatalError && listenV2ListenV2FatalError != null)
            {
                return listenV2ListenV2FatalError(ListenV2ListenV2FatalError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2Connected>? listenV2ListenV2Connected = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo>? listenV2ListenV2TurnInfo = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess>? listenV2ListenV2ConfigureSuccess = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure>? listenV2ListenV2ConfigureFailure = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2FatalError>? listenV2ListenV2FatalError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2ListenV2Connected)
            {
                listenV2ListenV2Connected?.Invoke(ListenV2ListenV2Connected!);
            }
            else if (IsListenV2ListenV2TurnInfo)
            {
                listenV2ListenV2TurnInfo?.Invoke(ListenV2ListenV2TurnInfo!);
            }
            else if (IsListenV2ListenV2ConfigureSuccess)
            {
                listenV2ListenV2ConfigureSuccess?.Invoke(ListenV2ListenV2ConfigureSuccess!);
            }
            else if (IsListenV2ListenV2ConfigureFailure)
            {
                listenV2ListenV2ConfigureFailure?.Invoke(ListenV2ListenV2ConfigureFailure!);
            }
            else if (IsListenV2ListenV2FatalError)
            {
                listenV2ListenV2FatalError?.Invoke(ListenV2ListenV2FatalError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2Connected>? listenV2ListenV2Connected = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo>? listenV2ListenV2TurnInfo = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess>? listenV2ListenV2ConfigureSuccess = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure>? listenV2ListenV2ConfigureFailure = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2FatalError>? listenV2ListenV2FatalError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV2ListenV2Connected)
            {
                listenV2ListenV2Connected?.Invoke(ListenV2ListenV2Connected!);
            }
            else if (IsListenV2ListenV2TurnInfo)
            {
                listenV2ListenV2TurnInfo?.Invoke(ListenV2ListenV2TurnInfo!);
            }
            else if (IsListenV2ListenV2ConfigureSuccess)
            {
                listenV2ListenV2ConfigureSuccess?.Invoke(ListenV2ListenV2ConfigureSuccess!);
            }
            else if (IsListenV2ListenV2ConfigureFailure)
            {
                listenV2ListenV2ConfigureFailure?.Invoke(ListenV2ListenV2ConfigureFailure!);
            }
            else if (IsListenV2ListenV2FatalError)
            {
                listenV2ListenV2FatalError?.Invoke(ListenV2ListenV2FatalError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenV2ListenV2Connected,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2Connected),
                ListenV2ListenV2TurnInfo,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo),
                ListenV2ListenV2ConfigureSuccess,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess),
                ListenV2ListenV2ConfigureFailure,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure),
                ListenV2ListenV2FatalError,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2FatalError),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2Connected?>.Default.Equals(ListenV2ListenV2Connected, other.ListenV2ListenV2Connected) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?>.Default.Equals(ListenV2ListenV2TurnInfo, other.ListenV2ListenV2TurnInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?>.Default.Equals(ListenV2ListenV2ConfigureSuccess, other.ListenV2ListenV2ConfigureSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?>.Default.Equals(ListenV2ListenV2ConfigureFailure, other.ListenV2ListenV2ConfigureFailure) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2FatalError?>.Default.Equals(ListenV2ListenV2FatalError, other.ListenV2ListenV2FatalError) 
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
