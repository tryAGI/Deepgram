
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Indicates that speech has started. You'll begin receiving Speech Started messages upon speech starting<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1VadEvents
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1VadEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1VadEvents value)
        {
            return value switch
            {
                ListenV1VadEvents.True => "true",
                ListenV1VadEvents.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1VadEvents? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1VadEvents.True,
                "false" => ListenV1VadEvents.False,
                _ => null,
            };
        }
    }
}