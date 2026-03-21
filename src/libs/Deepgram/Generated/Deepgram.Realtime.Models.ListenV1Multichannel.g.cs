
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Transcribe each audio channel independently<br/>
    /// Default Value: false
    /// </summary>
    public enum ListenV1Multichannel
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
    public static class ListenV1MultichannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Multichannel value)
        {
            return value switch
            {
                ListenV1Multichannel.True => "true",
                ListenV1Multichannel.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Multichannel? ToEnum(string value)
        {
            return value switch
            {
                "true" => ListenV1Multichannel.True,
                "false" => ListenV1Multichannel.False,
                _ => null,
            };
        }
    }
}