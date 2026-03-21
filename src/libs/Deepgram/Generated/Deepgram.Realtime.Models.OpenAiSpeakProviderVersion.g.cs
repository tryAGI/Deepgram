
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The REST API version for the OpenAI text-to-speech API
    /// </summary>
    public enum OpenAiSpeakProviderVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiSpeakProviderVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiSpeakProviderVersion value)
        {
            return value switch
            {
                OpenAiSpeakProviderVersion.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiSpeakProviderVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => OpenAiSpeakProviderVersion.V1,
                _ => null,
            };
        }
    }
}