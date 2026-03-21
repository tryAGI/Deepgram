
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// The type of event being reported.<br/>
    /// - **Update** - Additional audio has been transcribed, but the turn state hasn't changed<br/>
    /// - **StartOfTurn** - The user has begun speaking for the first time in the turn<br/>
    /// - **EagerEndOfTurn** - The system has moderate confidence that the user has finished speaking for the turn. This is an opportunity to begin preparing an agent reply<br/>
    /// - **TurnResumed** - The system detected that speech had ended and therefore sent an **EagerEndOfTurn** event, but speech is actually continuing for this turn<br/>
    /// - **EndOfTurn** - The user has finished speaking for the turn
    /// </summary>
    public enum ListenV2TurnInfoEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        StartOfTurn,
        /// <summary>
        /// 
        /// </summary>
        EagerEndOfTurn,
        /// <summary>
        /// 
        /// </summary>
        TurnResumed,
        /// <summary>
        /// 
        /// </summary>
        EndOfTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV2TurnInfoEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV2TurnInfoEventEvent value)
        {
            return value switch
            {
                ListenV2TurnInfoEventEvent.Update => "Update",
                ListenV2TurnInfoEventEvent.StartOfTurn => "StartOfTurn",
                ListenV2TurnInfoEventEvent.EagerEndOfTurn => "EagerEndOfTurn",
                ListenV2TurnInfoEventEvent.TurnResumed => "TurnResumed",
                ListenV2TurnInfoEventEvent.EndOfTurn => "EndOfTurn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV2TurnInfoEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "Update" => ListenV2TurnInfoEventEvent.Update,
                "StartOfTurn" => ListenV2TurnInfoEventEvent.StartOfTurn,
                "EagerEndOfTurn" => ListenV2TurnInfoEventEvent.EagerEndOfTurn,
                "TurnResumed" => ListenV2TurnInfoEventEvent.TurnResumed,
                "EndOfTurn" => ListenV2TurnInfoEventEvent.EndOfTurn,
                _ => null,
            };
        }
    }
}