
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// A code identifying the error, e.g. `MESSAGE-0000` or `NET-0000`.
    /// </summary>
    public enum ChannelsSpeakV2MessagesSpeakV2ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        Big0000,
        /// <summary>
        /// 
        /// </summary>
        Data0000,
        /// <summary>
        /// 
        /// </summary>
        Message0000,
        /// <summary>
        /// 
        /// </summary>
        Net0000,
        /// <summary>
        /// 
        /// </summary>
        Net0001,
        /// <summary>
        /// 
        /// </summary>
        Net0002,
        /// <summary>
        /// 
        /// </summary>
        Net0003,
        /// <summary>
        /// 
        /// </summary>
        Net0004,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV2MessagesSpeakV2ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV2MessagesSpeakV2ErrorCode value)
        {
            return value switch
            {
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Big0000 => "BIG-0000",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Data0000 => "DATA-0000",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Message0000 => "MESSAGE-0000",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0000 => "NET-0000",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0001 => "NET-0001",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0002 => "NET-0002",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0003 => "NET-0003",
                ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0004 => "NET-0004",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV2MessagesSpeakV2ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "BIG-0000" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Big0000,
                "DATA-0000" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Data0000,
                "MESSAGE-0000" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Message0000,
                "NET-0000" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0000,
                "NET-0001" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0001,
                "NET-0002" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0002,
                "NET-0003" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0003,
                "NET-0004" => ChannelsSpeakV2MessagesSpeakV2ErrorCode.Net0004,
                _ => null,
            };
        }
    }
}