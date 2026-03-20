
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// No container.
    /// </summary>
    public enum SpeakV1AudioGenerateContainerNone
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakV1AudioGenerateContainerNoneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakV1AudioGenerateContainerNone value)
        {
            return value switch
            {
                SpeakV1AudioGenerateContainerNone.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakV1AudioGenerateContainerNone? ToEnum(string value)
        {
            return value switch
            {
                "none" => SpeakV1AudioGenerateContainerNone.None,
                _ => null,
            };
        }
    }
}