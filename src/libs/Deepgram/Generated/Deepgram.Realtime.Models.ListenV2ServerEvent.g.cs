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
        /// Sent at the start of each connection, indicating the connection is active.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2ConnectedPayload? ConnectedPayload { get; init; }
#else
        public global::Deepgram.Realtime.V2ConnectedPayload? ConnectedPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConnectedPayload))]
#endif
        public bool IsConnectedPayload => ConnectedPayload != null;

        /// <summary>
        /// Describes the current turn and latest transcription state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2TurnInfoPayload? TurnInfoPayload { get; init; }
#else
        public global::Deepgram.Realtime.V2TurnInfoPayload? TurnInfoPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TurnInfoPayload))]
#endif
        public bool IsTurnInfoPayload => TurnInfoPayload != null;

        /// <summary>
        /// Sent when a Configure message was successfully applied.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2ConfigureSuccessPayload? ConfigureSuccessPayload { get; init; }
#else
        public global::Deepgram.Realtime.V2ConfigureSuccessPayload? ConfigureSuccessPayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureSuccessPayload))]
#endif
        public bool IsConfigureSuccessPayload => ConfigureSuccessPayload != null;

        /// <summary>
        /// Indicates that a Configure message was rejected.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.Realtime.V2ConfigureFailurePayload? ConfigureFailurePayload { get; init; }
#else
        public global::Deepgram.Realtime.V2ConfigureFailurePayload? ConfigureFailurePayload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConfigureFailurePayload))]
#endif
        public bool IsConfigureFailurePayload => ConfigureFailurePayload != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2ConnectedPayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2ConnectedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2ConnectedPayload?(ListenV2ServerEvent @this) => @this.ConnectedPayload;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2ConnectedPayload? value)
        {
            ConnectedPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2TurnInfoPayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2TurnInfoPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2TurnInfoPayload?(ListenV2ServerEvent @this) => @this.TurnInfoPayload;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2TurnInfoPayload? value)
        {
            TurnInfoPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureSuccessPayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2ConfigureSuccessPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2ConfigureSuccessPayload?(ListenV2ServerEvent @this) => @this.ConfigureSuccessPayload;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureSuccessPayload? value)
        {
            ConfigureSuccessPayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureFailurePayload value) => new ListenV2ServerEvent((global::Deepgram.Realtime.V2ConfigureFailurePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.Realtime.V2ConfigureFailurePayload?(ListenV2ServerEvent @this) => @this.ConfigureFailurePayload;

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(global::Deepgram.Realtime.V2ConfigureFailurePayload? value)
        {
            ConfigureFailurePayload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV2ServerEvent(
            global::Deepgram.Realtime.V2ConnectedPayload? connectedPayload,
            global::Deepgram.Realtime.V2TurnInfoPayload? turnInfoPayload,
            global::Deepgram.Realtime.V2ConfigureSuccessPayload? configureSuccessPayload,
            global::Deepgram.Realtime.V2ConfigureFailurePayload? configureFailurePayload
            )
        {
            ConnectedPayload = connectedPayload;
            TurnInfoPayload = turnInfoPayload;
            ConfigureSuccessPayload = configureSuccessPayload;
            ConfigureFailurePayload = configureFailurePayload;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConfigureFailurePayload as object ??
            ConfigureSuccessPayload as object ??
            TurnInfoPayload as object ??
            ConnectedPayload as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConnectedPayload?.ToString() ??
            TurnInfoPayload?.ToString() ??
            ConfigureSuccessPayload?.ToString() ??
            ConfigureFailurePayload?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConnectedPayload && !IsTurnInfoPayload && !IsConfigureSuccessPayload && !IsConfigureFailurePayload || !IsConnectedPayload && IsTurnInfoPayload && !IsConfigureSuccessPayload && !IsConfigureFailurePayload || !IsConnectedPayload && !IsTurnInfoPayload && IsConfigureSuccessPayload && !IsConfigureFailurePayload || !IsConnectedPayload && !IsTurnInfoPayload && !IsConfigureSuccessPayload && IsConfigureFailurePayload;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.Realtime.V2ConnectedPayload?, TResult>? connectedPayload = null,
            global::System.Func<global::Deepgram.Realtime.V2TurnInfoPayload?, TResult>? turnInfoPayload = null,
            global::System.Func<global::Deepgram.Realtime.V2ConfigureSuccessPayload?, TResult>? configureSuccessPayload = null,
            global::System.Func<global::Deepgram.Realtime.V2ConfigureFailurePayload?, TResult>? configureFailurePayload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnectedPayload && connectedPayload != null)
            {
                return connectedPayload(ConnectedPayload!);
            }
            else if (IsTurnInfoPayload && turnInfoPayload != null)
            {
                return turnInfoPayload(TurnInfoPayload!);
            }
            else if (IsConfigureSuccessPayload && configureSuccessPayload != null)
            {
                return configureSuccessPayload(ConfigureSuccessPayload!);
            }
            else if (IsConfigureFailurePayload && configureFailurePayload != null)
            {
                return configureFailurePayload(ConfigureFailurePayload!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.Realtime.V2ConnectedPayload?>? connectedPayload = null,
            global::System.Action<global::Deepgram.Realtime.V2TurnInfoPayload?>? turnInfoPayload = null,
            global::System.Action<global::Deepgram.Realtime.V2ConfigureSuccessPayload?>? configureSuccessPayload = null,
            global::System.Action<global::Deepgram.Realtime.V2ConfigureFailurePayload?>? configureFailurePayload = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConnectedPayload)
            {
                connectedPayload?.Invoke(ConnectedPayload!);
            }
            else if (IsTurnInfoPayload)
            {
                turnInfoPayload?.Invoke(TurnInfoPayload!);
            }
            else if (IsConfigureSuccessPayload)
            {
                configureSuccessPayload?.Invoke(ConfigureSuccessPayload!);
            }
            else if (IsConfigureFailurePayload)
            {
                configureFailurePayload?.Invoke(ConfigureFailurePayload!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConnectedPayload,
                typeof(global::Deepgram.Realtime.V2ConnectedPayload),
                TurnInfoPayload,
                typeof(global::Deepgram.Realtime.V2TurnInfoPayload),
                ConfigureSuccessPayload,
                typeof(global::Deepgram.Realtime.V2ConfigureSuccessPayload),
                ConfigureFailurePayload,
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
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2ConnectedPayload?>.Default.Equals(ConnectedPayload, other.ConnectedPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2TurnInfoPayload?>.Default.Equals(TurnInfoPayload, other.TurnInfoPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2ConfigureSuccessPayload?>.Default.Equals(ConfigureSuccessPayload, other.ConfigureSuccessPayload) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.Realtime.V2ConfigureFailurePayload?>.Default.Equals(ConfigureFailurePayload, other.ConfigureFailurePayload) 
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
