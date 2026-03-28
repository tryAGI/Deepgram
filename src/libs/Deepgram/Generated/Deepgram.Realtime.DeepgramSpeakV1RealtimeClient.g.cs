#pragma warning disable CS1573 // Missing XML comment for publicly visible type or member

#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Convert text into natural-sounding speech using Deepgram's TTS WebSocket
    /// </summary>
    public sealed partial class DeepgramSpeakV1RealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.deepgram.com/v1/speak";

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
        /// Creates a new instance of the DeepgramSpeakV1RealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public DeepgramSpeakV1RealtimeClient(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }


        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _clientWebSocket.Options.SetRequestHeader("Authorization", $"Bearer {apiKey}");
        }

        /// <summary>
        /// Creates a new instance with bearer token authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientWebSocket"></param>
        public DeepgramSpeakV1RealtimeClient(
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
        /// <param name="encoding">Encoding allows you to specify the expected encoding of your audio output for streaming TTS. Only streaming-compatible encodings are supported.</param>
        /// <param name="mipOptOut">Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip</param>
        /// <param name="model">AI model used to process submitted text</param>
        /// <param name="sampleRate">Sample Rate specifies the sample rate for the output audio. Based on encoding 8000 or 24000 are possible defaults. For some encodings sample rate is not configurable.</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::Deepgram.Realtime.SpeakV1Encoding? encoding = default,
            object? mipOptOut = default,
            global::Deepgram.Realtime.SpeakV1Model? model = default,
            global::Deepgram.Realtime.SpeakV1SampleRate? sampleRate = default,
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __pathBuilder = new global::Deepgram.Realtime.PathBuilder(
                path: uri?.ToString() ?? DefaultBaseUrl);
            __pathBuilder
                .AddOptionalParameter("encoding", encoding?.ToValueString())
                .AddOptionalParameter("mip_opt_out", mipOptOut?.ToString())
                .AddOptionalParameter("model", model?.ToValueString())
                .AddOptionalParameter("sample_rate", sampleRate?.ToValueString())
                ;
            var __path = __pathBuilder.ToString();

            await _clientWebSocket.ConnectAsync(
                new global::System.Uri(__path), cancellationToken).ConfigureAwait(false);
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