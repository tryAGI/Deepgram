
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Agent will not discard context regardless of length
    /// </summary>
    public enum ThinkSettingsV1ContextLength0
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkSettingsV1ContextLength0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkSettingsV1ContextLength0 value)
        {
            return value switch
            {
                ThinkSettingsV1ContextLength0.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkSettingsV1ContextLength0? ToEnum(string value)
        {
            return value switch
            {
                "max" => ThinkSettingsV1ContextLength0.Max,
                _ => null,
            };
        }
    }
}