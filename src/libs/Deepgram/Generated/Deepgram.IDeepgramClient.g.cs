
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// APIs for speech-to-text transcription, text-to-speech synthesis, language understanding, and account management.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDeepgramClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Deepgram.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// AI agent operations
        /// </summary>
        public AgentClient Agent { get; }

        /// <summary>
        /// Authentication operations
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// Speech-to-text transcription
        /// </summary>
        public ListenClient Listen { get; }

        /// <summary>
        /// Project and account management
        /// </summary>
        public ManageClient Manage { get; }

        /// <summary>
        /// Text analysis
        /// </summary>
        public ReadClient Read { get; }

        /// <summary>
        /// On-premise deployments
        /// </summary>
        public SelfHostedClient SelfHosted { get; }

        /// <summary>
        /// Text-to-speech generation
        /// </summary>
        public SpeakClient Speak { get; }

    }
}