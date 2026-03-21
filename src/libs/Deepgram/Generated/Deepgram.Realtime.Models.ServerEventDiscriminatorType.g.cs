
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Results,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        UtteranceEnd,
        /// <summary>
        /// 
        /// </summary>
        SpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Results => "Results",
                ServerEventDiscriminatorType.Metadata => "Metadata",
                ServerEventDiscriminatorType.UtteranceEnd => "UtteranceEnd",
                ServerEventDiscriminatorType.SpeechStarted => "SpeechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "Results" => ServerEventDiscriminatorType.Results,
                "Metadata" => ServerEventDiscriminatorType.Metadata,
                "UtteranceEnd" => ServerEventDiscriminatorType.UtteranceEnd,
                "SpeechStarted" => ServerEventDiscriminatorType.SpeechStarted,
                _ => null,
            };
        }
    }
}