
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBreakdownV1ResponseResultsItems
    {
        /// <summary>
        /// Audio hours processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Hours { get; set; }

        /// <summary>
        /// Total hours including all processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalHours { get; set; }

        /// <summary>
        /// Agent hours used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentHours { get; set; }

        /// <summary>
        /// Number of input tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokensIn { get; set; }

        /// <summary>
        /// Number of output tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_out")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokensOut { get; set; }

        /// <summary>
        /// Number of text-to-speech characters processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TtsCharacters { get; set; }

        /// <summary>
        /// Number of requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.UsageBreakdownV1ResponseResultsItemsGrouping Grouping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResultsItems" /> class.
        /// </summary>
        /// <param name="hours">
        /// Audio hours processed
        /// </param>
        /// <param name="totalHours">
        /// Total hours including all processing
        /// </param>
        /// <param name="agentHours">
        /// Agent hours used
        /// </param>
        /// <param name="tokensIn">
        /// Number of input tokens
        /// </param>
        /// <param name="tokensOut">
        /// Number of output tokens
        /// </param>
        /// <param name="ttsCharacters">
        /// Number of text-to-speech characters processed
        /// </param>
        /// <param name="requests">
        /// Number of requests
        /// </param>
        /// <param name="grouping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageBreakdownV1ResponseResultsItems(
            double hours,
            double totalHours,
            double agentHours,
            double tokensIn,
            double tokensOut,
            double ttsCharacters,
            double requests,
            global::Deepgram.UsageBreakdownV1ResponseResultsItemsGrouping grouping)
        {
            this.Hours = hours;
            this.TotalHours = totalHours;
            this.AgentHours = agentHours;
            this.TokensIn = tokensIn;
            this.TokensOut = tokensOut;
            this.TtsCharacters = ttsCharacters;
            this.Requests = requests;
            this.Grouping = grouping ?? throw new global::System.ArgumentNullException(nameof(grouping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResultsItems" /> class.
        /// </summary>
        public UsageBreakdownV1ResponseResultsItems()
        {
        }

    }
}