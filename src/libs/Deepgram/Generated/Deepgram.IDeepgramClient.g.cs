
#nullable enable

namespace Deepgram
{
    /// <summary>
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
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Deepgram.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Deepgram.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Deepgram.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentSubpackageAgentV1SubpackageAgentV1SettingsSubpackageAgentV1SettingsThinkSubpackageAgentV1SettingsThinkModelsClient SubpackageAgentSubpackageAgentV1SubpackageAgentV1SettingsSubpackageAgentV1SettingsThinkSubpackageAgentV1SettingsThinkModels { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAuthSubpackageAuthV1SubpackageAuthV1TokensClient SubpackageAuthSubpackageAuthV1SubpackageAuthV1Tokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageListenSubpackageListenV1SubpackageListenV1MediaClient SubpackageListenSubpackageListenV1SubpackageListenV1Media { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ModelsClient SubpackageManageSubpackageManageV1SubpackageManageV1Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsClient SubpackageManageSubpackageManageV1SubpackageManageV1Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBalancesClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBalances { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBreakdownClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingBreakdown { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingFieldsClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingFields { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingPurchasesClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsBillingSubpackageManageV1ProjectsBillingPurchases { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsKeysClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersInvitesClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersInvites { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopesClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsMembersSubpackageManageV1ProjectsMembersScopes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsModelsClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsModels { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsRequestsClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsRequests { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsage { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdownClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageBreakdown { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageFieldsClient SubpackageManageSubpackageManageV1SubpackageManageV1ProjectsSubpackageManageV1ProjectsUsageSubpackageManageV1ProjectsUsageFields { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageReadSubpackageReadV1SubpackageReadV1TextClient SubpackageReadSubpackageReadV1SubpackageReadV1Text { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentialsClient SubpackageSelfHostedSubpackageSelfHostedV1SubpackageSelfHostedV1DistributionCredentials { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageSpeakSubpackageSpeakV1SubpackageSpeakV1AudioClient SubpackageSpeakSubpackageSpeakV1SubpackageSpeakV1Audio { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageVoiceAgentSubpackageVoiceAgentConfigurationsClient SubpackageVoiceAgentSubpackageVoiceAgentConfigurations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageVoiceAgentSubpackageVoiceAgentVariablesClient SubpackageVoiceAgentSubpackageVoiceAgentVariables { get; }

    }
}