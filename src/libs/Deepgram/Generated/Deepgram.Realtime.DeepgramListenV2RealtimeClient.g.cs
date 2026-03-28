
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Real-time conversational speech recognition with contextual turn detection<br/>
    /// for natural voice conversations
    /// </summary>
    public sealed partial class DeepgramListenV2RealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.deepgram.com/v2/listen";

        private readonly global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;

        /// <summary>
        /// 
        /// </summary>

        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Deepgram.Realtime.RealtimeSourceGenerationContext.Default;

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the DeepgramListenV2RealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public DeepgramListenV2RealtimeClient(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }


        /// <summary>
        /// Authorize using Bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader("Authorization", $"Bearer {apiKey}");
        }

        /// <summary>
        /// Creates a new instance with Bearer token authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientWebSocket"></param>
        public DeepgramListenV2RealtimeClient(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_clientWebSocket);
        }



        /// <summary>
        /// Connects to the WebSocket server with typed query parameters.
        /// </summary>
        /// <param name="model">Defines the AI model used to process submitted audio.</param>
        /// <param name="eagerEotThreshold">End-of-turn confidence required to fire an eager end-of-turn event. When set, enables `EagerEndOfTurn` and `TurnResumed` events. Valid Values 0.3 - 0.9.</param>
        /// <param name="encoding">Encoding of the audio stream. Required if sending non-containerized/raw audio. If sending containerized audio, this parameter should be omitted.</param>
        /// <param name="eotThreshold">End-of-turn confidence required to finish a turn. Valid Values 0.5 - 0.9.</param>
        /// <param name="eotTimeoutMs">A turn will be finished when this much time has passed after speech, regardless of EOT confidence.</param>
        /// <param name="keyterm">Keyterm prompting can improve recognition of specialized terminology. Pass multiple keyterm query parameters to boost multiple keyterms.</param>
        /// <param name="mipOptOut">Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip</param>
        /// <param name="sampleRate">Sample rate of the audio stream in Hz. Required if sending non-containerized/raw audio. If sending containerized audio, this parameter should be omitted.</param>
        /// <param name="tag">Label your requests for the purpose of identification during usage reporting</param>
        /// <param name="uri">Optional WebSocket endpoint override.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::Deepgram.Realtime.ListenV2Model model,
            global::Deepgram.Realtime.ListenV2EagerEotThreshold? eagerEotThreshold = default,
            global::Deepgram.Realtime.ListenV2Encoding? encoding = default,
            global::Deepgram.Realtime.ListenV2EotThreshold? eotThreshold = default,
            global::Deepgram.Realtime.ListenV2EotTimeoutMs? eotTimeoutMs = default,
            global::Deepgram.Realtime.ListenV2Keyterm? keyterm = default,
            global::Deepgram.Realtime.ListenV2MipOptOut? mipOptOut = default,
            global::Deepgram.Realtime.ListenV2SampleRate? sampleRate = default,
            global::Deepgram.Realtime.ListenV2Tag? tag = default,
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __pathBuilder = new global::Deepgram.Realtime.PathBuilder(
                path: uri?.ToString() ?? DefaultBaseUrl);
            __pathBuilder
                .AddRequiredParameter("model", model.ToValueString())
                .AddOptionalParameter("eager_eot_threshold", eagerEotThreshold?.ToString())
                .AddOptionalParameter("encoding", encoding?.ToValueString())
                .AddOptionalParameter("eot_threshold", eotThreshold?.ToString())
                .AddOptionalParameter("eot_timeout_ms", eotTimeoutMs?.ToString())
                .AddOptionalParameter("keyterm", keyterm?.ToString())
                .AddOptionalParameter("mip_opt_out", mipOptOut?.ToString())
                .AddOptionalParameter("sample_rate", sampleRate?.ToString())
                .AddOptionalParameter("tag", tag?.ToString())
                ;
            var __path = __pathBuilder.ToString();

            await _clientWebSocket.ConnectAsync(
                new global::System.Uri(__path), cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc cref="global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            uri ??= new global::System.Uri(DefaultBaseUrl);

            await _clientWebSocket.ConnectAsync(uri, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _clientWebSocket.Dispose();
        }

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {
            if (IsConnected)
            {
                try
                {
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: "Closing",
                        cancellationToken: default).ConfigureAwait(false);
                }
                catch (global::System.Net.WebSockets.WebSocketException)
                {
                    // Ignore errors during dispose
                }
            }
            _clientWebSocket.Dispose();
        }

        partial void Initialized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void Authorizing(
            global::System.Net.WebSockets.ClientWebSocket client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareArguments(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareRequest(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}