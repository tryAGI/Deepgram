
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Describes the current turn and latest transcription state.
    /// </summary>
    public sealed partial class V2TurnInfoPayload
    {
        /// <summary>
        /// Message type identifier
        /// </summary>
        /// <default>"TurnInfo"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "TurnInfo";

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Incremental server message counter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SequenceId { get; set; }

        /// <summary>
        /// The type of turn event (Update, StartOfTurn, EagerEndOfTurn, TurnResumed, EndOfTurn)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// The index of the current turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TurnIndex { get; set; }

        /// <summary>
        /// Start time in seconds of the audio range transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_window_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioWindowStart { get; set; }

        /// <summary>
        /// End time in seconds of the audio range transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_window_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioWindowEnd { get; set; }

        /// <summary>
        /// Text that was said over the course of the current turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// The words in the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.V2Word> Words { get; set; }

        /// <summary>
        /// Confidence that no more speech is coming in this turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_turn_confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndOfTurnConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TurnInfoPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier
        /// </param>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="sequenceId">
        /// Incremental server message counter
        /// </param>
        /// <param name="event">
        /// The type of turn event (Update, StartOfTurn, EagerEndOfTurn, TurnResumed, EndOfTurn)
        /// </param>
        /// <param name="turnIndex">
        /// The index of the current turn
        /// </param>
        /// <param name="audioWindowStart">
        /// Start time in seconds of the audio range transcribed
        /// </param>
        /// <param name="audioWindowEnd">
        /// End time in seconds of the audio range transcribed
        /// </param>
        /// <param name="transcript">
        /// Text that was said over the course of the current turn
        /// </param>
        /// <param name="words">
        /// The words in the transcript
        /// </param>
        /// <param name="endOfTurnConfidence">
        /// Confidence that no more speech is coming in this turn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2TurnInfoPayload(
            global::System.Guid requestId,
            double sequenceId,
            string @event,
            double turnIndex,
            double audioWindowStart,
            double audioWindowEnd,
            string transcript,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.V2Word> words,
            double endOfTurnConfidence,
            string type = "TurnInfo")
        {
            this.RequestId = requestId;
            this.SequenceId = sequenceId;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.TurnIndex = turnIndex;
            this.AudioWindowStart = audioWindowStart;
            this.AudioWindowEnd = audioWindowEnd;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.EndOfTurnConfidence = endOfTurnConfidence;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TurnInfoPayload" /> class.
        /// </summary>
        public V2TurnInfoPayload()
        {
        }
    }
}