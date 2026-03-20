
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageBreakdownV1ResponseResult
    {
        /// <summary>
        /// Audio hours processed<br/>
        /// Example: 1619.7242069444444
        /// </summary>
        /// <example>1619.7242069444444</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Hours { get; set; }

        /// <summary>
        /// Total hours including all processing<br/>
        /// Example: 1621.7395791666668
        /// </summary>
        /// <example>1621.7395791666668</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float TotalHours { get; set; }

        /// <summary>
        /// Agent hours used<br/>
        /// Example: 41.33564388888889
        /// </summary>
        /// <example>41.33564388888889</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float AgentHours { get; set; }

        /// <summary>
        /// Number of input tokens<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokensIn { get; set; }

        /// <summary>
        /// Number of output tokens<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_out")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokensOut { get; set; }

        /// <summary>
        /// Number of text-to-speech characters processed<br/>
        /// Example: 9158866
        /// </summary>
        /// <example>9158866</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TtsCharacters { get; set; }

        /// <summary>
        /// Number of requests<br/>
        /// Example: 373381
        /// </summary>
        /// <example>373381</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grouping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.UsageBreakdownV1ResponseResultGrouping Grouping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResult" /> class.
        /// </summary>
        /// <param name="hours">
        /// Audio hours processed<br/>
        /// Example: 1619.7242069444444
        /// </param>
        /// <param name="totalHours">
        /// Total hours including all processing<br/>
        /// Example: 1621.7395791666668
        /// </param>
        /// <param name="agentHours">
        /// Agent hours used<br/>
        /// Example: 41.33564388888889
        /// </param>
        /// <param name="tokensIn">
        /// Number of input tokens<br/>
        /// Example: 0
        /// </param>
        /// <param name="tokensOut">
        /// Number of output tokens<br/>
        /// Example: 0
        /// </param>
        /// <param name="ttsCharacters">
        /// Number of text-to-speech characters processed<br/>
        /// Example: 9158866
        /// </param>
        /// <param name="requests">
        /// Number of requests<br/>
        /// Example: 373381
        /// </param>
        /// <param name="grouping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageBreakdownV1ResponseResult(
            float hours,
            float totalHours,
            float agentHours,
            double tokensIn,
            double tokensOut,
            double ttsCharacters,
            double requests,
            global::Deepgram.UsageBreakdownV1ResponseResultGrouping grouping)
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
        /// Initializes a new instance of the <see cref="UsageBreakdownV1ResponseResult" /> class.
        /// </summary>
        public UsageBreakdownV1ResponseResult()
        {
        }
    }
}