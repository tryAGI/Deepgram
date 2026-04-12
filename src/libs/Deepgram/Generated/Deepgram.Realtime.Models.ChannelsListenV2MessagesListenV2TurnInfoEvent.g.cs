
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
    public enum ChannelsListenV2MessagesListenV2TurnInfoEvent
    {
        /// <summary>
        /// 
        /// </summary>
        EagerEndOfTurn,
        /// <summary>
        /// 
        /// </summary>
        EndOfTurn,
        /// <summary>
        /// 
        /// </summary>
        StartOfTurn,
        /// <summary>
        /// 
        /// </summary>
        TurnResumed,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsListenV2MessagesListenV2TurnInfoEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsListenV2MessagesListenV2TurnInfoEvent value)
        {
            return value switch
            {
                ChannelsListenV2MessagesListenV2TurnInfoEvent.EagerEndOfTurn => "EagerEndOfTurn",
                ChannelsListenV2MessagesListenV2TurnInfoEvent.EndOfTurn => "EndOfTurn",
                ChannelsListenV2MessagesListenV2TurnInfoEvent.StartOfTurn => "StartOfTurn",
                ChannelsListenV2MessagesListenV2TurnInfoEvent.TurnResumed => "TurnResumed",
                ChannelsListenV2MessagesListenV2TurnInfoEvent.Update => "Update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsListenV2MessagesListenV2TurnInfoEvent? ToEnum(string value)
        {
            return value switch
            {
                "EagerEndOfTurn" => ChannelsListenV2MessagesListenV2TurnInfoEvent.EagerEndOfTurn,
                "EndOfTurn" => ChannelsListenV2MessagesListenV2TurnInfoEvent.EndOfTurn,
                "StartOfTurn" => ChannelsListenV2MessagesListenV2TurnInfoEvent.StartOfTurn,
                "TurnResumed" => ChannelsListenV2MessagesListenV2TurnInfoEvent.TurnResumed,
                "Update" => ChannelsListenV2MessagesListenV2TurnInfoEvent.Update,
                _ => null,
            };
        }
    }
}