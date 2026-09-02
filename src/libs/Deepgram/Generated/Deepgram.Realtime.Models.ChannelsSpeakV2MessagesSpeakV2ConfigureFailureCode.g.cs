
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Failure code, in `SCREAMING_SNAKE_CASE`. `SPEED_OUT_OF_RANGE`: outside the range the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but off the `0.05` increment. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
    /// </summary>
    public enum ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode
    {
        /// <summary>
        /// outside the range the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but off the `0.05` increment. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
        /// </summary>
        InternalError,
        /// <summary>
        /// outside the range the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but off the `0.05` increment. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
        /// </summary>
        SpeedIncrementInvalid,
        /// <summary>
        /// outside the range the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but off the `0.05` increment. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
        /// </summary>
        SpeedNotSupported,
        /// <summary>
        /// outside the range the model publishes. `SPEED_INCREMENT_INVALID`: inside the published range but off the `0.05` increment. `SPEED_NOT_SUPPORTED`: this model or language has no runtime speed control at all. `INTERNAL_ERROR`: the configuration was acceptable but the server could not apply it — unlike the others, a server-side failure rather than a statement about the request.
        /// </summary>
        SpeedOutOfRange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode value)
        {
            return value switch
            {
                ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.InternalError => "INTERNAL_ERROR",
                ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.SpeedIncrementInvalid => "SPEED_INCREMENT_INVALID",
                ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.SpeedNotSupported => "SPEED_NOT_SUPPORTED",
                ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.SpeedOutOfRange => "SPEED_OUT_OF_RANGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode? ToEnum(string value)
        {
            return value switch
            {
                "INTERNAL_ERROR" => ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.InternalError,
                "SPEED_INCREMENT_INVALID" => ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.SpeedIncrementInvalid,
                "SPEED_NOT_SUPPORTED" => ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.SpeedNotSupported,
                "SPEED_OUT_OF_RANGE" => ChannelsSpeakV2MessagesSpeakV2ConfigureFailureCode.SpeedOutOfRange,
                _ => null,
            };
        }
    }
}