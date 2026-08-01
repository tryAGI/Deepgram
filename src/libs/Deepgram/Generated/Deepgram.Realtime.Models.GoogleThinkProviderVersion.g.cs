
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The Google API used for the request: ai-studio-v1beta for the AI Studio API, or gemini-enterprise-agent-v1 for the Gemini Enterprise Agent (GEA) API. v1beta is accepted as an alias for ai-studio-v1beta. Defaults based on the Deepgram Voice Agent endpoint you connect to.
    /// </summary>
    public enum GoogleThinkProviderVersion
    {
        /// <summary>
        /// ai-studio-v1beta for the AI Studio API, or gemini-enterprise-agent-v1 for the Gemini Enterprise Agent (GEA) API. v1beta is accepted as an alias for ai-studio-v1beta. Defaults based on the Deepgram Voice Agent endpoint you connect to.
        /// </summary>
        AiStudioV1beta,
        /// <summary>
        /// ai-studio-v1beta for the AI Studio API, or gemini-enterprise-agent-v1 for the Gemini Enterprise Agent (GEA) API. v1beta is accepted as an alias for ai-studio-v1beta. Defaults based on the Deepgram Voice Agent endpoint you connect to.
        /// </summary>
        GeminiEnterpriseAgentV1,
        /// <summary>
        /// ai-studio-v1beta for the AI Studio API, or gemini-enterprise-agent-v1 for the Gemini Enterprise Agent (GEA) API. v1beta is accepted as an alias for ai-studio-v1beta. Defaults based on the Deepgram Voice Agent endpoint you connect to.
        /// </summary>
        V1beta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleThinkProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleThinkProviderVersion value)
        {
            return value switch
            {
                GoogleThinkProviderVersion.AiStudioV1beta => "ai-studio-v1beta",
                GoogleThinkProviderVersion.GeminiEnterpriseAgentV1 => "gemini-enterprise-agent-v1",
                GoogleThinkProviderVersion.V1beta => "v1beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleThinkProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "ai-studio-v1beta" => GoogleThinkProviderVersion.AiStudioV1beta,
                "gemini-enterprise-agent-v1" => GoogleThinkProviderVersion.GeminiEnterpriseAgentV1,
                "v1beta" => GoogleThinkProviderVersion.V1beta,
                _ => null,
            };
        }
    }
}