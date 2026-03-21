
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Deepgram.Realtime.JsonConverters.FinalizePayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.FinalizePayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CloseStreamPayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.CloseStreamPayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.KeepAlivePayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.KeepAlivePayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ResultsPayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ResultsPayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.MetadataPayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.MetadataPayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.UtteranceEndPayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.UtteranceEndPayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeechStartedPayloadTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.SpeechStartedPayloadTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV1ServerEventJsonConverter),

            typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.FinalizePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.FinalizePayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CloseStreamPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.CloseStreamPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.KeepAlivePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.KeepAlivePayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ResultsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ResultsPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.Channel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.Alternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.Alternative))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.Word))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.MetadataPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.MetadataPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.UtteranceEndPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.UtteranceEndPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeechStartedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.SpeechStartedPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.V2CloseStreamPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.V2ConnectedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.V2TurnInfoPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Deepgram.Realtime.V2Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.V2Word))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.V2ConfigureSuccessPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.V2ConfigureFailurePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ServerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Deepgram.Realtime.ListenV2ServerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.Alternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Deepgram.Realtime.V2Word>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}