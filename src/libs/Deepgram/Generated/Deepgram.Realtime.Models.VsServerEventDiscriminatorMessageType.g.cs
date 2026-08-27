
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum VsServerEventDiscriminatorMessageType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigureFailure,
        /// <summary>
        ///
        /// </summary>
        ConfigureSuccess,
        /// <summary>
        ///
        /// </summary>
        Connected,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Flushed,
        /// <summary>
        ///
        /// </summary>
        SessionMetadata,
        /// <summary>
        ///
        /// </summary>
        SpeechInterrupted,
        /// <summary>
        ///
        /// </summary>
        SpeechMetadata,
        /// <summary>
        ///
        /// </summary>
        SpeechStarted,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VsServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VsServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                VsServerEventDiscriminatorMessageType.ConfigureFailure => "ConfigureFailure",
                VsServerEventDiscriminatorMessageType.ConfigureSuccess => "ConfigureSuccess",
                VsServerEventDiscriminatorMessageType.Connected => "Connected",
                VsServerEventDiscriminatorMessageType.Error => "Error",
                VsServerEventDiscriminatorMessageType.Flushed => "Flushed",
                VsServerEventDiscriminatorMessageType.SessionMetadata => "SessionMetadata",
                VsServerEventDiscriminatorMessageType.SpeechInterrupted => "SpeechInterrupted",
                VsServerEventDiscriminatorMessageType.SpeechMetadata => "SpeechMetadata",
                VsServerEventDiscriminatorMessageType.SpeechStarted => "SpeechStarted",
                VsServerEventDiscriminatorMessageType.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VsServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "ConfigureFailure" => VsServerEventDiscriminatorMessageType.ConfigureFailure,
                "ConfigureSuccess" => VsServerEventDiscriminatorMessageType.ConfigureSuccess,
                "Connected" => VsServerEventDiscriminatorMessageType.Connected,
                "Error" => VsServerEventDiscriminatorMessageType.Error,
                "Flushed" => VsServerEventDiscriminatorMessageType.Flushed,
                "SessionMetadata" => VsServerEventDiscriminatorMessageType.SessionMetadata,
                "SpeechInterrupted" => VsServerEventDiscriminatorMessageType.SpeechInterrupted,
                "SpeechMetadata" => VsServerEventDiscriminatorMessageType.SpeechMetadata,
                "SpeechStarted" => VsServerEventDiscriminatorMessageType.SpeechStarted,
                "Warning" => VsServerEventDiscriminatorMessageType.Warning,
                _ => null,
            };
        }
    }
}