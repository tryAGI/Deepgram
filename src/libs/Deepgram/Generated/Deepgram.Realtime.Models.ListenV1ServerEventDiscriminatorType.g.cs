
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Results,
        /// <summary>
        /// 
        /// </summary>
        SpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        UtteranceEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ListenV1ServerEventDiscriminatorType.Metadata => "Metadata",
                ListenV1ServerEventDiscriminatorType.Results => "Results",
                ListenV1ServerEventDiscriminatorType.SpeechStarted => "SpeechStarted",
                ListenV1ServerEventDiscriminatorType.UtteranceEnd => "UtteranceEnd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => ListenV1ServerEventDiscriminatorType.Metadata,
                "Results" => ListenV1ServerEventDiscriminatorType.Results,
                "SpeechStarted" => ListenV1ServerEventDiscriminatorType.SpeechStarted,
                "UtteranceEnd" => ListenV1ServerEventDiscriminatorType.UtteranceEnd,
                _ => null,
            };
        }
    }
}