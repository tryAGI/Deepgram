
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the OpenAI chat completions API
    /// </summary>
    public enum OpenAiThinkProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiThinkProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiThinkProviderVersion value)
        {
            return value switch
            {
                OpenAiThinkProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiThinkProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => OpenAiThinkProviderVersion.V1,
                _ => null,
            };
        }
    }
}