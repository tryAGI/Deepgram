
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentThinkModelsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Deepgram.OneOf<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1Response" /> class.
        /// </summary>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentThinkModelsV1Response(
            global::System.Collections.Generic.IList<global::Deepgram.OneOf<global::Deepgram.AgentThinkModelsV1ResponseModelVariant1, global::Deepgram.AgentThinkModelsV1ResponseModelVariant2, global::Deepgram.AgentThinkModelsV1ResponseModelVariant3, global::Deepgram.AgentThinkModelsV1ResponseModelVariant4, global::Deepgram.AgentThinkModelsV1ResponseModelVariant5>> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentThinkModelsV1Response" /> class.
        /// </summary>
        public AgentThinkModelsV1Response()
        {
        }
    }
}