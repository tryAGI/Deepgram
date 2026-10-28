
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Configures Deepgram's Think Live model. Think Live is off until this object is provided
    /// </summary>
    public sealed partial class ThinkLiveSettingsV1
    {
        /// <summary>
        /// Deepgram's Think Live model, which runs alongside your reasoning LLM to handle backchanneling, presence checks, and frustration detection. Only the Deepgram provider is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Deepgram.Realtime.DeepgramThinkLiveProviderV1 Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkLiveSettingsV1" /> class.
        /// </summary>
        /// <param name="provider">
        /// Deepgram's Think Live model, which runs alongside your reasoning LLM to handle backchanneling, presence checks, and frustration detection. Only the Deepgram provider is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkLiveSettingsV1(
            global::Deepgram.Realtime.DeepgramThinkLiveProviderV1 provider)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkLiveSettingsV1" /> class.
        /// </summary>
        public ThinkLiveSettingsV1()
        {
        }

    }
}