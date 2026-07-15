
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakV2SpeakV2Warning
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.SpeakV2SpeakV2WarningTypeJsonConverter))]
        public global::Deepgram.Realtime.SpeakV2SpeakV2WarningType Type { get; set; }

        /// <summary>
        /// Warning code identifying the condition, in `SCREAMING_SNAKE_CASE`. Early Access codes are `NO_ACTIVE_SPEECH` (a speech-scoped message arrived with no active turn) and `SYNTHESIS_RETRYING` (a synthesis request failed and is being retried).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable description of the warning
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
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Warning" /> class.
        /// </summary>
        /// <param name="code">
        /// Warning code identifying the condition, in `SCREAMING_SNAKE_CASE`. Early Access codes are `NO_ACTIVE_SPEECH` (a speech-scoped message arrived with no active turn) and `SYNTHESIS_RETRYING` (a synthesis request failed and is being retried).
        /// </param>
        /// <param name="description">
        /// A human-readable description of the warning
        /// </param>
        /// <param name="type">
        /// Message type identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakV2SpeakV2Warning(
            string code,
            string description,
            global::Deepgram.Realtime.SpeakV2SpeakV2WarningType type)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakV2SpeakV2Warning" /> class.
        /// </summary>
        public SpeakV2SpeakV2Warning()
        {
        }

    }
}