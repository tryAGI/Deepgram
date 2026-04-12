
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Describes the current turn and latest state of the turn
    /// </summary>
    public sealed partial class ListenV2ListenV2TurnInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ListenV2ListenV2TurnInfoTypeJsonConverter))]
        public global::Deepgram.Realtime.ListenV2ListenV2TurnInfoType Type { get; set; }

        /// <summary>
        /// The unique identifier of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Starts at `0` and increments for each message the server sends to the client.  This includes messages of other types, like `Connected` messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SequenceId { get; set; }

        /// <summary>
        /// The type of event being reported.<br/>
        /// - **Update** - Additional audio has been transcribed, but the turn state hasn't changed<br/>
        /// - **StartOfTurn** - The user has begun speaking for the first time in the turn<br/>
        /// - **EagerEndOfTurn** - The system has moderate confidence that the user has finished speaking for the turn. This is an opportunity to begin preparing an agent reply<br/>
        /// - **TurnResumed** - The system detected that speech had ended and therefore sent an **EagerEndOfTurn** event, but speech is actually continuing for this turn<br/>
        /// - **EndOfTurn** - The user has finished speaking for the turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Deepgram.Realtime.JsonConverters.ChannelsListenV2MessagesListenV2TurnInfoEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoEvent Event { get; set; }

        /// <summary>
        /// The index of the current turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TurnIndex { get; set; }

        /// <summary>
        /// Start time in seconds of the audio range that was transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_window_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioWindowStart { get; set; }

        /// <summary>
        /// End time in seconds of the audio range that was transcribed
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
        /// The words in the `transcript`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoWordsItems> Words { get; set; }

        /// <summary>
        /// Confidence that no more speech is coming in this turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_turn_confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndOfTurnConfidence { get; set; }

        /// <summary>
        /// Detected languages sorted by descending frequency in the<br/>
        /// transcript. Only present when the flux-general-multi model<br/>
        /// detects languages in the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// The language hints that were supplied for this turn. Only<br/>
        /// present when language hints are configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_hinted")]
        public global::System.Collections.Generic.IList<string>? LanguagesHinted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2TurnInfo" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the request
        /// </param>
        /// <param name="sequenceId">
        /// Starts at `0` and increments for each message the server sends to the client.  This includes messages of other types, like `Connected` messages.
        /// </param>
        /// <param name="event">
        /// The type of event being reported.<br/>
        /// - **Update** - Additional audio has been transcribed, but the turn state hasn't changed<br/>
        /// - **StartOfTurn** - The user has begun speaking for the first time in the turn<br/>
        /// - **EagerEndOfTurn** - The system has moderate confidence that the user has finished speaking for the turn. This is an opportunity to begin preparing an agent reply<br/>
        /// - **TurnResumed** - The system detected that speech had ended and therefore sent an **EagerEndOfTurn** event, but speech is actually continuing for this turn<br/>
        /// - **EndOfTurn** - The user has finished speaking for the turn
        /// </param>
        /// <param name="turnIndex">
        /// The index of the current turn
        /// </param>
        /// <param name="audioWindowStart">
        /// Start time in seconds of the audio range that was transcribed
        /// </param>
        /// <param name="audioWindowEnd">
        /// End time in seconds of the audio range that was transcribed
        /// </param>
        /// <param name="transcript">
        /// Text that was said over the course of the current turn
        /// </param>
        /// <param name="words">
        /// The words in the `transcript`
        /// </param>
        /// <param name="endOfTurnConfidence">
        /// Confidence that no more speech is coming in this turn
        /// </param>
        /// <param name="type"></param>
        /// <param name="languages">
        /// Detected languages sorted by descending frequency in the<br/>
        /// transcript. Only present when the flux-general-multi model<br/>
        /// detects languages in the audio.
        /// </param>
        /// <param name="languagesHinted">
        /// The language hints that were supplied for this turn. Only<br/>
        /// present when language hints are configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV2ListenV2TurnInfo(
            global::System.Guid requestId,
            double sequenceId,
            global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoEvent @event,
            double turnIndex,
            double audioWindowStart,
            double audioWindowEnd,
            string transcript,
            global::System.Collections.Generic.IList<global::Deepgram.Realtime.ChannelsListenV2MessagesListenV2TurnInfoWordsItems> words,
            double endOfTurnConfidence,
            global::Deepgram.Realtime.ListenV2ListenV2TurnInfoType type,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Collections.Generic.IList<string>? languagesHinted)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.SequenceId = sequenceId;
            this.Event = @event;
            this.TurnIndex = turnIndex;
            this.AudioWindowStart = audioWindowStart;
            this.AudioWindowEnd = audioWindowEnd;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.EndOfTurnConfidence = endOfTurnConfidence;
            this.Languages = languages;
            this.LanguagesHinted = languagesHinted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV2ListenV2TurnInfo" /> class.
        /// </summary>
        public ListenV2ListenV2TurnInfo()
        {
        }
    }
}