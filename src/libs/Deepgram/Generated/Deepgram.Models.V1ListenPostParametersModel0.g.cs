
#nullable enable

namespace Deepgram
{
    /// <summary>
    /// Our public models available to all accounts
    /// </summary>
    public enum V1ListenPostParametersModel0
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Conversationalai,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        EnhancedFinance,
        /// <summary>
        /// 
        /// </summary>
        EnhancedGeneral,
        /// <summary>
        /// 
        /// </summary>
        EnhancedMeeting,
        /// <summary>
        /// 
        /// </summary>
        EnhancedPhonecall,
        /// <summary>
        /// 
        /// </summary>
        Finance,
        /// <summary>
        /// 
        /// </summary>
        Meeting,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Nova2,
        /// <summary>
        /// 
        /// </summary>
        Nova2Automotive,
        /// <summary>
        /// 
        /// </summary>
        Nova2Conversationalai,
        /// <summary>
        /// 
        /// </summary>
        Nova2Drivethru,
        /// <summary>
        /// 
        /// </summary>
        Nova2Finance,
        /// <summary>
        /// 
        /// </summary>
        Nova2General,
        /// <summary>
        /// 
        /// </summary>
        Nova2Medical,
        /// <summary>
        /// 
        /// </summary>
        Nova2Meeting,
        /// <summary>
        /// 
        /// </summary>
        Nova2Video,
        /// <summary>
        /// 
        /// </summary>
        Nova2Voicemail,
        /// <summary>
        /// 
        /// </summary>
        Nova3,
        /// <summary>
        /// 
        /// </summary>
        Nova3General,
        /// <summary>
        /// 
        /// </summary>
        Nova3Medical,
        /// <summary>
        /// 
        /// </summary>
        NovaGeneral,
        /// <summary>
        /// 
        /// </summary>
        NovaMedical,
        /// <summary>
        /// 
        /// </summary>
        NovaPhonecall,
        /// <summary>
        /// 
        /// </summary>
        Phonecall,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListenPostParametersModel0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListenPostParametersModel0 value)
        {
            return value switch
            {
                V1ListenPostParametersModel0.Base => "base",
                V1ListenPostParametersModel0.Conversationalai => "conversationalai",
                V1ListenPostParametersModel0.Enhanced => "enhanced",
                V1ListenPostParametersModel0.EnhancedFinance => "enhanced-finance",
                V1ListenPostParametersModel0.EnhancedGeneral => "enhanced-general",
                V1ListenPostParametersModel0.EnhancedMeeting => "enhanced-meeting",
                V1ListenPostParametersModel0.EnhancedPhonecall => "enhanced-phonecall",
                V1ListenPostParametersModel0.Finance => "finance",
                V1ListenPostParametersModel0.Meeting => "meeting",
                V1ListenPostParametersModel0.Nova => "nova",
                V1ListenPostParametersModel0.Nova2 => "nova-2",
                V1ListenPostParametersModel0.Nova2Automotive => "nova-2-automotive",
                V1ListenPostParametersModel0.Nova2Conversationalai => "nova-2-conversationalai",
                V1ListenPostParametersModel0.Nova2Drivethru => "nova-2-drivethru",
                V1ListenPostParametersModel0.Nova2Finance => "nova-2-finance",
                V1ListenPostParametersModel0.Nova2General => "nova-2-general",
                V1ListenPostParametersModel0.Nova2Medical => "nova-2-medical",
                V1ListenPostParametersModel0.Nova2Meeting => "nova-2-meeting",
                V1ListenPostParametersModel0.Nova2Video => "nova-2-video",
                V1ListenPostParametersModel0.Nova2Voicemail => "nova-2-voicemail",
                V1ListenPostParametersModel0.Nova3 => "nova-3",
                V1ListenPostParametersModel0.Nova3General => "nova-3-general",
                V1ListenPostParametersModel0.Nova3Medical => "nova-3-medical",
                V1ListenPostParametersModel0.NovaGeneral => "nova-general",
                V1ListenPostParametersModel0.NovaMedical => "nova-medical",
                V1ListenPostParametersModel0.NovaPhonecall => "nova-phonecall",
                V1ListenPostParametersModel0.Phonecall => "phonecall",
                V1ListenPostParametersModel0.Video => "video",
                V1ListenPostParametersModel0.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListenPostParametersModel0? ToEnum(string value)
        {
            return value switch
            {
                "base" => V1ListenPostParametersModel0.Base,
                "conversationalai" => V1ListenPostParametersModel0.Conversationalai,
                "enhanced" => V1ListenPostParametersModel0.Enhanced,
                "enhanced-finance" => V1ListenPostParametersModel0.EnhancedFinance,
                "enhanced-general" => V1ListenPostParametersModel0.EnhancedGeneral,
                "enhanced-meeting" => V1ListenPostParametersModel0.EnhancedMeeting,
                "enhanced-phonecall" => V1ListenPostParametersModel0.EnhancedPhonecall,
                "finance" => V1ListenPostParametersModel0.Finance,
                "meeting" => V1ListenPostParametersModel0.Meeting,
                "nova" => V1ListenPostParametersModel0.Nova,
                "nova-2" => V1ListenPostParametersModel0.Nova2,
                "nova-2-automotive" => V1ListenPostParametersModel0.Nova2Automotive,
                "nova-2-conversationalai" => V1ListenPostParametersModel0.Nova2Conversationalai,
                "nova-2-drivethru" => V1ListenPostParametersModel0.Nova2Drivethru,
                "nova-2-finance" => V1ListenPostParametersModel0.Nova2Finance,
                "nova-2-general" => V1ListenPostParametersModel0.Nova2General,
                "nova-2-medical" => V1ListenPostParametersModel0.Nova2Medical,
                "nova-2-meeting" => V1ListenPostParametersModel0.Nova2Meeting,
                "nova-2-video" => V1ListenPostParametersModel0.Nova2Video,
                "nova-2-voicemail" => V1ListenPostParametersModel0.Nova2Voicemail,
                "nova-3" => V1ListenPostParametersModel0.Nova3,
                "nova-3-general" => V1ListenPostParametersModel0.Nova3General,
                "nova-3-medical" => V1ListenPostParametersModel0.Nova3Medical,
                "nova-general" => V1ListenPostParametersModel0.NovaGeneral,
                "nova-medical" => V1ListenPostParametersModel0.NovaMedical,
                "nova-phonecall" => V1ListenPostParametersModel0.NovaPhonecall,
                "phonecall" => V1ListenPostParametersModel0.Phonecall,
                "video" => V1ListenPostParametersModel0.Video,
                "voicemail" => V1ListenPostParametersModel0.Voicemail,
                _ => null,
            };
        }
    }
}