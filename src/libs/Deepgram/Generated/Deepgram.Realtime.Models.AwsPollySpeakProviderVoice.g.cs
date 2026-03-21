
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// AWS Polly voice name
    /// </summary>
    public enum AwsPollySpeakProviderVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Matthew,
        /// <summary>
        /// 
        /// </summary>
        Joanna,
        /// <summary>
        /// 
        /// </summary>
        Amy,
        /// <summary>
        /// 
        /// </summary>
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Brian,
        /// <summary>
        /// 
        /// </summary>
        Arthur,
        /// <summary>
        /// 
        /// </summary>
        Aria,
        /// <summary>
        /// 
        /// </summary>
        Ayanda,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsPollySpeakProviderVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsPollySpeakProviderVoice value)
        {
            return value switch
            {
                AwsPollySpeakProviderVoice.Matthew => "Matthew",
                AwsPollySpeakProviderVoice.Joanna => "Joanna",
                AwsPollySpeakProviderVoice.Amy => "Amy",
                AwsPollySpeakProviderVoice.Emma => "Emma",
                AwsPollySpeakProviderVoice.Brian => "Brian",
                AwsPollySpeakProviderVoice.Arthur => "Arthur",
                AwsPollySpeakProviderVoice.Aria => "Aria",
                AwsPollySpeakProviderVoice.Ayanda => "Ayanda",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsPollySpeakProviderVoice? ToEnum(string value)
        {
            return value switch
            {
                "Matthew" => AwsPollySpeakProviderVoice.Matthew,
                "Joanna" => AwsPollySpeakProviderVoice.Joanna,
                "Amy" => AwsPollySpeakProviderVoice.Amy,
                "Emma" => AwsPollySpeakProviderVoice.Emma,
                "Brian" => AwsPollySpeakProviderVoice.Brian,
                "Arthur" => AwsPollySpeakProviderVoice.Arthur,
                "Aria" => AwsPollySpeakProviderVoice.Aria,
                "Ayanda" => AwsPollySpeakProviderVoice.Ayanda,
                _ => null,
            };
        }
    }
}