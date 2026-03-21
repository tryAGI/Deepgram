
#nullable enable

namespace Deepgram.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum AwsPollySpeakProviderEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Generative,
        /// <summary>
        /// 
        /// </summary>
        LongForm,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Neural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsPollySpeakProviderEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsPollySpeakProviderEngine value)
        {
            return value switch
            {
                AwsPollySpeakProviderEngine.Generative => "generative",
                AwsPollySpeakProviderEngine.LongForm => "long-form",
                AwsPollySpeakProviderEngine.Standard => "standard",
                AwsPollySpeakProviderEngine.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsPollySpeakProviderEngine? ToEnum(string value)
        {
            return value switch
            {
                "generative" => AwsPollySpeakProviderEngine.Generative,
                "long-form" => AwsPollySpeakProviderEngine.LongForm,
                "standard" => AwsPollySpeakProviderEngine.Standard,
                "neural" => AwsPollySpeakProviderEngine.Neural,
                _ => null,
            };
        }
    }
}