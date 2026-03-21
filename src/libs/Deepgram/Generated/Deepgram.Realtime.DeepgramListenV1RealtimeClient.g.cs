
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Transcribe audio and video using Deepgram's speech-to-text WebSocket
    /// </summary>
    public sealed partial class DeepgramListenV1RealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.deepgram.com/v1/listen";

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
        /// Creates a new instance of the DeepgramListenV1RealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public DeepgramListenV1RealtimeClient(
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
        public DeepgramListenV1RealtimeClient(
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
        /// <param name="callback">URL to which we'll make the callback request</param>
        /// <param name="callbackMethod">HTTP method by which the callback request will be made</param>
        /// <param name="channels">The number of channels in the submitted audio</param>
        /// <param name="detectEntities">Identifies and extracts key entities from content in submitted audio. Entities appear in final results. When enabled, Punctuation will also be enabled by default</param>
        /// <param name="diarize">Defaults to `false`. Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0</param>
        /// <param name="dictation">Identify and extract key entities from content in submitted audio</param>
        /// <param name="encoding">Specify the expected encoding of your submitted audio</param>
        /// <param name="endpointing">Indicates how long Deepgram will wait to detect whether a speaker has finished speaking or pauses for a significant period of time. When set to a value, the streaming endpoint immediately finalizes the transcription for the processed time range and returns the transcript with a speech_final parameter set to true. Can also be set to false to disable endpointing</param>
        /// <param name="extra">Arbitrary key-value pairs that are attached to the API response for usage in downstream processing</param>
        /// <param name="interimResults">Specifies whether the streaming endpoint should provide ongoing transcription updates as more audio is received. When set to true, the endpoint sends continuous updates, meaning transcription results may evolve over time</param>
        /// <param name="keyterm">Key term prompting can boost specialized terminology and brands. Only compatible with Nova-3</param>
        /// <param name="keywords">Keywords can boost or suppress specialized terminology and brands</param>
        /// <param name="language">The [BCP-47 language tag](https://tools.ietf.org/html/bcp47) that hints at the primary spoken language. Depending on the Model you choose only certain languages are available</param>
        /// <param name="mipOptOut">Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip</param>
        /// <param name="model">AI model to use for the transcription</param>
        /// <param name="multichannel">Transcribe each audio channel independently</param>
        /// <param name="numerals">Convert numbers from written format to numerical format</param>
        /// <param name="profanityFilter">Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely</param>
        /// <param name="punctuate">Add punctuation and capitalization to the transcript</param>
        /// <param name="redact">Redaction removes sensitive information from your transcripts</param>
        /// <param name="replace">Search for terms or phrases in submitted audio and replaces them</param>
        /// <param name="sampleRate">Sample rate of submitted audio. Required (and only read) when a value is provided for encoding</param>
        /// <param name="search">Search for terms or phrases in submitted audio</param>
        /// <param name="smartFormat">Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability</param>
        /// <param name="tag">Label your requests for the purpose of identification during usage reporting</param>
        /// <param name="utteranceEndMs">Indicates how long Deepgram will wait to send an UtteranceEnd message after a word has been transcribed. Use with interim_results</param>
        /// <param name="vadEvents">Indicates that speech has started. You'll begin receiving Speech Started messages upon speech starting</param>
        /// <param name="version">Version of an AI model to use</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            object? callback = default,
            global::Deepgram.Realtime.ListenV1CallbackMethod? callbackMethod = default,
            object? channels = default,
            global::Deepgram.Realtime.ListenV1DetectEntities? detectEntities = default,
            global::Deepgram.Realtime.ListenV1Diarize? diarize = default,
            global::Deepgram.Realtime.ListenV1Dictation? dictation = default,
            global::Deepgram.Realtime.ListenV1Encoding? encoding = default,
            object? endpointing = default,
            object? extra = default,
            global::Deepgram.Realtime.ListenV1InterimResults? interimResults = default,
            object? keyterm = default,
            object? keywords = default,
            object? language = default,
            object? mipOptOut = default,
            global::Deepgram.Realtime.ListenV1Model? model = default,
            global::Deepgram.Realtime.ListenV1Multichannel? multichannel = default,
            global::Deepgram.Realtime.ListenV1Numerals? numerals = default,
            global::Deepgram.Realtime.ListenV1ProfanityFilter? profanityFilter = default,
            global::Deepgram.Realtime.ListenV1Punctuate? punctuate = default,
            global::Deepgram.Realtime.ListenV1Redact? redact = default,
            object? replace = default,
            object? sampleRate = default,
            object? search = default,
            global::Deepgram.Realtime.ListenV1SmartFormat? smartFormat = default,
            object? tag = default,
            object? utteranceEndMs = default,
            global::Deepgram.Realtime.ListenV1VadEvents? vadEvents = default,
            object? version = default,
            global::System.Uri? uri = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __pathBuilder = new global::Deepgram.Realtime.PathBuilder(
                path: uri?.ToString() ?? DefaultBaseUrl);
            __pathBuilder
                .AddOptionalParameter("callback", callback?.ToString())
                .AddOptionalParameter("callback_method", callbackMethod?.ToValueString())
                .AddOptionalParameter("channels", channels?.ToString())
                .AddOptionalParameter("detect_entities", detectEntities?.ToValueString())
                .AddOptionalParameter("diarize", diarize?.ToValueString())
                .AddOptionalParameter("dictation", dictation?.ToValueString())
                .AddOptionalParameter("encoding", encoding?.ToValueString())
                .AddOptionalParameter("endpointing", endpointing?.ToString())
                .AddOptionalParameter("extra", extra?.ToString())
                .AddOptionalParameter("interim_results", interimResults?.ToValueString())
                .AddOptionalParameter("keyterm", keyterm?.ToString())
                .AddOptionalParameter("keywords", keywords?.ToString())
                .AddOptionalParameter("language", language?.ToString())
                .AddOptionalParameter("mip_opt_out", mipOptOut?.ToString())
                .AddOptionalParameter("model", model?.ToValueString())
                .AddOptionalParameter("multichannel", multichannel?.ToValueString())
                .AddOptionalParameter("numerals", numerals?.ToValueString())
                .AddOptionalParameter("profanity_filter", profanityFilter?.ToValueString())
                .AddOptionalParameter("punctuate", punctuate?.ToValueString())
                .AddOptionalParameter("redact", redact?.ToValueString())
                .AddOptionalParameter("replace", replace?.ToString())
                .AddOptionalParameter("sample_rate", sampleRate?.ToString())
                .AddOptionalParameter("search", search?.ToString())
                .AddOptionalParameter("smart_format", smartFormat?.ToValueString())
                .AddOptionalParameter("tag", tag?.ToString())
                .AddOptionalParameter("utterance_end_ms", utteranceEndMs?.ToString())
                .AddOptionalParameter("vad_events", vadEvents?.ToValueString())
                .AddOptionalParameter("version", version?.ToString())
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