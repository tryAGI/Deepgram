
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Identifies why the `Configure` was rejected.<br/>
    /// - `CONFIGURE_KEYTERMS_NOT_SUPPORTED`: the stream's model does not support mid-stream keyterm updates. Only<br/>
    ///   Nova-3 models do.<br/>
    /// - `CONFIGURE_KEYTERM_LIMIT_EXCEEDED`: the keyterms exceed the 500-token keyterm limit.<br/>
    /// - `CONFIGURE_ALREADY_PENDING`: another `Configure` is still awaiting its response.<br/>
    /// - `CONFIGURE_INTERNAL_ERROR`: the server failed to apply the configuration.
    /// </summary>
    public enum ChannelsListenV1MessagesListenV1ConfigureFailureCode
    {
        /// <summary>
        /// another `Configure` is still awaiting its response.
        /// </summary>
        ConfigureAlreadyPending,
        /// <summary>
        /// the server failed to apply the configuration.
        /// </summary>
        ConfigureInternalError,
        /// <summary>
        /// the stream's model does not support mid-stream keyterm updates. Only
        /// </summary>
        ConfigureKeytermsNotSupported,
        /// <summary>
        /// the keyterms exceed the 500-token keyterm limit.
        /// </summary>
        ConfigureKeytermLimitExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV1MessagesListenV1ConfigureFailureCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV1MessagesListenV1ConfigureFailureCode value)
        {
            return value switch
            {
                ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureAlreadyPending => "CONFIGURE_ALREADY_PENDING",
                ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureInternalError => "CONFIGURE_INTERNAL_ERROR",
                ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureKeytermsNotSupported => "CONFIGURE_KEYTERMS_NOT_SUPPORTED",
                ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureKeytermLimitExceeded => "CONFIGURE_KEYTERM_LIMIT_EXCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV1MessagesListenV1ConfigureFailureCode? ToEnum(string value)
        {
            return value switch
            {
                "CONFIGURE_ALREADY_PENDING" => ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureAlreadyPending,
                "CONFIGURE_INTERNAL_ERROR" => ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureInternalError,
                "CONFIGURE_KEYTERMS_NOT_SUPPORTED" => ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureKeytermsNotSupported,
                "CONFIGURE_KEYTERM_LIMIT_EXCEEDED" => ChannelsListenV1MessagesListenV1ConfigureFailureCode.ConfigureKeytermLimitExceeded,
                _ => null,
            };
        }
    }
}