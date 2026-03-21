
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Groq model to use
    /// </summary>
    public enum GroqThinkProviderModel
    {
        /// <summary>
        /// 
        /// </summary>
        OpenaiGptOss20b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroqThinkProviderModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroqThinkProviderModel value)
        {
            return value switch
            {
                GroqThinkProviderModel.OpenaiGptOss20b => "openai/gpt-oss-20b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroqThinkProviderModel? ToEnum(string value)
        {
            return value switch
            {
                "openai/gpt-oss-20b" => GroqThinkProviderModel.OpenaiGptOss20b,
                _ => null,
            };
        }
    }
}