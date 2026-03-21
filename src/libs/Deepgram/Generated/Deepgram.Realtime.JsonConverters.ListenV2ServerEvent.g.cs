#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Deepgram.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ListenV2ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Deepgram.Realtime.ListenV2ServerEvent>
    {
        /// <inheritdoc />
        public override global::Deepgram.Realtime.ListenV2ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.ListenV2ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.ListenV2ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.ListenV2ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Deepgram.Realtime.V2ConnectedPayload? connected = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType.Connected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2ConnectedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2ConnectedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.V2ConnectedPayload)}");
                connected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.V2TurnInfoPayload? turnInfo = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType.TurnInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2TurnInfoPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2TurnInfoPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.V2TurnInfoPayload)}");
                turnInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.V2ConfigureSuccessPayload? configureSuccess = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType.ConfigureSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2ConfigureSuccessPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2ConfigureSuccessPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.V2ConfigureSuccessPayload)}");
                configureSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Deepgram.Realtime.V2ConfigureFailurePayload? configureFailure = default;
            if (discriminator?.Type == global::Deepgram.Realtime.ListenV2ServerEventDiscriminatorType.ConfigureFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2ConfigureFailurePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2ConfigureFailurePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Deepgram.Realtime.V2ConfigureFailurePayload)}");
                configureFailure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Deepgram.Realtime.ListenV2ServerEvent(
                discriminator?.Type,
                connected,

                turnInfo,

                configureSuccess,

                configureFailure
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Deepgram.Realtime.ListenV2ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2ConnectedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2ConnectedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.V2ConnectedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Connected, typeInfo);
            }
            else if (value.IsTurnInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2TurnInfoPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2TurnInfoPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.V2TurnInfoPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TurnInfo, typeInfo);
            }
            else if (value.IsConfigureSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2ConfigureSuccessPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2ConfigureSuccessPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.V2ConfigureSuccessPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConfigureSuccess, typeInfo);
            }
            else if (value.IsConfigureFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Deepgram.Realtime.V2ConfigureFailurePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Deepgram.Realtime.V2ConfigureFailurePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Deepgram.Realtime.V2ConfigureFailurePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConfigureFailure, typeInfo);
            }
        }
    }
}