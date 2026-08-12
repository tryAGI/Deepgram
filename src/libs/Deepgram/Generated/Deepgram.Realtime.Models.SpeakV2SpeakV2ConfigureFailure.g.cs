
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2ConfigureFailure
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2ConfigureFailureTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailureType Type { get; set; }

        /// <summary>
        /// Failure code, in `SCREAMING_SNAKE_CASE`. `SPEED_OUT_OF_RANGE`: outside the multipliers the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but not one of the multipliers. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode Code { get; set; }

        /// <summary>
        /// The configuration field the failure is about. Absent when the failure is not tied to one field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsSpeakV2MessagesSpeakV2ConfigureFailureFieldJsonConverter))]
        public global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField? Field { get; set; }

        /// <summary>
        /// The rejected value for `field`. Absent when there is no offending value to echo — `SPEED_NOT_SUPPORTED` names the field but carries no value, because the rejection is a property of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// A human-readable description of the failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2ConfigureFailure" /> class.
        /// </summary>
        /// <param name="code">
        /// Failure code, in `SCREAMING_SNAKE_CASE`. `SPEED_OUT_OF_RANGE`: outside the multipliers the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but not one of the multipliers. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
        /// </param>
        /// <param name="description">
        /// A human-readable description of the failure
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="field">
        /// The configuration field the failure is about. Absent when the failure is not tied to one field.
        /// </param>
        /// <param name="value">
        /// The rejected value for `field`. Absent when there is no offending value to echo — `SPEED_NOT_SUPPORTED` names the field but carries no value, because the rejection is a property of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2ConfigureFailure(
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode code,
            string description,
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureFailureType type,
            global::Deepgram.Realtime.ChannelsSpeakV2MessagesSpeakV2ConfigureFailureField? field,
            double? value)
        {
            this.Type = type;
            this.Code = code;
            this.Field = field;
            this.Value = value;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2ConfigureFailure" /> class.
        /// </summary>
        public SpeakV2SpeakV2ConfigureFailure()
        {
        }

    }
}