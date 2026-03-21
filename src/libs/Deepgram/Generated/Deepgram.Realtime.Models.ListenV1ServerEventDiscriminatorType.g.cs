
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
    public static class ListenV1ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ListenV1ServerEventDiscriminatorType.Results => "Results",
                ListenV1ServerEventDiscriminatorType.Metadata => "Metadata",
                ListenV1ServerEventDiscriminatorType.UtteranceEnd => "UtteranceEnd",
                ListenV1ServerEventDiscriminatorType.SpeechStarted => "SpeechStarted",
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
                "Results" => ListenV1ServerEventDiscriminatorType.Results,
                "Metadata" => ListenV1ServerEventDiscriminatorType.Metadata,
                "UtteranceEnd" => ListenV1ServerEventDiscriminatorType.UtteranceEnd,
                "SpeechStarted" => ListenV1ServerEventDiscriminatorType.SpeechStarted,
                _ => null,
            };
        }
    }
}