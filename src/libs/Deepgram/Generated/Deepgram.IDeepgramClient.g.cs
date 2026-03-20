
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
        /// Authentication operations
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// Speech-to-text transcription
        /// </summary>
        public ListenClient Listen { get; }

        /// <summary>
        /// Text analysis
        /// </summary>
        public ReadClient Read { get; }

        /// <summary>
        /// Text-to-speech generation
        /// </summary>
        public SpeakClient Speak { get; }

        /// <summary>
        /// Project and account management
        /// </summary>
        public ManageClient Manage { get; }

        /// <summary>
        /// AI agent operations
        /// </summary>
        public AgentClient Agent { get; }

        /// <summary>
        /// On-premise deployments
        /// </summary>
        public SelfHostedClient SelfHosted { get; }

        /// <summary>
        /// 
        /// </summary>
        public V1Client V1 { get; }

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings { get; }

        /// <summary>
        /// 
        /// </summary>
        public ThinkClient Think { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public MediaClient Media { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public BalancesClient Balances { get; }

        /// <summary>
        /// 
        /// </summary>
        public BreakdownClient Breakdown { get; }

        /// <summary>
        /// 
        /// </summary>
        public FieldsClient Fields { get; }

        /// <summary>
        /// 
        /// </summary>
        public MembersClient Members { get; }

        /// <summary>
        /// 
        /// </summary>
        public InvitesClient Invites { get; }

        /// <summary>
        /// 
        /// </summary>
        public KeysClient Keys { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScopesClient Scopes { get; }

        /// <summary>
        /// 
        /// </summary>
        public PurchasesClient Purchases { get; }

        /// <summary>
        /// 
        /// </summary>
        public RequestsClient Requests { get; }

        /// <summary>
        /// 
        /// </summary>
        public DistributionCredentialsClient DistributionCredentials { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextClient Text { get; }

    }
}