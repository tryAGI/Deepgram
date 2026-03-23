
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
        Amy,
        /// <summary>
        /// 
        /// </summary>
        Aria,
        /// <summary>
        /// 
        /// </summary>
        Arthur,
        /// <summary>
        /// 
        /// </summary>
        Ayanda,
        /// <summary>
        /// 
        /// </summary>
        Brian,
        /// <summary>
        /// 
        /// </summary>
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Joanna,
        /// <summary>
        /// 
        /// </summary>
        Matthew,
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
                AwsPollySpeakProviderVoice.Amy => "Amy",
                AwsPollySpeakProviderVoice.Aria => "Aria",
                AwsPollySpeakProviderVoice.Arthur => "Arthur",
                AwsPollySpeakProviderVoice.Ayanda => "Ayanda",
                AwsPollySpeakProviderVoice.Brian => "Brian",
                AwsPollySpeakProviderVoice.Emma => "Emma",
                AwsPollySpeakProviderVoice.Joanna => "Joanna",
                AwsPollySpeakProviderVoice.Matthew => "Matthew",
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
                "Amy" => AwsPollySpeakProviderVoice.Amy,
                "Aria" => AwsPollySpeakProviderVoice.Aria,
                "Arthur" => AwsPollySpeakProviderVoice.Arthur,
                "Ayanda" => AwsPollySpeakProviderVoice.Ayanda,
                "Brian" => AwsPollySpeakProviderVoice.Brian,
                "Emma" => AwsPollySpeakProviderVoice.Emma,
                "Joanna" => AwsPollySpeakProviderVoice.Joanna,
                "Matthew" => AwsPollySpeakProviderVoice.Matthew,
                _ => null,
            };
        }
    }
}