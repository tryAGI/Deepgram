#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListenV1MediaTranscribeResponse200 : global::System.IEquatable<ListenV1MediaTranscribeResponse200>
    {
        /// <summary>
        /// The standard transcription response
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ListenV1Response? ListenV1Response { get; init; }
#else
        public global::Deepgram.ListenV1Response? ListenV1Response { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1Response))]
#endif
        public bool IsListenV1Response => ListenV1Response != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV1Response(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.ListenV1Response? value)
        {
            value = ListenV1Response;
            return IsListenV1Response;
        }

        /// <summary>
        /// Accepted response for asynchronous transcription requests
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Deepgram.ListenV1AcceptedResponse? ListenV1AcceptedResponse { get; init; }
#else
        public global::Deepgram.ListenV1AcceptedResponse? ListenV1AcceptedResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenV1AcceptedResponse))]
#endif
        public bool IsListenV1AcceptedResponse => ListenV1AcceptedResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListenV1AcceptedResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Deepgram.ListenV1AcceptedResponse? value)
        {
            value = ListenV1AcceptedResponse;
            return IsListenV1AcceptedResponse;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1MediaTranscribeResponse200(global::Deepgram.ListenV1Response value) => new ListenV1MediaTranscribeResponse200((global::Deepgram.ListenV1Response?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ListenV1Response?(ListenV1MediaTranscribeResponse200 @this) => @this.ListenV1Response;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1MediaTranscribeResponse200(global::Deepgram.ListenV1Response? value)
        {
            ListenV1Response = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListenV1MediaTranscribeResponse200(global::Deepgram.ListenV1AcceptedResponse value) => new ListenV1MediaTranscribeResponse200((global::Deepgram.ListenV1AcceptedResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Deepgram.ListenV1AcceptedResponse?(ListenV1MediaTranscribeResponse200 @this) => @this.ListenV1AcceptedResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListenV1MediaTranscribeResponse200(global::Deepgram.ListenV1AcceptedResponse? value)
        {
            ListenV1AcceptedResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListenV1MediaTranscribeResponse200(
            global::Deepgram.ListenV1Response? listenV1Response,
            global::Deepgram.ListenV1AcceptedResponse? listenV1AcceptedResponse
            )
        {
            ListenV1Response = listenV1Response;
            ListenV1AcceptedResponse = listenV1AcceptedResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListenV1AcceptedResponse as object ??
            ListenV1Response as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ListenV1Response?.ToString() ??
            ListenV1AcceptedResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsListenV1Response && !IsListenV1AcceptedResponse || !IsListenV1Response && IsListenV1AcceptedResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Deepgram.ListenV1Response, TResult>? listenV1Response = null,
            global::System.Func<global::Deepgram.ListenV1AcceptedResponse, TResult>? listenV1AcceptedResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV1Response && listenV1Response != null)
            {
                return listenV1Response(ListenV1Response!);
            }
            else if (IsListenV1AcceptedResponse && listenV1AcceptedResponse != null)
            {
                return listenV1AcceptedResponse(ListenV1AcceptedResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Deepgram.ListenV1Response>? listenV1Response = null,

            global::System.Action<global::Deepgram.ListenV1AcceptedResponse>? listenV1AcceptedResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV1Response)
            {
                listenV1Response?.Invoke(ListenV1Response!);
            }
            else if (IsListenV1AcceptedResponse)
            {
                listenV1AcceptedResponse?.Invoke(ListenV1AcceptedResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Deepgram.ListenV1Response>? listenV1Response = null,
            global::System.Action<global::Deepgram.ListenV1AcceptedResponse>? listenV1AcceptedResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsListenV1Response)
            {
                listenV1Response?.Invoke(ListenV1Response!);
            }
            else if (IsListenV1AcceptedResponse)
            {
                listenV1AcceptedResponse?.Invoke(ListenV1AcceptedResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ListenV1Response,
                typeof(global::Deepgram.ListenV1Response),
                ListenV1AcceptedResponse,
                typeof(global::Deepgram.ListenV1AcceptedResponse),
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
        public bool Equals(ListenV1MediaTranscribeResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ListenV1Response?>.Default.Equals(ListenV1Response, other.ListenV1Response) &&
                global::System.Collections.Generic.EqualityComparer<global::Deepgram.ListenV1AcceptedResponse?>.Default.Equals(ListenV1AcceptedResponse, other.ListenV1AcceptedResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListenV1MediaTranscribeResponse200 obj1, ListenV1MediaTranscribeResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListenV1MediaTranscribeResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListenV1MediaTranscribeResponse200 obj1, ListenV1MediaTranscribeResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListenV1MediaTranscribeResponse200 o && Equals(o);
        }
    }
}
