
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Configure
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2ConfigureTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureType Type { get; set; }

        /// <summary>
        /// Speech-rate multiplier. `1.0` is the model's nominal rate; lower is slower. Accepted values run `0.5` to `1.5` in `0.05` increments. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Configure" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="speed">
        /// Speech-rate multiplier. `1.0` is the model's nominal rate; lower is slower. Accepted values run `0.5` to `1.5` in `0.05` increments. A value outside that range is rejected with `SPEED_OUT_OF_RANGE`; a value inside it but off the `0.05` increment with `SPEED_INCREMENT_INVALID`. Models and languages without runtime speed control reject any value with `SPEED_NOT_SUPPORTED`.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Configure(
            global::Deepgram.Realtime.SpeakV2SpeakV2ConfigureType type,
            double? speed)
        {
            this.Type = type;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Configure" /> class.
        /// </summary>
        public SpeakV2SpeakV2Configure()
        {
        }

    }
}