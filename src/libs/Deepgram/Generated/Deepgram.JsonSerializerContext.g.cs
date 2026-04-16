
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf0IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf0IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf1IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf1IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf2IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf2IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf3IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsOneOf3IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCallbackMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersSummarize0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersSummarize0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCustomTopicModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCustomTopicModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCustomIntentModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCustomIntentModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersEncodingJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersEncodingNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersModel0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersModel0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersRedactSchemaOneOf1ItemsJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersRedactSchemaOneOf1ItemsNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersVersion0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersVersion0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersCallbackMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersCallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersBitRate0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersBitRate0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer1JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer1NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer2JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer3JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer3NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer4JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainer4NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding1JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding1NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding2JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding3JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding3NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding4JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding4NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding5JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding5NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding6JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncoding6NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersModelJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersModelNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate1JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate1NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate2JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate3JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate3NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate4JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRate4NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCallbackMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersSummarize0JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersSummarize0NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCustomTopicModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCustomTopicModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCustomIntentModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCustomIntentModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdKeysGetParametersStatusJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdKeysGetParametersStatusNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersEndpointJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersEndpointNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersStatusJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdRequestsGetParametersStatusNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageGetParametersDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageGetParametersDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageGetParametersEndpointJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageGetParametersEndpointNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageGetParametersMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageGetParametersMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersGroupingJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersGroupingNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersEndpointJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersEndpointNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdUsageBreakdownGetParametersMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdBillingBreakdownGetParametersDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdBillingBreakdownGetParametersDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItemsJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItemsNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListBillingFieldsV1ResponseDeploymentsItemsJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListBillingFieldsV1ResponseDeploymentsItemsNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItemsJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItemsNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProviderJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProviderNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelsItemsJsonConverter),

            typeof(global::Deepgram.JsonConverters.ErrorResponseJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersExtraJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersSummarizeJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersTagJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCustomTopicJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersCustomIntentJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersDetectLanguageJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersKeywordsJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersModelJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersRedactJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersReplaceJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersSearchJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ListenPostParametersVersionJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeResponse200JsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersTagJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersBitRateJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersContainerJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersEncodingJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1SpeakPostParametersSampleRateJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersSummarizeJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersTagJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCustomTopicJsonConverter),

            typeof(global::Deepgram.JsonConverters.V1ReadPostParametersCustomIntentJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1RequestJsonConverter),

            typeof(global::Deepgram.JsonConverters.GetModelV1ResponseJsonConverter),

            typeof(global::Deepgram.JsonConverters.CreateKeyV1RequestJsonConverter),

            typeof(global::Deepgram.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf0Id), TypeInfoPropertyName = "AgentThinkModelsV1ResponseModelsItemsOneOf0Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf1Id), TypeInfoPropertyName = "AgentThinkModelsV1ResponseModelsItemsOneOf1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf2Id), TypeInfoPropertyName = "AgentThinkModelsV1ResponseModelsItemsOneOf2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItemsOneOf3Id), TypeInfoPropertyName = "AgentThinkModelsV1ResponseModelsItemsOneOf3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelsItems), TypeInfoPropertyName = "AgentThinkModelsV1ResponseModelsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.AgentThinkModelsV1ResponseModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseTextError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseLegacyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseModernError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponse), TypeInfoPropertyName = "ErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateAgentConfigurationV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateAgentConfigurationV1ResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateAgentConfigurationV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentConfigurationV1Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentConfigurationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListAgentConfigurationsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.AgentConfigurationV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateAgentMetadataV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteAgentConfigurationV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateAgentVariableV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentVariableV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListAgentVariablesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.AgentVariableV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateAgentVariableV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteAgentVariableV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCallbackMethod), TypeInfoPropertyName = "V1ListenPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersExtra), TypeInfoPropertyName = "V1ListenPostParametersExtra2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSummarize0), TypeInfoPropertyName = "V1ListenPostParametersSummarize02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSummarize), TypeInfoPropertyName = "V1ListenPostParametersSummarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersTag), TypeInfoPropertyName = "V1ListenPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomTopic), TypeInfoPropertyName = "V1ListenPostParametersCustomTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomTopicMode), TypeInfoPropertyName = "V1ListenPostParametersCustomTopicMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomIntent), TypeInfoPropertyName = "V1ListenPostParametersCustomIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersCustomIntentMode), TypeInfoPropertyName = "V1ListenPostParametersCustomIntentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersDetectLanguage), TypeInfoPropertyName = "V1ListenPostParametersDetectLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersEncoding), TypeInfoPropertyName = "V1ListenPostParametersEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersKeywords), TypeInfoPropertyName = "V1ListenPostParametersKeywords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersModel0), TypeInfoPropertyName = "V1ListenPostParametersModel02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersModel), TypeInfoPropertyName = "V1ListenPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items), TypeInfoPropertyName = "V1ListenPostParametersRedactSchemaOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersRedact), TypeInfoPropertyName = "V1ListenPostParametersRedact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersReplace), TypeInfoPropertyName = "V1ListenPostParametersReplace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersSearch), TypeInfoPropertyName = "V1ListenPostParametersSearch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersVersion0), TypeInfoPropertyName = "V1ListenPostParametersVersion02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ListenPostParametersVersion), TypeInfoPropertyName = "V1ListenPostParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1RequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataSummaryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataSentimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataTopicsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataIntentsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItemsSentencesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItemsSentencesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsUtterancesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopicsSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntentsSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentimentsSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentimentsAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentiments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedSentimentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1AcceptedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeResponse200), TypeInfoPropertyName = "ListenV1MediaTranscribeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersCallbackMethod), TypeInfoPropertyName = "V1SpeakPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersTag), TypeInfoPropertyName = "V1SpeakPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersBitRate0), TypeInfoPropertyName = "V1SpeakPostParametersBitRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersBitRate), TypeInfoPropertyName = "V1SpeakPostParametersBitRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer0), TypeInfoPropertyName = "V1SpeakPostParametersContainer02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer1), TypeInfoPropertyName = "V1SpeakPostParametersContainer12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer2), TypeInfoPropertyName = "V1SpeakPostParametersContainer22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer3), TypeInfoPropertyName = "V1SpeakPostParametersContainer32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer4), TypeInfoPropertyName = "V1SpeakPostParametersContainer42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersContainer), TypeInfoPropertyName = "V1SpeakPostParametersContainer2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding0), TypeInfoPropertyName = "V1SpeakPostParametersEncoding02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding1), TypeInfoPropertyName = "V1SpeakPostParametersEncoding12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding2), TypeInfoPropertyName = "V1SpeakPostParametersEncoding22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding3), TypeInfoPropertyName = "V1SpeakPostParametersEncoding32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding4), TypeInfoPropertyName = "V1SpeakPostParametersEncoding42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding5), TypeInfoPropertyName = "V1SpeakPostParametersEncoding52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding6), TypeInfoPropertyName = "V1SpeakPostParametersEncoding62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersEncoding), TypeInfoPropertyName = "V1SpeakPostParametersEncoding2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersModel), TypeInfoPropertyName = "V1SpeakPostParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate0), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate1), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate2), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate3), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate4), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1SpeakPostParametersSampleRate), TypeInfoPropertyName = "V1SpeakPostParametersSampleRate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCallbackMethod), TypeInfoPropertyName = "V1ReadPostParametersCallbackMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersSummarize0), TypeInfoPropertyName = "V1ReadPostParametersSummarize02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersSummarize), TypeInfoPropertyName = "V1ReadPostParametersSummarize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersTag), TypeInfoPropertyName = "V1ReadPostParametersTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomTopic), TypeInfoPropertyName = "V1ReadPostParametersCustomTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomTopicMode), TypeInfoPropertyName = "V1ReadPostParametersCustomTopicMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomIntent), TypeInfoPropertyName = "V1ReadPostParametersCustomIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ReadPostParametersCustomIntentMode), TypeInfoPropertyName = "V1ReadPostParametersCustomIntentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1RequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1RequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Request), TypeInfoPropertyName = "ReadV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataSummaryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataSentimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataTopicsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataIntentsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummaryResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummaryResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectsV1ResponseProjectsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectsV1ResponseProjectsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.LeaveProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1ResponseSttModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1ResponseTtsModelsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1ResponseTtsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseSttModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseTtsModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1Response0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1ResponseOneOf1Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1Response1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1Response), TypeInfoPropertyName = "GetModelV1Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdKeysGetParametersStatus), TypeInfoPropertyName = "V1ProjectsProjectIdKeysGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1ResponseApiKeysItemsMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1ResponseApiKeysItemsApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1ResponseApiKeysItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectKeysV1ResponseApiKeysItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateKeyV1Request), TypeInfoPropertyName = "CreateKeyV1Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateKeyV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1ResponseItemMemberApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1ResponseItemMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectKeyV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectMembersV1ResponseMembersItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectMembersV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectMembersV1ResponseMembersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectMemberV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectMemberScopesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectMemberScopesV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectMemberScopesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectInvitesV1ResponseInvitesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectInvitesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectInvitesV1ResponseInvitesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectInviteV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectInviteV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectInviteV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersDeployment), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersEndpoint), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersMethod), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdRequestsGetParametersStatus), TypeInfoPropertyName = "V1ProjectsProjectIdRequestsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ProjectRequestResponseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ProjectRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectRequestsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ProjectRequestResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectRequestV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageGetParametersDeployment), TypeInfoPropertyName = "V1ProjectsProjectIdUsageGetParametersDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageGetParametersEndpoint), TypeInfoPropertyName = "V1ProjectsProjectIdUsageGetParametersEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageGetParametersMethod), TypeInfoPropertyName = "V1ProjectsProjectIdUsageGetParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageV1ResponseResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageFieldsV1ResponseModelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageFieldsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.UsageFieldsV1ResponseModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersGrouping), TypeInfoPropertyName = "V1ProjectsProjectIdUsageBreakdownGetParametersGrouping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersDeployment), TypeInfoPropertyName = "V1ProjectsProjectIdUsageBreakdownGetParametersDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint), TypeInfoPropertyName = "V1ProjectsProjectIdUsageBreakdownGetParametersEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdUsageBreakdownGetParametersMethod), TypeInfoPropertyName = "V1ProjectsProjectIdUsageBreakdownGetParametersMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1ResponseResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1ResponseResultsItemsGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1ResponseResultsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.UsageBreakdownV1ResponseResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectBalancesV1ResponseBalancesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectBalancesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectBalancesV1ResponseBalancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectBalanceV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersDeployment), TypeInfoPropertyName = "V1ProjectsProjectIdBillingBreakdownGetParametersDeployment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems), TypeInfoPropertyName = "V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1ResponseResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1ResponseResultsItemsGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1ResponseResultsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.BillingBreakdownV1ResponseResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListBillingFieldsV1ResponseDeploymentsItems), TypeInfoPropertyName = "ListBillingFieldsV1ResponseDeploymentsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListBillingFieldsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListBillingFieldsV1ResponseDeploymentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectPurchasesV1ResponseOrdersItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectPurchasesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectPurchasesV1ResponseOrdersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItemsDistributionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems), TypeInfoPropertyName = "V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider), TypeInfoPropertyName = "V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1ResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1ResponseDistributionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectDistributionCredentialsV1ResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectDistributionCredentialsV1ResponseDistributionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectDistributionCredentialsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GrantV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GrantV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.AgentThinkModelsV1ResponseModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.AgentConfigurationV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.AgentVariableV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.V1ListenPostParametersRedactSchemaOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItemsHitsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItemsSentencesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsParagraphsParagraphsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsSummariesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsSearchItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItemsAlternativesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsUtterancesItemsWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsUtterancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentsItemsTopicsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentsItemsIntentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedSentimentsSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectsV1ResponseProjectsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListModelsV1ResponseSttModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListModelsV1ResponseTtsModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectKeysV1ResponseApiKeysItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectMembersV1ResponseMembersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectInvitesV1ResponseInvitesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ProjectRequestResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.UsageFieldsV1ResponseModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.UsageBreakdownV1ResponseResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectBalancesV1ResponseBalancesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.BillingBreakdownV1ResponseResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListBillingFieldsV1ResponseDeploymentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectPurchasesV1ResponseOrdersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.V1ProjectsProjectIdBillingBreakdownGetParametersGroupingSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.V1ProjectsProjectIdSelfHostedDistributionCredentialsPostParametersScopesSchemaItems>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}