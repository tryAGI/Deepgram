
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
            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant1IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant1IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant2IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant2IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant3IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant3IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant4IdJsonConverter),

            typeof(global::Deepgram.JsonConverters.AgentThinkModelsV1ResponseModelVariant4IdNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListBillingFieldsV1ResponseDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListBillingFieldsV1ResponseDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeCallbackMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeCallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeSummarize2JsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeSummarize2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomTopicModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomTopicModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomIntentModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeCustomIntentModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeEncodingJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeEncodingNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeModel2JsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeModel2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeRedactVariant2ItemJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeRedactVariant2ItemNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeVersion2JsonConverter),

            typeof(global::Deepgram.JsonConverters.ListenV1MediaTranscribeVersion2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListGroupingItemJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsBillingBreakdownListGroupingItemNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsKeysListStatusJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsKeysListStatusNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListEndpointJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListEndpointNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListStatusJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsRequestsListStatusNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateScopeJsonConverter),

            typeof(global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateScopeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateProviderJsonConverter),

            typeof(global::Deepgram.JsonConverters.SelfHostedV1DistributionCredentialsCreateProviderNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetEndpointJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetEndpointNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageGetMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetGroupingJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetGroupingNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetDeploymentJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetDeploymentNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetEndpointJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetEndpointNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.ManageV1ProjectsUsageBreakdownGetMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeCallbackMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeCallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeSummarize2JsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeSummarize2NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomTopicModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomTopicModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomIntentModeJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1TextAnalyzeCustomIntentModeNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateCallbackMethodJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateCallbackMethodNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerNoneJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerNoneNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerLinear16JsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerLinear16NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerMulawJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerMulawNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerAlawJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerAlawNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerOpusJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateContainerOpusNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingLinear16JsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingLinear16NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingFlacJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingFlacNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMulawJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMulawNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAlawJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAlawNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMp3JsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingMp3NullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingOpusJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingOpusNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAacJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateEncodingAacNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateModelJsonConverter),

            typeof(global::Deepgram.JsonConverters.SpeakV1AudioGenerateModelNullableJsonConverter),

            typeof(global::Deepgram.JsonConverters.ErrorResponseJsonConverter),

            typeof(global::Deepgram.JsonConverters.GetModelV1ResponseJsonConverter),

            typeof(global::Deepgram.JsonConverters.ReadV1RequestJsonConverter),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1MediaTranscribeModel2?, string>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>),

            typeof(global::Deepgram.JsonConverters.OneOfJsonConverter<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>),

            typeof(global::Deepgram.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.OneOf<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant1Id))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant2Id))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant3Id))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant4Id))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.AgentThinkModelsV1ResponseModelVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseTextError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseLegacyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponseModernError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GrantV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GrantV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1RequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataSummaryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataSentimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataTopicsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseMetadataIntentsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelSearchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelSearchItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelSearchItemHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelSearchItemHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternative))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraphSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraphSentence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeEntitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeSummarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeSummarie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsChannelAlternativeTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsChannelAlternativeTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1ResponseResultsUtteranceWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsUtteranceWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopicsSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedTopicsResultsTopicsSegmentTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedTopicsResultsTopicsSegmentTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntentsSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedIntentsResultsIntentsSegmentIntent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedIntentsResultsIntentsSegmentIntent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentiments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SharedSentimentsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentimentsSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SharedSentimentsAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1ResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1AcceptedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1ResponseSttModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1ResponseTtsModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1ResponseTtsModelsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListModelsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseSttModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListModelsV1ResponseTtsModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1ResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1ResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetModelV1ResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectsV1ResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectsV1ResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectBalancesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectBalancesV1ResponseBalance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectBalancesV1ResponseBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectBalanceV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1ResponseResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.BillingBreakdownV1ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.BillingBreakdownV1ResponseResultGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListBillingFieldsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListBillingFieldsV1ResponseDeployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListBillingFieldsV1ResponseDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectInvitesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectInvitesV1ResponseInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectInvitesV1ResponseInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectInviteV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectInviteV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectInviteV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectKeysV1ResponseApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1ResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1ResponseApiKeyMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectKeysV1ResponseApiKeyApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateKeyV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateKeyV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1ResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1ResponseItemMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectKeyV1ResponseItemMemberApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectKeyV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.LeaveProjectV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectMembersV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectMembersV1ResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectMembersV1ResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.DeleteProjectMemberV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectMemberScopesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectMemberScopesV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UpdateProjectMemberScopesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectPurchasesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectPurchasesV1ResponseOrder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectPurchasesV1ResponseOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ProjectRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectRequestsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ProjectRequestResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectRequestV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredentialDistributionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1ResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.CreateProjectDistributionCredentialsV1ResponseDistributionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectDistributionCredentialsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectDistributionCredentialsV1ResponseMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.GetProjectDistributionCredentialsV1ResponseDistributionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageV1ResponseResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1ResponseResolution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.UsageBreakdownV1ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageBreakdownV1ResponseResultGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageFieldsV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.UsageFieldsV1ResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.UsageFieldsV1ResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1RequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1RequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataSummaryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataSentimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataTopicsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseMetadataMetadataIntentsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummaryResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResultsSummaryResultsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1ResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeCallbackMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeSummarize2?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeSummarize2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeCustomTopicMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeCustomIntentMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<bool?, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeEncoding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeModel2?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeModel2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<string, global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.ListenV1MediaTranscribeVersion2?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ListenV1MediaTranscribeVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsBillingBreakdownListDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsKeysListStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsRequestsListDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsRequestsListEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsRequestsListMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsRequestsListStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.SelfHostedV1DistributionCredentialsCreateScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SelfHostedV1DistributionCredentialsCreateScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SelfHostedV1DistributionCredentialsCreateProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageGetDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageGetEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageGetMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageBreakdownGetGrouping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageBreakdownGetDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageBreakdownGetEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ManageV1ProjectsUsageBreakdownGetMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1TextAnalyzeCallbackMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.ReadV1TextAnalyzeSummarize2?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1TextAnalyzeSummarize2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1TextAnalyzeCustomTopicMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.ReadV1TextAnalyzeCustomIntentMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateCallbackMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateContainerNone?, global::Deepgram.SpeakV1AudioGenerateContainerLinear16?, global::Deepgram.SpeakV1AudioGenerateContainerMulaw?, global::Deepgram.SpeakV1AudioGenerateContainerAlaw?, global::Deepgram.SpeakV1AudioGenerateContainerOpus?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateContainerNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateContainerLinear16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateContainerMulaw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateContainerAlaw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateContainerOpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.SpeakV1AudioGenerateEncodingLinear16?, global::Deepgram.SpeakV1AudioGenerateEncodingFlac?, global::Deepgram.SpeakV1AudioGenerateEncodingMulaw?, global::Deepgram.SpeakV1AudioGenerateEncodingAlaw?, global::Deepgram.SpeakV1AudioGenerateEncodingMp3?, global::Deepgram.SpeakV1AudioGenerateEncodingOpus?, global::Deepgram.SpeakV1AudioGenerateEncodingAac?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingLinear16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingFlac))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingMulaw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingAlaw))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingMp3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingOpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateEncodingAac))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.SpeakV1AudioGenerateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<global::Deepgram.ListenV1Response, global::Deepgram.ListenV1AcceptedResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.OneOf<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelSearchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelSearchItemHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternativeWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternativeParagraphsParagraphSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternativeEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternativeSummarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsChannelAlternativeTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1ResponseResultsUtteranceWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedTopicsResultsTopicsSegmentTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedIntentsResultsIntentsSegmentIntent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SharedSentimentsSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListModelsV1ResponseSttModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListModelsV1ResponseTtsModels>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectsV1ResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectBalancesV1ResponseBalance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.BillingBreakdownV1ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListBillingFieldsV1ResponseDeployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectInvitesV1ResponseInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectKeysV1ResponseApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectMembersV1ResponseMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectPurchasesV1ResponseOrder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ProjectRequestResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListProjectDistributionCredentialsV1ResponseDistributionCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.UsageBreakdownV1ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.UsageFieldsV1ResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<bool?, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.OneOf<string, global::System.Collections.Generic.List<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ListenV1MediaTranscribeRedactVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.ManageV1ProjectsBillingBreakdownListGroupingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.SelfHostedV1DistributionCredentialsCreateScope>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}