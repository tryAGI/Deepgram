#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ListenV1ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ListenV1ServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ListenV1ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ListenV1ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Deepgram.Realtime.ResultsPayload? results = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.Results)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ResultsPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ResultsPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ResultsPayload)}");
                results = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.MetadataPayload? metadata = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.Metadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.MetadataPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.MetadataPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.MetadataPayload)}");
                metadata = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.UtteranceEndPayload? utteranceEnd = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.UtteranceEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.UtteranceEndPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.UtteranceEndPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.UtteranceEndPayload)}");
                utteranceEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.SpeechStartedPayload? speechStarted = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.SpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeechStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeechStartedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.SpeechStartedPayload)}");
                speechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Deepgram.Realtime.ListenV1ServerEvent(
                discriminator?.Type,
                results,

                metadata,

                utteranceEnd,

                speechStarted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ListenV1ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ResultsPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ResultsPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ResultsPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Results, typeInfo);
            }
            else if (value.IsMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.MetadataPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.MetadataPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.MetadataPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Metadata, typeInfo);
            }
            else if (value.IsUtteranceEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.UtteranceEndPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.UtteranceEndPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.UtteranceEndPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UtteranceEnd, typeInfo);
            }
            else if (value.IsSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.SpeechStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.SpeechStartedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.SpeechStartedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechStarted, typeInfo);
            }
        }
    }
}