
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the Groq's chat completions API (mostly OpenAI-compatible)
    /// </summary>
    public enum GroqThinkProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroqThinkProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroqThinkProviderVersion value)
        {
            return value switch
            {
                GroqThinkProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroqThinkProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => GroqThinkProviderVersion.V1,
                _ => null,
            };
        }
    }
}