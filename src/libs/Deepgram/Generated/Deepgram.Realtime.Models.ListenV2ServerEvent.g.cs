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
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV2ListenV2Connected PickListenV2ListenV2Connected() => ListenV2ListenV2Connected is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV2ListenV2Connected' but the value was {ToString()}.");

        /// <summary>
        /// Describes the current turn and latest state of the turn
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? TurnInfo { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? TurnInfo { get; }
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
        public bool TryPickTurnInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? value)
        {
            value = TurnInfo;
            return IsTurnInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV2ListenV2TurnInfo PickTurnInfo() => TurnInfo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TurnInfo' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? ConfigureSuccess { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? ConfigureSuccess { get; }
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
        public bool TryPickConfigureSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? value)
        {
            value = ConfigureSuccess;
            return IsConfigureSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess PickConfigureSuccess() => ConfigureSuccess is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConfigureSuccess' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? ConfigureFailure { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? ConfigureFailure { get; }
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
        public bool TryPickConfigureFailure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? value)
        {
            value = ConfigureFailure;
            return IsConfigureFailure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure PickConfigureFailure() => ConfigureFailure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConfigureFailure' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.ListenV2ListenV2Warning? Warning { get; init; }
#else
        public global::Deepgram.Realtime.ListenV2ListenV2Warning? Warning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Warning))]
#endif
        public bool IsWarning => Warning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWarning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.Realtime.ListenV2ListenV2Warning? value)
        {
            value = Warning;
            return IsWarning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Deepgram.Realtime.ListenV2ListenV2Warning PickWarning() => Warning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Warning' but the value was {ToString()}.");

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
        public global::Deepgram.Realtime.ListenV2ListenV2FatalError PickListenV2ListenV2FatalError() => ListenV2ListenV2FatalError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenV2ListenV2FatalError' but the value was {ToString()}.");
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
        public static ListenV2ServerEvent FromListenV2ListenV2Connected(global::Deepgram.Realtime.ListenV2ListenV2Connected? value) => new ListenV2ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?(ListenV2ServerEvent @this) => @this.TurnInfo;

        /// <summary>
        ///
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? value)
        {
            TurnInfo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListenV2ServerEvent FromTurnInfo(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? value) => new ListenV2ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?(ListenV2ServerEvent @this) => @this.ConfigureSuccess;

        /// <summary>
        ///
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? value)
        {
            ConfigureSuccess = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListenV2ServerEvent FromConfigureSuccess(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? value) => new ListenV2ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?(ListenV2ServerEvent @this) => @this.ConfigureFailure;

        /// <summary>
        ///
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? value)
        {
            ConfigureFailure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListenV2ServerEvent FromConfigureFailure(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? value) => new ListenV2ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2Warning value) => new ListenV2ServerEvent((global::Deepgram.Realtime.ListenV2ListenV2Warning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.ListenV2ListenV2Warning?(ListenV2ServerEvent @this) => @this.Warning;

        /// <summary>
        ///
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.ListenV2ListenV2Warning? value)
        {
            Warning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListenV2ServerEvent FromWarning(global::Deepgram.Realtime.ListenV2ListenV2Warning? value) => new ListenV2ServerEvent(value);

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
        public static ListenV2ServerEvent FromListenV2ListenV2FatalError(global::Deepgram.Realtime.ListenV2ListenV2FatalError? value) => new ListenV2ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ListenV2ServerEvent(
            global::Deepgram.Realtime.ListenV2ListenV2Connected? listenV2ListenV2Connected,
            global::Deepgram.Realtime.ListenV2ListenV2TurnInfo? turnInfo,
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess? configureSuccess,
            global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure? configureFailure,
            global::Deepgram.Realtime.ListenV2ListenV2Warning? warning,
            global::Deepgram.Realtime.ListenV2ListenV2FatalError? listenV2ListenV2FatalError
            )
        {
            ListenV2ListenV2Connected = listenV2ListenV2Connected;
            TurnInfo = turnInfo;
            ConfigureSuccess = configureSuccess;
            ConfigureFailure = configureFailure;
            Warning = warning;
            ListenV2ListenV2FatalError = listenV2ListenV2FatalError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListenV2ListenV2FatalError as object ??
            Warning as object ??
            ConfigureFailure as object ??
            ConfigureSuccess as object ??
            TurnInfo as object ??
            ListenV2ListenV2Connected as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ListenV2ListenV2Connected?.ToString() ??
            TurnInfo?.ToString() ??
            ConfigureSuccess?.ToString() ??
            ConfigureFailure?.ToString() ??
            Warning?.ToString() ??
            ListenV2ListenV2FatalError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsListenV2ListenV2Connected && !IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsTurnInfo && IsConfigureSuccess && !IsConfigureFailure && !IsWarning && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsTurnInfo && !IsConfigureSuccess && IsConfigureFailure && !IsWarning && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && IsWarning && !IsListenV2ListenV2FatalError || !IsListenV2ListenV2Connected && !IsTurnInfo && !IsConfigureSuccess && !IsConfigureFailure && !IsWarning && IsListenV2ListenV2FatalError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2Connected, TResult>? listenV2ListenV2Connected = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo, TResult>? turnInfo = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess, TResult>? configureSuccess = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure, TResult>? configureFailure = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2Warning, TResult>? warning = null,
            global::System.Func<global::Deepgram.Realtime.ListenV2ListenV2FatalError, TResult>? listenV2ListenV2FatalError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV2ListenV2Connected is { } __value0 && listenV2ListenV2Connected != null)
            {
                return listenV2ListenV2Connected(__value0);
            }
            else if (TurnInfo is { } __value1 && turnInfo != null)
            {
                return turnInfo(__value1);
            }
            else if (ConfigureSuccess is { } __value2 && configureSuccess != null)
            {
                return configureSuccess(__value2);
            }
            else if (ConfigureFailure is { } __value3 && configureFailure != null)
            {
                return configureFailure(__value3);
            }
            else if (Warning is { } __value4 && warning != null)
            {
                return warning(__value4);
            }
            else if (ListenV2ListenV2FatalError is { } __value5 && listenV2ListenV2FatalError != null)
            {
                return listenV2ListenV2FatalError(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2Connected>? listenV2ListenV2Connected = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo>? turnInfo = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess>? configureSuccess = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure>? configureFailure = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2Warning>? warning = null,

            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2FatalError>? listenV2ListenV2FatalError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV2ListenV2Connected is { } __value0)
            {
                listenV2ListenV2Connected?.Invoke(__value0);
            }
            else if (TurnInfo is { } __value1)
            {
                turnInfo?.Invoke(__value1);
            }
            else if (ConfigureSuccess is { } __value2)
            {
                configureSuccess?.Invoke(__value2);
            }
            else if (ConfigureFailure is { } __value3)
            {
                configureFailure?.Invoke(__value3);
            }
            else if (Warning is { } __value4)
            {
                warning?.Invoke(__value4);
            }
            else if (ListenV2ListenV2FatalError is { } __value5)
            {
                listenV2ListenV2FatalError?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2Connected>? listenV2ListenV2Connected = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo>? turnInfo = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess>? configureSuccess = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure>? configureFailure = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2Warning>? warning = null,
            global::System.Action<global::Deepgram.Realtime.ListenV2ListenV2FatalError>? listenV2ListenV2FatalError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ListenV2ListenV2Connected is { } __value0)
            {
                listenV2ListenV2Connected?.Invoke(__value0);
            }
            else if (TurnInfo is { } __value1)
            {
                turnInfo?.Invoke(__value1);
            }
            else if (ConfigureSuccess is { } __value2)
            {
                configureSuccess?.Invoke(__value2);
            }
            else if (ConfigureFailure is { } __value3)
            {
                configureFailure?.Invoke(__value3);
            }
            else if (Warning is { } __value4)
            {
                warning?.Invoke(__value4);
            }
            else if (ListenV2ListenV2FatalError is { } __value5)
            {
                listenV2ListenV2FatalError?.Invoke(__value5);
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
                TurnInfo,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2TurnInfo),
                ConfigureSuccess,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess),
                ConfigureFailure,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure),
                Warning,
                typeof(global::Deepgram.Realtime.ListenV2ListenV2Warning),
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2TurnInfo?>.Default.Equals(TurnInfo, other.TurnInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2ConfigureSuccess?>.Default.Equals(ConfigureSuccess, other.ConfigureSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2ConfigureFailure?>.Default.Equals(ConfigureFailure, other.ConfigureFailure) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.ListenV2ListenV2Warning?>.Default.Equals(Warning, other.Warning) &&
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
