
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroqThinkProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Groq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroqThinkProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroqThinkProviderType value)
        {
            return value switch
            {
                GroqThinkProviderType.Groq => "groq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroqThinkProviderType? ToEnum(string value)
        {
            return value switch
            {
                "groq" => GroqThinkProviderType.Groq,
                _ => null,
            };
        }
    }
}