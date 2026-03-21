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

            global::Deepgram.Realtime.ListenV1ResultsEvent? results = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.Results)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ListenV1ResultsEvent)}");
                results = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.ListenV1MetadataEvent? metadata = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.Metadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1MetadataEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1MetadataEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ListenV1MetadataEvent)}");
                metadata = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.ListenV1UtteranceEndEvent? utteranceEnd = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.UtteranceEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1UtteranceEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1UtteranceEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ListenV1UtteranceEndEvent)}");
                utteranceEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.ListenV1SpeechStartedEvent? speechStarted = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV1ServerEventDiscriminatorType.SpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1SpeechStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1SpeechStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ListenV1SpeechStartedEvent)}");
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1ResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1ResultsEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1ResultsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Results, typeInfo);
            }
            else if (value.IsMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1MetadataEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1MetadataEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1MetadataEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Metadata, typeInfo);
            }
            else if (value.IsUtteranceEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1UtteranceEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1UtteranceEndEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1UtteranceEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UtteranceEnd, typeInfo);
            }
            else if (value.IsSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV1SpeechStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV1SpeechStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.ListenV1SpeechStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechStarted, typeInfo);
            }
        }
    }
}