
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// Annotates what kind of utterance the message represents: `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
    /// </summary>
    public enum ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior
    {
        /// <summary>
        /// `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
        /// </summary>
        Backchannel,
        /// <summary>
        /// `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
        /// </summary>
        Default,
        /// <summary>
        /// `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
        /// </summary>
        Filler,
        /// <summary>
        /// `default` (a standard turn), `backchannel` (a short acknowledgement while the user held the floor), `presence_check` (a prompt after extended silence), or `filler` (a line covering a wait on a function call or a dynamic InjectAgentMessage). Always sent; it is `default` for every message while Think Live is off
        /// </summary>
        PresenceCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior value)
        {
            return value switch
            {
                ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.Backchannel => "backchannel",
                ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.Default => "default",
                ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.Filler => "filler",
                ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.PresenceCheck => "presence_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior? ToEnum(string value)
        {
            return value switch
            {
                "backchannel" => ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.Backchannel,
                "default" => ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.Default,
                "filler" => ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.Filler,
                "presence_check" => ChannelsAgentV1MessagesAgentV1ConversationTextConversationalBehavior.PresenceCheck,
                _ => null,
            };
        }
    }
}