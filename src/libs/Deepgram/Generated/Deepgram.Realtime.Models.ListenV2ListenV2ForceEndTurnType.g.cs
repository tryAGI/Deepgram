
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Message type identifier
    /// </summary>
    public enum ListenV2ListenV2ForceEndTurnType
    {
        /// <summary>
        ///
        /// </summary>
        ForceEndTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2ListenV2ForceEndTurnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2ListenV2ForceEndTurnType value)
        {
            return value switch
            {
                ListenV2ListenV2ForceEndTurnType.ForceEndTurn => "ForceEndTurn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2ListenV2ForceEndTurnType? ToEnum(string value)
        {
            return value switch
            {
                "ForceEndTurn" => ListenV2ListenV2ForceEndTurnType.ForceEndTurn,
                _ => null,
            };
        }
    }
}